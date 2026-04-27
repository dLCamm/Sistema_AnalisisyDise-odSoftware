using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public frmInventario()
        {
            InitializeComponent();
        }

        private void RefrescarGrilla()
        {
            try
            {
                using (var service = ServiceFactory.CrearInventarioService())
                {
                    List<Producto> lista;

                    // 1. OBTENER LA LISTA 
                 
                    if (filtroActual == "Bajo")
                        lista = service.ObtenerProductosBajoStock();
                    else if (filtroActual == "Activos")
                        lista = service.ObtenerProductosActivos();
                    else
                        lista = service.ListarProductos();

                    dgvProductos.Rows.Clear();

                    // 2. RECORRER Y APLICAR FILTROS 
                    foreach (var p in lista)
                    {
                        // 1. Determinar el estado visual
                        string estadoVisual = "Activo";
                        if (p.Stock <= 0) estadoVisual = "Sin Existencias";
                        else if (p.Stock <= p.StockMinimo) estadoVisual = "Stock Bajo";

                      
                        if (filtroActual == "Bajo" && p.Stock <= 0) continue;

                       
                        if (filtroActual == "Sin" && p.Stock > 0) continue;

                        // Filtro de búsqueda (Buscador)
                        if (!string.IsNullOrEmpty(textoBusqueda) &&
                            !p.Nombre.ToLower().Contains(textoBusqueda.ToLower())) continue;
                    
                        dgvProductos.Rows.Add(p.Nombre, estadoVisual, p.Stock, p.Descripcion);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message);
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            frmMantenimientoProducto ventanaModal = new frmMantenimientoProducto();
            ventanaModal.ShowDialog();
            RefrescarGrilla();

        }

        private void ConfigurarColumnas()
        {
            dgvProductos.Columns.Clear();
            dgvProductos.Columns.Add("colNombre", "Producto");
            dgvProductos.Columns.Add("colStatus", "Estado");
            dgvProductos.Columns.Add("colStock", "Stock");
            dgvProductos.Columns.Add("colDescripcion", "Descripción");

            // Ajustes de tamaño
            dgvProductos.Columns["colNombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvProductos.Columns["colDescripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvProductos.Columns["colStatus"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProductos.Columns["colStock"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
            private void frmInventario_Load(object sender, EventArgs e)
        {
            ConfigurarColumnas(); 
            RefrescarGrilla();
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                else if (estado == "Sin Existencias")
                    e.CellStyle.ForeColor = Color.FromArgb(180, 180, 180);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            RefrescarGrilla();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            menuFiltros.Show(btnFiltrar, new Point(0, btnFiltrar.Height));
        }

        private void menuFiltros_Opening(object sender, CancelEventArgs e)
        {

        }

        private void verTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filtroActual = "Todos";
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

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            textoBusqueda = txtBuscar.Text;
            RefrescarGrilla();
        }
    }
}
