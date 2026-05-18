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
            // Evento Doble click para edición
            dgvProductos.CellDoubleClick += dgvProductos_CellDoubleClick;
        }

        // ---- NUEVO CONSTRUCTOR SOBRECARGADO ADICIONAL 
        public frmInventario(string filtroInicial) : this() 
        {
            this.filtroActual = filtroInicial;
        }

        private void RefrescarGrilla()
        {
            try
            {
                using (var service = ServiceFactory.CrearInventarioService())
                {
                    // 1. OBTENER LISTA BASE Y FILTRAR SEGÚN EL ESTADO
                    List<Producto> listaCompleta = service.ListarProductos();
                    IEnumerable<Producto> query;

                    if (filtroActual == "Alertas")
                    {
                        // ---- CASO DASHBOARD: Une los productos Sin Existencias Y los de Stock Bajo ----
                        query = listaCompleta.Where(p => p.Estado == EstadoProducto.Activo && (p.Stock <= 0 || p.Stock <= p.StockMinimo));
                    }
                    else if (filtroActual == "Bajo")
                    {
                        // Filtro normal: Solo activos, con stock mayor a 0 pero menor o igual al mínimo
                        query = listaCompleta.Where(p => p.Estado == EstadoProducto.Activo && p.Stock > 0 && p.Stock <= p.StockMinimo);
                    }
                    else if (filtroActual == "Sin")
                    {
                        // Filtro normal: Solo activos que se quedaron en 0 o menos
                        query = listaCompleta.Where(p => p.Estado == EstadoProducto.Activo && p.Stock <= 0);
                    }
                    else if (filtroActual == "Anulados")
                    {
                        query = listaCompleta.Where(p => p.Estado == EstadoProducto.Inactivo);
                    }
                    else if (filtroActual == "Activos")
                    {
                        query = listaCompleta.Where(p => p.Estado == EstadoProducto.Activo);
                    }
                    else
                    {
                        query = listaCompleta;
                    }

                    // 2. APLICAR BÚSQUEDA POR TEXTO (Nombre o Descripción)
                    if (!string.IsNullOrEmpty(textoBusqueda))
                    {
                        string bus = textoBusqueda.ToLower();
                        query = query.Where(p => p.Nombre.ToLower().Contains(bus) ||
                                               (p.Descripcion ?? "").ToLower().Contains(bus));
                    }

                    // 3. APLICAR ORDENAMIENTO POR FECHA 
                    if (ordenFecha == "ASC")
                        query = query.OrderBy(p => p.FechaCreacion);
                    else if (ordenFecha == "DESC")
                        query = query.OrderByDescending(p => p.FechaCreacion);

                    dgvProductos.Rows.Clear();

                    foreach (var p in query)
                    {
                        string estadoVisual = "Activo";
                        if (p.Estado == EstadoProducto.Inactivo) estadoVisual = "Anulado";
                        else if (p.Stock <= 0) estadoVisual = "Sin Existencias";
                        else if (p.Stock <= p.StockMinimo) estadoVisual = "Stock Bajo";

                        dgvProductos.Rows.Add(
                            p.Id,
                            p.Nombre,
                            p.Descripcion,
                            string.Format("Q{0:N2}", p.PrecioCompra), // Formato Quetzales
                            string.Format("Q{0:N2}", p.PrecioVenta),  // Formato Quetzales
                            p.Stock,
                            estadoVisual,
                            p.FechaCreacion.ToShortDateString() // Propiedad de Sebastian
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

            // 1. Columnas base
            dgvProductos.Columns.Add("colId", "ID");
            dgvProductos.Columns["colId"].Visible = false;

            dgvProductos.Columns.Add("colNombre", "Producto");
            dgvProductos.Columns.Add("colDescripcion", "Descripción");
            dgvProductos.Columns.Add("colPrecioCompra", "Precio Compra");
            dgvProductos.Columns.Add("colPrecioVenta", "Precio Venta");
            dgvProductos.Columns.Add("colStock", "Stock");
            dgvProductos.Columns.Add("colStatus", "Estado");
            dgvProductos.Columns.Add("colFecha", "Fecha Ingreso");

            dgvProductos.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            Padding margenExtra = new Padding(5, 15, 5, 15);
            dgvProductos.DefaultCellStyle.Padding = margenExtra;

            // Ajuste automático de altura 
            dgvProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // --- 3. REPARTO DE ANCHOS ---
            dgvProductos.Columns["colPrecioCompra"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvProductos.Columns["colPrecioVenta"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvProductos.Columns["colStock"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvProductos.Columns["colStatus"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvProductos.Columns["colFecha"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dgvProductos.Columns["colNombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvProductos.Columns["colDescripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvProductos.Columns["colNombre"].FillWeight = 40;
            dgvProductos.Columns["colDescripcion"].FillWeight = 60;

            // --- 4. BLOQUEO DE ORDENAMIENTO Y ALINEACIONES ---
            foreach (DataGridViewColumn col in dgvProductos.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            dgvProductos.Columns["colStatus"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProductos.Columns["colStock"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProductos.Columns["colFecha"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProductos.Columns["colPrecioCompra"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvProductos.Columns["colPrecioVenta"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // Alineación superior 
            dgvProductos.DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;

            dgvProductos.Columns["colStatus"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            dgvProductos.Columns["colStock"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            dgvProductos.Columns["colFecha"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            dgvProductos.Columns["colPrecioCompra"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
            dgvProductos.Columns["colPrecioVenta"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
        }

        private void dgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
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

        // --- MANEJO DE FILTROS Y EVENTOS ---

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

        private void anuladosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filtroActual = "Anulados";
            RefrescarGrilla();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            frmMantenimientoProducto ventanaModal = new frmMantenimientoProducto();
            ventanaModal.ShowDialog();
            RefrescarGrilla();
        }

        private void btnRefrescar_Click(object sender, EventArgs e) => RefrescarGrilla();

        // --- MÉTODOS REQUERIDOS POR EL DESIGNER 
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void menuFiltros_Opening(object sender, CancelEventArgs e) { }
        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void button1_Click(object sender, EventArgs e) { }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            // 1. Buscamos el formulario principal (Host) para poder incrustar la nueva pantalla en el panel
            var host = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            FormCompras ventanaCompras;

            // 2. Verificamos si hay una fila seleccionada actualmente en el DataGridView de productos
            if (dgvProductos.CurrentRow != null && dgvProductos.CurrentRow.Index >= 0)
            {
                try
                {
                    // Capturamos el ID de la celda "colId" de la fila seleccionada por el usuario
                    int idSeleccionado = Convert.ToInt32(dgvProductos.CurrentRow.Cells["colId"].Value);

                    // Creamos un objeto Producto temporal con ese ID
                    Producto productoSugerido = new Producto { Id = idSeleccionado };

                    // Instanciamos el formulario de Compras pasándole el producto seleccionado
                    ventanaCompras = new FormCompras(productoSugerido);
                }
                catch (Exception ex)
                {
                    // En caso de un error inesperado al leer la grilla, creamos el formulario normal (vacío)
                    MessageBox.Show("Aviso: No se pudo preseleccionar el producto. Abriendo compras de forma normal. " + ex.Message,
                                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ventanaCompras = new FormCompras();
                }
            }
            else
            {
                // Si el usuario no dio clic a ningún producto o la tabla está vacía, abrimos compras limpio
                ventanaCompras = new FormCompras();
            }

            // 3. Procedemos a abrir la pantalla dentro del panel principal
            if (host != null)
            {
                // Se utiliza el método dinámico que ya tienes implementado en tu formulario base
                host.AbrirFormEnPanel(ventanaCompras);
            }
            else
            {
                // Respaldo de seguridad: si ejecutas este formulario suuelto en modo de pruebas, se abrirá como modal
                ventanaCompras.ShowDialog();
            }
        }

        private void fechaDescToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ordenFecha = "DESC";
            RefrescarGrilla();
        }

        private void fechaAscToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ordenFecha = "ASC";
            RefrescarGrilla();
        
        }
    }
}