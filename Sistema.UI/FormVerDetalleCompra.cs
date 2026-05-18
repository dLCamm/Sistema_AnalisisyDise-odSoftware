
using Sistema.BLL.Factories;
using Sistema.Entities.Compras;
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
    public partial class FormVerDetalleCompra : Form
    {

        private int idcompra;
        public FormVerDetalleCompra(int idcompra)
        {
            InitializeComponent();
            this.idcompra = idcompra;

            clm_producto.DataPropertyName = "clm_producto";
            clm_cantidad.DataPropertyName = "clm_cantidad";
            clm_preciocompra.DataPropertyName = "clm_preciocompra";
            clm_subtotal.DataPropertyName = "clm_subtotal";
            LlenarTabla();
        }

        private void LlenarTabla()
        {
            try
            {
                using (var _compraService = ServiceFactory.CrearCompraService())
                {
                    var detallecompra = _compraService.ObtenerCompra(idcompra);

                    label5.Text = detallecompra.Fecha.ToString("dd/MM/yyyy HH:mm");
                    label7.Text = detallecompra.Estado.ToString();
                    label8.Text = detallecompra.Total.ToString("C");
                    ICollection<DetalleCompra> detalles = detallecompra.Detalles;
                    dataGridView1.DataSource = detalles.Select(v => new
                    {
                        clm_producto = v.Producto.Nombre,
                        clm_cantidad = v.Cantidad,
                        clm_preciocompra = v.PrecioCompra,
                        clm_subtotal = v.Subtotal
                    }).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los detalles de la compra: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("¿Estás seguro de que deseas anular esta compra?", "Confirmar Anulación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    using (var _compraService = ServiceFactory.CrearCompraService())
                    {
                        _compraService.AnularCompra(idcompra);
                        MessageBox.Show("Compra anulada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al anular la venta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
