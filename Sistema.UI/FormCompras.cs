using Sistema.BLL.Services;
using Sistema.DAL.Repositories;
using Sistema.Entities.Productos;
using Sistema.Entities.Ventas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistema.UI
{
    public partial class FormCompras : Form
    {
        private List<CartItem> carrito = new List<CartItem>();
        private InventarioService _inventarioService;
        private List<Producto> productosAll;
        private string resultado = string.Empty;
        public FormCompras()
        {
            InitializeComponent();
            if (Program.Context != null)
            {

                // Inicializar InventarioService con el contexto compartido
                var productoRepository = new ProductoRepository(Program.Context);
                _inventarioService = new InventarioService(Program.Context, productoRepository);
            }
            else
            {
                throw new InvalidOperationException("El contexto de base de datos no está disponible.");
            }

            this.Load += Ventas_Load;
           
        }

        private void Ventas_Load(object? sender, EventArgs e)
        {

            CargarProductos();

        }

        private void CargarProductos()
        {
            try
            {
                // Cargar productos activos desde la base de datos a través del InventarioService
                productosAll = _inventarioService.ObtenerProductosActivos();

                if (productosAll.Count == 0)
                {
                    MessageBox.Show("No hay productos activos en la base de datos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                productosAll = new List<Producto>();
            }

            RefrescarListaProductos(productosAll);
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && dataGridView1.CurrentRow != null)
            {
                var productoSeleccionado = dataGridView1.CurrentRow.Tag as Producto;
                if (productoSeleccionado != null && !carrito.Any(x => x.Producto.Id == productoSeleccionado.Id))
                
                {
                    agregarprecionew(sender, e); // Abrir ventana para ingresar precio
                    
                }
                AñadirProductoSeleccionadoDesdeLista();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }



        private void dataGridView1_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dataGridView1!.Rows[e.RowIndex];
            var prod = row.Tag as Producto;
            if (!carrito.Any(x => x.Producto.Id == prod.Id)) {
                agregarprecionew(sender, e);}
            if (prod != null)
            {
                AgregarProductoAlCarrito(prod);
            }
        }


        private void RefrescarListaProductos(List<Producto> productos)
        {
            dataGridView1!.Rows.Clear();
            foreach (var prod in productos)
            {
                int rowIndex = dataGridView1.Rows.Add(
                    prod.Nombre,
                    prod.Descripcion ?? ""
                );
                dataGridView1.Rows[rowIndex].Tag = prod;
            }
            if (productos.Count > 0 && dataGridView1.Rows.Count > 0)
            {
                dataGridView1.ClearSelection();
                dataGridView1.Rows[0].Selected = true;
            }
        }



        private void button2_Click(object sender, EventArgs e)//Ver Compras
        {
            var host = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            if (host != null)
            {
                host.AbrirFormEnPanel(new FormVerCompras());
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e) //Agregar Proveedor
        {
            FormAgregarProveedor ventanamodal = new FormAgregarProveedor();

            ventanamodal.StartPosition = FormStartPosition.CenterScreen;
            ventanamodal.ShowDialog();
            ventanamodal.ResumeLayout();
        }

        private void button4_Click(object sender, EventArgs e) //Agregar Producto
        {
            frmMantenimientoProducto ventanaModal = new frmMantenimientoProducto();
            ventanaModal.ShowDialog();
            CargarProductos(); // Recargar productos después de cerrar el modal
            ventanaModal.ResumeLayout();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var term = textBox1.Text?.Trim() ?? string.Empty;

            // Ignorar placeholder
            if (string.IsNullOrWhiteSpace(term) || term == "Añadir Producto")
            {
                RefrescarListaProductos(productosAll);
                return;
            }

            var filtered = productosAll
                .Where(p => p.Nombre.IndexOf(term, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();

            RefrescarListaProductos(filtered);
        }

       

        private void AñadirProductoSeleccionadoDesdeLista()
        {
            if (dataGridView1!.SelectedRows.Count > 0)
            {
                var row = dataGridView1.SelectedRows[0];
                var prod = row.Tag as Producto;
                if (prod != null)
                {
                    
                    AgregarProductoAlCarrito(prod);
                }
            }
        }

        private void agregarprecionew(object sender, EventArgs e)
        {
            using (Formnuevoprecio ventana = new Formnuevoprecio())
            {
                // Esto detiene la ejecución hasta que se cierre la ventana
                if (ventana.ShowDialog() == DialogResult.OK)
                {
                    resultado = ventana.DatoIngresado;

                }
            }
        }

        private void AgregarProductoAlCarrito(Producto prod)
        {
            var existente = carrito.FirstOrDefault(x => x.Producto.Id == prod.Id);


            if (existente != null)
            {
                existente.Cantidad++;
            }
            else
            {
                carrito.Add(new CartItem(prod, 1));
            }

            RefrescarCarrito(carrito.Count - 1);
        }

        private void RefrescarCarrito(int index)
        {
            var item = carrito[index];
            if (index < dataGridView2.Rows.Count)
            {
                // Actualizar fila existente
                var row = dataGridView2.Rows[index];
                row.Cells["clm_productoname"].Value = item.Producto.Nombre;
                row.Cells["clm_preciocompra"].Value = resultado;
                row.Cells["clm_cantidad"].Value = item.Cantidad;
                row.Cells["clm_subtotal"].Value = item.Subtotal;
                resultado = string.Empty; // Limpiar resultado después de usarlo
            }
            else
            {
                // Agregar nueva fila
                dataGridView2.Rows.Add(item.Producto.Nombre, item.Cantidad, resultado, item.Subtotal);
            }
            label5.Text = $"Total: {CalcularTotal():C}";
        }

        private decimal CalcularTotal()
        {
            return carrito.Sum(x => x.Subtotal);
        }

      
        

    }
}
