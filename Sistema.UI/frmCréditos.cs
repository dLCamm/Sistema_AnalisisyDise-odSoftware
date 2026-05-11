using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Sistema.BLL.Factories; // Asegúrate de que esta ruta sea la correcta
using Sistema.BLL.Services;
using Sistema.Entities.Creditos;

namespace Sistema.UI
{
    public partial class frmCréditos : Form
    {
        // API para el placeholder (CueBanner)
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);
        private const int EM_SETCUEBANNER = 0x1501;

        public frmCréditos()
        {
            InitializeComponent();
            ConfigurarPlaceholders();
            ConfigurarDataGridView();

            // Suscribir eventos manualmente por seguridad
            this.txtBuscarCredito.TextChanged += new EventHandler(txtBuscarCredito_TextChanged);
            this.dgvCreditos.CellDoubleClick += new DataGridViewCellEventHandler(dgvCreditos_CellDoubleClick);
        }

        private void frmCréditos_Load(object sender, EventArgs e)
        {
            RefrescarGrilla();
        }

        private void ConfigurarPlaceholders()
        {
            SendMessage(txtBuscarCredito.Handle, EM_SETCUEBANNER, 0, "Buscar por cliente o DPI...");
        }

        private void ConfigurarDataGridView()
        {
            dgvCreditos.AutoGenerateColumns = false;
            dgvCreditos.ReadOnly = true;
            dgvCreditos.AllowUserToAddRows = false;
            dgvCreditos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCreditos.MultiSelect = false;
            dgvCreditos.RowHeadersVisible = false;
            dgvCreditos.BackgroundColor = Color.FromArgb(30, 30, 40); // Ajusta al color de tu UI

            dgvCreditos.Columns.Clear();

            // Columna Invisible para el ID (para poder abrir el detalle)
            dgvCreditos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id",
                Name = "colId",
                Visible = false
            });

            // Columnas solicitadas
            dgvCreditos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NombreCliente",
                HeaderText = "Cliente",
                Width = 200
            });

            dgvCreditos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DpiCliente",
                HeaderText = "DPI",
                Width = 120
            });

            dgvCreditos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FechaEmision",
                HeaderText = "Emisión",
                Width = 100
            });

            dgvCreditos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Total",
                HeaderText = "Total Crédito",
                Width = 110,
                DefaultCellStyle = { Format = "Q#,##0.00" }
            });

            dgvCreditos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Saldo",
                HeaderText = "Saldo Pendiente",
                Width = 110,
                DefaultCellStyle = { Format = "Q#,##0.00" }
            });

            dgvCreditos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "EstadoStr",
                HeaderText = "Estado",
                Width = 100
            });
        }

        public void RefrescarGrilla()
        {
            try
            {
                using (var service = ServiceFactory.CrearCreditoService())
                {
                    var lista = service.ListarCreditos();
                    string busqueda = txtBuscarCredito.Text.ToLower().Trim();

                    // Filtrado por Cliente o DPI
                    var filtrados = lista.Where(c =>
                        c.Cliente.Nombre.ToLower().Contains(busqueda)
                    // || c.Cliente.Dpi.Contains(busqueda) // <-- Código de DPI comentado
                    );

                    // Mapeo a objeto anónimo para la grilla
                    dgvCreditos.DataSource = filtrados.Select(c => new
                    {
                        c.Id,
                        NombreCliente = c.Cliente.Nombre,
                        DpiCliente = "---", // c.Cliente.Dpi,
                        FechaEmision = c.FechaInicio.ToShortDateString(),
                        Total = c.TotalCredito,
                        Saldo = c.SaldoPendiente,
                        // Lógica para estado Vencido (Si saldo > 0 y ya pasó la fecha)
                        EstadoStr = (c.SaldoPendiente > 0 && c.FechaVencimiento < DateTime.Now)
                                    ? "Vencido"
                                    : c.Estado.ToString()
                    }).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los créditos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBuscarCredito_TextChanged(object sender, EventArgs e)
        {
            RefrescarGrilla();
        }

        private void dgvCreditos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Validar que no sea el encabezado
            if (e.RowIndex >= 0)
            {
                int idCredito = (int)dgvCreditos.Rows[e.RowIndex].Cells["colId"].Value;

                // Abrir el detalle pasando el ID al constructor
                frmDetalleCredito frmDetalle = new frmDetalleCredito(idCredito);
                frmDetalle.ShowDialog();

                // Al regresar, refrescamos por si se hicieron abonos o anulaciones
                RefrescarGrilla();
            }
        }

        private void btnNuevoCredito_Click(object sender, EventArgs e)
        {
            // Aquí llamarías a tu form de ventas o creación de crédito
        }

        private void dgvCreditos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}