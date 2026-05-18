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
            this.Text = "Registrar Producto";
        }

        // Constructor para EDITAR 
        public frmMantenimientoProducto(int id)
        {
            InitializeComponent();
            this._idParaEditar = id;
            this.Text = "Modificar Producto";
        }

        private void frmMantenimientoProducto_Load(object sender, EventArgs e)
        {
            // Cargar la lista de proveedores siempre al iniciar
            CargarProveedores();

            // Mostrar el botón "Anular" si el producto ya existe
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

                    // Asigna el proveedor guardado al combobox usando el nombre real: ProveedorId
                    if (p.ProveedorId != null)
                    {
                        cmbProveedor.SelectedValue = p.ProveedorId;
                    }

                    // Alternar visibilidad entre botón Activar y Anular según el estado del producto
                    if (p.Estado == EstadoProducto.Inactivo)
                    {
                        btnActivarProducto.Visible = true;
                        btnAnular.Visible = false;
                    }
                    else
                    {
                        btnActivarProducto.Visible = false;
                        btnAnular.Visible = true;
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Error al cargar: " + ex.Message); }
        }

        private void CargarProveedores()
        {
            try
            {
                using (var service = ServiceFactory.CrearProveedorService())
                {
                    var proveedores = service.ListarProveedores();

                    cmbProveedor.DataSource = proveedores;
                    cmbProveedor.DisplayMember = "Nombre";      // Lo que ve el usuario
                    cmbProveedor.ValueMember = "Id";            // El valor interno que se guarda
                    cmbProveedor.SelectedIndex = -1;            // Inicia vacío por defecto
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar proveedores: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validación básica de campos obligatorios
                if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtPrecioCompra.Text) || string.IsNullOrWhiteSpace(txtPrecioVenta.Text))
                {
                    MessageBox.Show("Por favor complete los campos obligatorios (Nombre y Precios).", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtener el ID del proveedor seleccionado si el usuario eligió uno
                int? idProveedorSeleccionado = null;
                if (cmbProveedor.SelectedValue != null)
                {
                    idProveedorSeleccionado = Convert.ToInt32(cmbProveedor.SelectedValue);
                }

                using (var service = ServiceFactory.CrearInventarioService())
                {
                    if (_idParaEditar == null)
                    {
                        // ---- REGISTRAR NUEVO ----
                        var nuevo = new Producto
                        {
                            Nombre = txtNombre.Text,
                            Descripcion = txtDescripcion.Text,
                            PrecioCompra = decimal.Parse(txtPrecioCompra.Text),
                            PrecioVenta = decimal.Parse(txtPrecioVenta.Text),
                            Stock = int.Parse(txtStockActual.Text),
                            StockMinimo = int.Parse(txtStockMinimo.Text),
                            ProveedorId = idProveedorSeleccionado
                        };

                        service.RegistrarProducto(nuevo);
                        MessageBox.Show("Producto guardado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // ---- ACTUALIZAR PRODUCTO EXISTENTE ----
                        var editado = new Producto
                        {
                            Id = _idParaEditar.Value,
                            Nombre = txtNombre.Text,
                            Descripcion = txtDescripcion.Text,
                            PrecioCompra = decimal.Parse(txtPrecioCompra.Text),
                            PrecioVenta = decimal.Parse(txtPrecioVenta.Text),
                            Stock = int.Parse(txtStockActual.Text),
                            StockMinimo = int.Parse(txtStockMinimo.Text),
                            ProveedorId = idProveedorSeleccionado
                        };

                        // Corregido pasándole los dos parámetros exigidos por la firma (id, datos)
                        service.ActualizarProducto(_idParaEditar.Value, editado);
                        MessageBox.Show("Producto actualizado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    this.Close();
                }
            }
            catch (Exception ex) { MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
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

        private void btnActivarProducto_Click(object sender, EventArgs e)
        {
            if (_idParaEditar == null) return;

            var confirm = MessageBox.Show("¿Desea volver a activar este producto en el inventario?", "Confirmar Activación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    using (var service = ServiceFactory.CrearInventarioService())
                    {
                        service.ActivarProducto(_idParaEditar.Value);
                        MessageBox.Show("El producto ha sido activado exitosamente.", "Activado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al activar producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Métodos de eventos requeridos por el Designer para no corromper la vista de diseño
        private void txtPrecioCompra_TextChanged(object sender, EventArgs e) { }
        private void txtDescripcion_TextChanged(object sender, EventArgs e) { }
        private void txtNombre_TextChanged(object sender, EventArgs e) { }
        private void cmbProveedor_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}