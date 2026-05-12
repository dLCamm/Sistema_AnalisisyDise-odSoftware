using Sistema.BLL.Factories;
using Sistema.Entities.Ventas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Forms;

namespace Sistema.UI
{
    public partial class FormVerDetalleVenta : Form

    {
        private int idventa;

        public FormVerDetalleVenta(int idVenta)
        {

            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            clm_Producto.DataPropertyName = "clm_Producto";
            clm_Cantidad.DataPropertyName = "clm_Cantidad";
            clm_PrecioUnitario.DataPropertyName = "clm_PrecioUnitario";
            clm_Subtotal.DataPropertyName = "clm_Subtotal";

            idventa = idVenta;
            LlenarTabla();
        }

        private void LlenarTabla()

        {
            using (var _ventaservice = ServiceFactory.CrearVentaService())
            {
                var detalleventa = _ventaservice.ObtenerVenta(idventa);

                label5.Text = detalleventa.Fecha.ToString("dd/MM/yyyy HH:mm");
                label6.Text = detalleventa.Cliente.Nombre;
                label7.Text = detalleventa.Estado.ToString();
                label8.Text = detalleventa.Total.ToString("C");
                ICollection<DetalleVenta> detalles = detalleventa.Detalles;
                dataGridView1.DataSource = detalles.Select(v => new
                {
                    clm_Producto = v.Producto.Nombre,
                    clm_Cantidad = v.Cantidad,
                    clm_PrecioUnitario = v.PrecioUnitario,
                    clm_Subtotal = v.Subtotal
                }).ToList();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            var confirmResult = MessageBox.Show("¿Estás seguro de que deseas anular esta venta?", "Confirmar Anulación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    using (var _ventaService = ServiceFactory.CrearVentaService())
                    {
                        _ventaService.AnularVenta(idventa);
                        MessageBox.Show("Venta anulada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al anular la venta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}