using Microsoft.Extensions.DependencyInjection;
using Sistema.BLL.Factories;
using Sistema.Entities.Productos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistema.UI
{
    public partial class frmMantenimientoProducto : Form
    {
        public frmMantenimientoProducto()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMantenimientoProducto_Load(object sender, EventArgs e)
        {

        }

        public void CargarDatosParaEditar(string nombre, string descripcion, int stock)
        {
            txtNombre.Text = nombre;
            txtDescripcion.Text = descripcion;
            txtStockActual.Text = stock.ToString();
            
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var service = ServiceFactory.CrearInventarioService())
                {
                    var producto = new Producto
                    {
                        Nombre = txtNombre.Text,
                        Descripcion = txtDescripcion.Text,
                        PrecioCompra = decimal.Parse(txtPrecioCompra.Text),
                        PrecioVenta = decimal.Parse(txtPrecioVenta.Text),
                        Stock = int.Parse(txtStockActual.Text),
                        StockMinimo = int.Parse(txtStockMinimo.Text)
                    };

                    service.RegistrarProducto(producto);
                }

                MessageBox.Show("Producto registrado correctamente");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
