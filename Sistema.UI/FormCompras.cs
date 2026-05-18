using Sistema.BLL.Services;
using Sistema.DAL.Repositories;
using Sistema.Entities.Productos;
using Sistema.Entities.Proveedores;
using Sistema.Entities.Compras;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using Sistema.BLL.Factories;

namespace Sistema.UI
{
    public partial class FormCompras : Form
    {
        private List<CartItem> carrito = new List<CartItem>();
       
        private List<Producto> productosAll;
        private string resultado = string.Empty;
        private List<Proveedor> proveedoresAll;
        
        public FormCompras()
        {
            InitializeComponent();
            
            
            
            this.Load += Ventas_Load;

        }

        private void Ventas_Load(object? sender, EventArgs e)
        {

            CargarProductos();
            LlenarcomboboxProveedores();

        }

        private void CargarProductos()
        {
            try
            {
                using (var service = ServiceFactory.CrearInventarioService())
                {
                    productosAll = service.ObtenerProductosActivos();
                }

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
            LlenarcomboboxProveedores(); 
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

        private void RefrescarCarrito(int? preserveIndex = null)
        {
            // Usamos dataGridView1 como representación del carrito
            int? current = preserveIndex;

            if (!current.HasValue && dataGridView2!.CurrentCell != null)
                current = dataGridView2.CurrentCell.RowIndex;

            dataGridView2.Rows.Clear();

            for (int i = 0; i < carrito.Count; i++)
            {
                var item = carrito[i];
                var nombre = item.Producto?.Nombre ?? "(sin nombre)";
                var precioCompra = $"Q{item.Producto.PrecioCompra:0.00}";
                var cantidad = item.Cantidad.ToString();
                var subtotal = $"Q{item.Subtotal:0.00}";

                // Añadimos en el orden de columnas: Producto, Precio Unitario, Cantidad, Subtotal
                int rowIndex = dataGridView2.Rows.Add(nombre, precioCompra, cantidad, subtotal);
                dataGridView2.Rows[rowIndex].Tag = item;
            }

            // El total se calcula a partir del modelo
            label5!.Text = $"Total: Q{CalcularTotal():0.00}";

            if (current.HasValue && current.Value >= 0 && current.Value < dataGridView2.Rows.Count)
            {
                dataGridView2.ClearSelection();
                dataGridView2.Rows[current.Value].Selected = true;
                dataGridView2.CurrentCell = dataGridView2.Rows[current.Value].Cells[0];
            }
        }

        private decimal CalcularTotal()
        {
            return carrito.Sum(x => x.Subtotal);
        }

        internal class CartItem
        {
            public Producto Producto { get; }
            public int Cantidad { get; set; }

            public decimal PrecioCompra => Producto?.PrecioCompra ?? 0m;

            public decimal Subtotal => PrecioCompra * Cantidad;

            public CartItem(Producto producto, int cantidad)
            {
                Producto = producto;
                Cantidad = cantidad;

            }
        }

        //Para manejar los botones de la tabla del carrito
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dataGridView2!.Rows[e.RowIndex];
            var item = row.Tag as CartItem;
            if (item == null) return;
            var col = dataGridView2.Columns[e.ColumnIndex];
            if (col.Name == "clm_btndismin")
            {
                if (item.Cantidad > 1) item.Cantidad--;
                else carrito.Remove(item);
                int? preserve = carrito.Count == 0 ? (int?)null : Math.Min(e.RowIndex, carrito.Count - 1);
                BeginInvoke(new Action(() => RefrescarCarrito(preserve)));
            }
            else if (col.Name == "clm_btnaumentar")
            {
                item.Cantidad++;
                int? preserve = e.RowIndex;
                BeginInvoke(new Action(() => RefrescarCarrito(preserve)));
            }
            else if (col.Name == "clm_eliminar")
            {
                carrito.Remove(item);
                int? preserve = carrito.Count == 0 ? (int?)null : Math.Min(e.RowIndex, carrito.Count - 1);
                BeginInvoke(new Action(() => RefrescarCarrito(preserve)));
            }
        }

        //Para manejar la edicion de cantidad y de Precio Compra en el carrito

        private void dataGridView2_CellEndEdit(object? sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            var col = dataGridView2.Columns[e.ColumnIndex];
            if (col.Name == "clm_preciocompra")
            {
                var row = dataGridView2.Rows[e.RowIndex];
                var item = row.Tag as CartItem;
                if (item == null) return;
                var cell = row.Cells[e.ColumnIndex];
                var raw = cell?.Value?.ToString();
                if (string.IsNullOrWhiteSpace(raw))
                {
                    // restaurar
                    BeginInvoke(new Action(() => RefrescarCarrito(e.RowIndex)));
                    return;
                }
                if (decimal.TryParse(raw, out decimal newPrice))
                {
                    if (newPrice < 0)
                    {
                        // precio no puede ser negativo, restaurar
                        BeginInvoke(new Action(() => RefrescarCarrito(e.RowIndex)));
                    }
                    else
                    {
                        item.Producto.PrecioCompra = newPrice;
                        BeginInvoke(new Action(() => RefrescarCarrito(e.RowIndex)));
                    }
                }
                else
                {
                    // valor inválido, restaurar
                    BeginInvoke(new Action(() => RefrescarCarrito(e.RowIndex)));
                }
            }
            else if (col.Name == "clm_cantidad")
            {

                var row = dataGridView2.Rows[e.RowIndex];
                var item = row.Tag as CartItem;
                if (item == null) return;

                var cell = row.Cells[e.ColumnIndex];
                var raw = cell?.Value?.ToString();
                if (string.IsNullOrWhiteSpace(raw))
                {
                    // restaurar
                    BeginInvoke(new Action(() => RefrescarCarrito(e.RowIndex)));
                    return;
                }

                if (int.TryParse(raw, out int newQty))
                {
                    if (newQty <= 0)
                    {
                        carrito.Remove(item);
                        int? preserve = carrito.Count == 0 ? (int?)null : Math.Min(e.RowIndex, carrito.Count - 1);
                        BeginInvoke(new Action(() => RefrescarCarrito(preserve)));
                    }
                    else
                    {
                        item.Cantidad = newQty;
                        BeginInvoke(new Action(() => RefrescarCarrito(e.RowIndex)));
                    }
                }
                else
                {
                    // valor inválido, restaurar
                    BeginInvoke(new Action(() => RefrescarCarrito(e.RowIndex)));
                }
            }
            else { return; }
        }

        private void LlenarcomboboxProveedores()
        {
            try
            {
                using (var _proveedorService = ServiceFactory.CrearProveedorService())
                {
                    var proveedoresactivos = _proveedorService.ListarActivos();
                    comboBox1.DataSource = proveedoresactivos;
                    comboBox1.DisplayMember = "Nombre";
                    comboBox1.ValueMember = "Id";
                    comboBox1.SelectedIndex = -1;
                    comboBox1.Text = "Seleccionar Proveedor";
                }
            }
            catch { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (carrito.Count == 0)
            {
                MessageBox.Show("El carrito está vacío. Agregue productos antes de realizar la compra.", "Carrito Vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un proveedor para realizar la compra.", "Proveedor No Seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var proveedor = comboBox1.SelectedItem as Proveedor;
            try
            {
                using (var _compraService = ServiceFactory.CrearCompraService())
                {
                    _compraService.RegistrarCompra(carrito.Select(i => new DetalleCompra
                    {
                        ProductoId = i.Producto.Id,
                        Cantidad = i.Cantidad,
                        PrecioCompra = i.PrecioCompra
                    }).ToList());
                    MessageBox.Show("Compra registrada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    carrito.Clear();
                    RefrescarCarrito();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar la compra: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
