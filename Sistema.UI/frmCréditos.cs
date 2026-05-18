using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Sistema.BLL.Factories;
using Sistema.Entities.Ventas;
using Sistema.Entities.Creditos;

namespace Sistema.UI
{
    public partial class frmCréditos : Form
    {
        private string textoBusqueda = "";
        private string filtroEstado = "Todos"; // Controla qué mostrar en la grilla

        // Variable global para soportar la exportación limpia que estructuramos antes
        private List<Credito> creditosFiltrados = new List<Credito>();

        // Constructor normal por defecto
        public frmCréditos()
        {
            InitializeComponent();

            // 1. Vinculación de Eventos
            this.Load += frmCréditos_Load;
            this.txtBuscarCredito.TextChanged += txtBuscarCredito_TextChanged_1;
            this.dgvCreditos.CellDoubleClick += dgvCreditos_CellDoubleClick;
            this.dgvCreditos.CellFormatting += dgvCreditos_CellFormatting;

            // Placeholder para la búsqueda
            txtBuscarCredito.PlaceholderText = "Buscar por nombre de cliente o DPI";
        }

        // ---- NUEVO CONSTRUCTOR SOBRECARGADO ADICIONAL
        public frmCréditos(string filtroInicial) : this()
        {
            this.filtroEstado = filtroInicial;
        }

        private void frmCréditos_Load(object sender, EventArgs e)
        {
            ConfigurarColumnas();
            RefrescarGrilla();
        }

        private void ConfigurarColumnas()
        {
            dgvCreditos.Columns.Clear();
            dgvCreditos.RowHeadersVisible = false;
            dgvCreditos.AllowUserToAddRows = false;
            dgvCreditos.ReadOnly = true;
            dgvCreditos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCreditos.MultiSelect = false;

            dgvCreditos.BorderStyle = BorderStyle.None;
            dgvCreditos.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvCreditos.BackgroundColor = Color.FromArgb(15, 19, 23);
            dgvCreditos.GridColor = Color.FromArgb(45, 45, 48);
            dgvCreditos.EnableHeadersVisualStyles = false;

            DataGridViewCellStyle estiloCeldas = new DataGridViewCellStyle();
            estiloCeldas.BackColor = Color.FromArgb(15, 19, 23);
            estiloCeldas.ForeColor = Color.White;
            estiloCeldas.SelectionBackColor = Color.FromArgb(40, 45, 50);
            estiloCeldas.SelectionForeColor = Color.White;
            estiloCeldas.Font = new Font("Segoe UI", 13F, FontStyle.Regular);
            estiloCeldas.WrapMode = DataGridViewTriState.True;
            estiloCeldas.Padding = new Padding(5, 10, 5, 10);

            dgvCreditos.DefaultCellStyle = estiloCeldas;
            dgvCreditos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dgvCreditos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvCreditos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(25, 25, 30);
            dgvCreditos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvCreditos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dgvCreditos.ColumnHeadersHeight = 45;

            dgvCreditos.Columns.Add("colId", "ID");
            dgvCreditos.Columns["colId"].Visible = false;
            dgvCreditos.Columns.Add("colDPI", "DPI");
            dgvCreditos.Columns.Add("colCliente", "Cliente");
            dgvCreditos.Columns.Add("colEmision", "Emisión");
            dgvCreditos.Columns.Add("colVencimiento", "Vencimiento");
            dgvCreditos.Columns.Add("colTotal", "Total Crédito");
            dgvCreditos.Columns.Add("colSaldo", "Saldo Pendiente");
            dgvCreditos.Columns.Add("colEstado", "Estado");

            dgvCreditos.Columns["colDPI"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvCreditos.Columns["colCliente"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCreditos.Columns["colCliente"].FillWeight = 150;

            string[] celdasAuto = { "colEmision", "colVencimiento", "colTotal", "colSaldo", "colEstado" };
            foreach (string col in celdasAuto)
                dgvCreditos.Columns[col].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            foreach (DataGridViewColumn col in dgvCreditos.Columns) { col.SortMode = DataGridViewColumnSortMode.NotSortable; }

            dgvCreditos.DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
            dgvCreditos.Columns["colTotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
            dgvCreditos.Columns["colSaldo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
            dgvCreditos.Columns["colEstado"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
        }

        private void RefrescarGrilla()
        {
            try
            {
                using (var service = ServiceFactory.CrearCreditoService())
                {
                    var lista = service.ListarCreditos();
                    DateTime hoy = DateTime.Now.Date;

                    var query = lista.AsEnumerable();

                    // --- BÚSQUEDA MODIFICADA (SOPORTA NOMBRE O DPI) ---
                    if (!string.IsNullOrEmpty(textoBusqueda))
                    {
                        string bus = textoBusqueda.ToLower().Trim();
                        query = query.Where(c =>
                            (c.Venta?.Cliente?.Nombre != null && c.Venta.Cliente.Nombre.ToLower().Contains(bus)) ||
                            (c.Venta?.Cliente?.DPI != null && c.Venta.Cliente.DPI.Contains(bus))
                        );
                    }

                    // --- FILTROS DE ESTADO
                    if (filtroEstado == "PorCobrar")
                    {
                        query = query.Where(c => c.Estado == EstadoCredito.Pendiente ||
                                               (c.SaldoPendiente > 0 && c.FechaVencimiento.Date < hoy && c.Estado != EstadoCredito.Cancelado));
                    }
                    else if (filtroEstado == "Pendiente")
                    {
                        query = query.Where(c => c.Estado == EstadoCredito.Pendiente && c.FechaVencimiento.Date >= hoy);
                    }
                    else if (filtroEstado == "Pagado")
                    {
                        query = query.Where(c => c.Estado == EstadoCredito.Pagado);
                    }
                    else if (filtroEstado == "Cancelado")
                    {
                        query = query.Where(c => c.Estado == EstadoCredito.Cancelado);
                    }
                    else if (filtroEstado == "Vencido")
                    {
                        query = query.Where(c => c.SaldoPendiente > 0 && c.FechaVencimiento.Date < hoy && c.Estado != EstadoCredito.Cancelado);
                    }

                    // Guardamos la lista filtrada actual para la interfaz de reportes
                    creditosFiltrados = query.ToList();

                    dgvCreditos.Rows.Clear();

                    foreach (var c in creditosFiltrados)
                    {
                        string mostrarEstado = c.Estado.ToString();

                        // Lógica visual para Vencidos
                        if (c.SaldoPendiente > 0 && c.FechaVencimiento.Date < hoy && c.Estado != EstadoCredito.Cancelado)
                            mostrarEstado = "Vencido";

                        // EXTRAEMOS EL DPI Y NOMBRE REAL CON VALIDACIONES DE NULOS
                        string dpiReal = c.Venta?.Cliente?.DPI ?? "---";
                        string clienteReal = c.Venta?.Cliente?.Nombre ?? "Consumidor Final";

                        dgvCreditos.Rows.Add(
                            c.Id,
                            dpiReal, // <--- CAMBIO: Cargamos el DPI real en la columna correspondiente
                            clienteReal,
                            c.FechaInicio.ToShortDateString(),
                            c.FechaVencimiento.ToShortDateString(),
                            string.Format("Q{0:N2}", c.TotalCredito),
                            string.Format("Q{0:N2}", c.SaldoPendiente),
                            mostrarEstado
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar créditos: " + ex.Message);
            }
        }

        private void dgvCreditos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvCreditos.Columns[e.ColumnIndex].Name == "colEstado" && e.Value != null)
            {
                string estado = e.Value.ToString();
                if (estado == "Pendiente") e.CellStyle.ForeColor = Color.FromArgb(255, 180, 0);
                else if (estado == "Vencido") e.CellStyle.ForeColor = Color.Red;
                else if (estado == "Pagado") e.CellStyle.ForeColor = Color.FromArgb(70, 255, 120);
                else if (estado == "Cancelado") e.CellStyle.ForeColor = Color.Gray;
            }
        }

        private void dgvCreditos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            int idSeleccionado = Convert.ToInt32(dgvCreditos.Rows[e.RowIndex].Cells["colId"].Value);

            frmDetalleCredito ventanaModal = new frmDetalleCredito(idSeleccionado);
            ventanaModal.ShowDialog();
            RefrescarGrilla();
        }

        private void txtBuscarCredito_TextChanged_1(object sender, EventArgs e)
        {
            textoBusqueda = txtBuscarCredito.Text;
            RefrescarGrilla();
        }

        private void btnFiltrarCredito_Click(object sender, EventArgs e)

        {

            menuFiltroscreditos.Show(btnFiltrosrCredito, new Point(0, btnFiltrosrCredito.Height));

        }

        private void verTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filtroEstado = "Todos";
            RefrescarGrilla();
        }

        private void pendientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filtroEstado = "Pendiente";
            RefrescarGrilla();
        }

        private void pagadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filtroEstado = "Pagado";
            RefrescarGrilla();
        }

        private void vencidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filtroEstado = "Vencido";
            RefrescarGrilla();
        }

        private void canceladosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filtroEstado = "Cancelado";
            RefrescarGrilla();
        }
    }
}