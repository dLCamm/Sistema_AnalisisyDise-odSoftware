using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Sistema.BLL.Services;
using Sistema.BLL.Factories;

namespace Sistema.UI
{
    public partial class frmDashboard : Form
    {
        private readonly ReporteService _reporteService;

        public frmDashboard()
        {
            InitializeComponent();
            _reporteService = ServiceFactory.CrearReporteService();

            // Asignar los eventos de Clic de forma manual para asegurar el comportamiento
            AsignarEventosClics();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            CargarDatosDashboard();
        }

        private void AsignarEventosClics()
        {
            // --- PANEL 5: SIN EXISTENCIAS (STOCK BAJO) ---
           
            panel5.Click += PanelSinExistencias_Click;
            lblStockBajo.Click += PanelSinExistencias_Click;
         

            // --- PANEL 4: CRÉDITOS ---
            panel4.Click += PanelCreditos_Click;
            lblCreditosPendientes.Click += PanelCreditos_Click;
          
        }

        public void CargarDatosDashboard()
        {
            try
            {
                var datos = _reporteService.ObtenerDashboard();

                // 1. Mostrar Ventas de Hoy
                lblVentasHoy.Text = "Q " + datos.VentasHoy.ToString("N2");

                // 2. Mostrar Caja Actual
                lblCajaActual.Text = "Q " + datos.CajaActual.ToString("N2");

                // 3. Mostrar Créditos Pendientes y Vencidos
                lblCreditosPendientes.Text = "Q " + datos.CreditosPendientes.ToString("N2");

                // 4. Mostrar Productos en Stock Bajo / Sin Existencias
                lblStockBajo.Text = datos.ProductosBajoStock.ToString();

                // Lógica visual para las alertas del inventario
                if (datos.ProductosBajoStock > 0)
                {
                    lblStockBajo.ForeColor = Color.Red;
                }
                else
                {
                    lblStockBajo.ForeColor = Color.White;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los indicadores del Dashboard: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ---- MANEJO DEL CLIC EN EL PANEL 5 (SIN EXISTENCIAS) ----
        private void PanelSinExistencias_Click(object sender, EventArgs e)
        {
            var host = Application.OpenForms.OfType<Form1>().FirstOrDefault();

            // Enviamos "Alertas" para que el inventario sepa que viene del Dashboard
            frmInventario ventanaInventario = new frmInventario("Alertas");

            if (host != null)
            {
                host.AbrirFormEnPanel(ventanaInventario);
            }
            else
            {
                ventanaInventario.ShowDialog();
            }
        }

        // ---- MANEJO DEL CLIC EN EL PANEL 4 (CRÉDITOS PENDIENTES / VENCIDOS) ----
        private void PanelCreditos_Click(object sender, EventArgs e)
        {
            var host = Application.OpenForms.OfType<Form1>().FirstOrDefault();

            // "PorCobrar" para unificar la vista
            frmCréditos ventanaCreditos = new frmCréditos("PorCobrar");

            if (host != null)
            {
                host.AbrirFormEnPanel(ventanaCreditos);
            }
            else
            {
                ventanaCreditos.ShowDialog();
            }
        }

        // Métodos requeridos por el diseñador 
        private void panel5_Paint(object sender, PaintEventArgs e) { }
        private void lblStockBajo_Click(object sender, EventArgs e) { }
    }
}