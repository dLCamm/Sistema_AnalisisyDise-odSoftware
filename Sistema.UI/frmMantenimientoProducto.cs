using System;
using System.Windows.Forms;
using Sistema.BLL.Factories;
using Sistema.Entities.Productos;

namespace Sistema.UI
{
    public partial class frmMantenimientoProducto : Form
    {
        // Variable para controlar si es un nuevo producto o una edición
        private int? _idParaEditar = null;

        // Constructor para REGISTRAR NUEVO
        public frmMantenimientoProducto()
        {
            InitializeComponent();
            this.Text = "Registrar Producto - La Momosteca";
        }

        // Constructor para EDITAR 
        public frmMantenimientoProducto(int id)
        {
            InitializeComponent();
            this._idParaEditar = id;
            this.Text = "Modificar Producto - La Momosteca";
        }

        private void frmMantenimientoProducto_Load(object sender, EventArgs e)
        {
            // mostrar el botón "Anular" si el producto ya existe
            btnAnular.Visible = (_idParaEditar != null);

            if (_idParaEditar != null)
            {
                CargarDatosParaEditar();
            }
        }

        private void CargarDatosParaEditar()
        {
            try
            {
                using (var service = ServiceFactory.CrearInventarioService())
                {
                    var p = service.ObtenerProducto(_idParaEditar.Value);

                    txtNombre.Text = p.Nombre;
                    txtDescripcion.Text = p.Descripcion;
                    txtPrecioCompra.Text = p.PrecioCompra.ToString();
                    txtPrecioVenta.Text = p.PrecioVenta.ToString();
                    txtStockActual.Text = p.Stock.ToString();
                    txtStockMinimo.Text = p.StockMinimo.ToString();
                }
            }
            catch (Exception ex) { MessageBox.Show("Error al cargar: " + ex.Message); }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var service = ServiceFactory.CrearInventarioService())
                {
                    if (_idParaEditar == null)
                    {

                        var nuevo = new Producto
                        {
                            Nombre = txtNombre.Text,
                            Descripcion = txtDescripcion.Text,
                            PrecioCompra = decimal.Parse(txtPrecioCompra.Text),
                            PrecioVenta = decimal.Parse(txtPrecioVenta.Text),
                            Stock = int.Parse(txtStockActual.Text),
                            StockMinimo = int.Parse(txtStockMinimo.Text)
                        };
                        service.RegistrarProducto(nuevo);
                        MessageBox.Show("Producto guardado con éxito.");
                    }
                    else
                    {

                        service.ActualizarStock(_idParaEditar.Value, int.Parse(txtStockActual.Text));
                        MessageBox.Show("Stock actualizado con éxito.");
                    }
                    this.Close();
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            if (_idParaEditar == null) return;

            var confirm = MessageBox.Show("¿Seguro que desea anular este producto?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                using (var service = ServiceFactory.CrearInventarioService())
                {
                    service.DesactivarProducto(_idParaEditar.Value);
                    MessageBox.Show("Producto Anulado.");
                    this.Close();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e) => this.Close();

        private void btnAnular_Click_1(object sender, EventArgs e)
        {
            if (_idParaEditar == null) return;

            var confirm = MessageBox.Show("¿Seguro que desea anular este producto?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                using (var service = ServiceFactory.CrearInventarioService())
                {
                    service.DesactivarProducto(_idParaEditar.Value);
                    MessageBox.Show("Producto Anulado.");
                    this.Close();
                }
            }
        }

        private void txtPrecioCompra_TextChanged(object sender, EventArgs e)
        {

        }
    }
}