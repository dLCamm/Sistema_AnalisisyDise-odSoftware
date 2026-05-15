using System;
using System.Drawing;
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
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            CargarDatosDashboard();
        }

        public void CargarDatosDashboard()
        {
            try
            {
                // Obtenemos los datos del servicio 
                var datos = _reporteService.ObtenerDashboard();

                // 1. Mostrar Ventas de Hoy
                lblVentasHoy.Text = "Q " + datos.VentasHoy.ToString("N2");

                // 2. Mostrar Caja Actual
                lblCajaActual.Text = "Q " + datos.CajaActual.ToString("N2");

                // 3. Mostrar Créditos Pendientes
                lblCreditosPendientes.Text = "Q " + datos.CreditosPendientes.ToString("N2");

                // 4. Mostrar Productos en Stock Bajo 
                lblStockBajo.Text = datos.ProductosBajoStock.ToString();

                // Lógica visual: Si hay productos en stock bajo
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
    }
}