using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Sistema.BLL.Factories;
using Sistema.Entities.Productos;

namespace Sistema.UI
{
    public partial class frmInventario : Form
    {
        private string filtroActual = "Todos";
        private string textoBusqueda = "";
        private string ordenFecha = "";

        public frmInventario()
        {
            InitializeComponent();
           
            dgvProductos.CellDoubleClick += dgvProductos_CellDoubleClick;
        }

        private void RefrescarGrilla()
        {
            try
            {
                using (var service = ServiceFactory.CrearInventarioService())
                {
                    List<Producto> lista;

                    // 1. Obtener la lista base según el filtro seleccionado
                    if (filtroActual == "Bajo")
                        lista = service.ObtenerProductosBajoStock();
                    else if (filtroActual == "Activos")
                        lista = service.ObtenerProductosActivos();
                    else
                        lista = service.ListarProductos();

                    // 2. Aplicar ordenamiento por fecha
                    if (ordenFecha == "ASC")
                        lista = lista.OrderBy(p => p.FechaCreacion).ToList();
                    else if (ordenFecha == "DESC")
                        lista = lista.OrderByDescending(p => p.FechaCreacion).ToList();

                    dgvProductos.Rows.Clear();

                    // 3. Recorrer y mostrar en la tabla
                    foreach (var p in lista)
                    {
                        string estadoVisual = "Activo";
                        if (p.Estado == EstadoProducto.Inactivo) estadoVisual = "Anulado";
                        else if (p.Stock == 0) estadoVisual = "Sin Existencias";
                        else if (p.Stock <= p.StockMinimo) estadoVisual = "Stock Bajo";

                        if (filtroActual == "Sin" && p.Stock > 0) continue;

                        if (!string.IsNullOrEmpty(textoBusqueda))
                        {
                            string bus = textoBusqueda.ToLower();
                            bool coincide = p.Nombre.ToLower().Contains(bus) ||
                                           (p.Descripcion ?? "").ToLower().Contains(bus);
                            if (!coincide) continue;
                        }

                        // El ID va en la columna 0
                        dgvProductos.Rows.Add(
                            p.Id,
                            p.Nombre,
                            p.Descripcion,
                            p.PrecioCompra,
                            p.PrecioVenta,
                            p.Stock,
                            estadoVisual,
                            p.FechaCreacion.ToShortDateString()
                            
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message);
            }
        }

        private void ConfigurarColumnas()
        {
            dgvProductos.Columns.Clear();
            dgvProductos.RowHeadersVisible = false;

            // Columna ID: No se muestra 
            dgvProductos.Columns.Add("colId", "ID");
            dgvProductos.Columns["colId"].Visible = false;

            dgvProductos.Columns.Add("colNombre", "Producto");
            dgvProductos.Columns.Add("colDescripcion", "Descripción");
            dgvProductos.Columns.Add("colPrecioCompra", "Precio Compra");
            dgvProductos.Columns.Add("colPrecioVenta", "Precio Venta");
            dgvProductos.Columns.Add("colStock", "Stock");
            dgvProductos.Columns.Add("colStatus", "Estado");
            dgvProductos.Columns.Add("colFecha", "Fecha Ingreso");
            
            

            // Formato y alineación
            dgvProductos.Columns["colStatus"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProductos.Columns["colStock"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProductos.Columns["colFecha"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProductos.Columns["colPrecioVenta"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProductos.Columns["colPrecioCompra"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvProductos.Columns["colNombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvProductos.Columns["colDescripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvProductos.Columns["colNombre"].FillWeight = 25;
            dgvProductos.Columns["colDescripcion"].FillWeight = 40;
        }

        private void dgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Extraemos el ID para abrir la edición
            int idSeleccionado = Convert.ToInt32(dgvProductos.Rows[e.RowIndex].Cells["colId"].Value);

            frmMantenimientoProducto ventanaModal = new frmMantenimientoProducto(idSeleccionado);
            ventanaModal.ShowDialog();

            RefrescarGrilla();
        }

        private void frmInventario_Load(object sender, EventArgs e)
        {
            ConfigurarColumnas();
            RefrescarGrilla();
        }

        private void dgvProductos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvProductos.Columns[e.ColumnIndex].Name == "colStatus" && e.Value != null)
            {
                string estado = e.Value.ToString();
                if (estado == "Activo")
                    e.CellStyle.ForeColor = Color.FromArgb(70, 120, 255);
                else if (estado == "Stock Bajo")
                    e.CellStyle.ForeColor = Color.FromArgb(255, 180, 0);
                else if (estado == "Sin Existencias" || estado == "Anulado")
                    e.CellStyle.ForeColor = Color.Red;
            }
        }

        // MÉTODOS DEL BUSCADOR Y FILTROS 

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            textoBusqueda = txtBuscar.Text;
            RefrescarGrilla();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            menuFiltros.Show(btnFiltrar, new Point(0, btnFiltrar.Height));
        }

        private void verTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filtroActual = "Todos";
            ordenFecha = "";
            RefrescarGrilla();
        }

        private void stockBajoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filtroActual = "Bajo";
            RefrescarGrilla();
        }

        private void sinExistenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filtroActual = "Sin";
            RefrescarGrilla();
        }

        private void fechaDescToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ordenFecha = "DESC";
            RefrescarGrilla();
        }

        private void fechaAscToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ordenFecha = "ASC";
            RefrescarGrilla();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            frmMantenimientoProducto ventanaModal = new frmMantenimientoProducto();
            ventanaModal.ShowDialog();
            RefrescarGrilla();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            RefrescarGrilla();
        }

        // MÉTODOS REQUERIDOS POR EL DESIGNER 
      

        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void menuFiltros_Opening(object sender, CancelEventArgs e) { }
        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void button1_Click(object sender, EventArgs e) { }
    }
}