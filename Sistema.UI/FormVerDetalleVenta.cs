using Sistema.BLL.Services;
using Sistema.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sistema.Entities.Ventas;

namespace Sistema.UI
{
    public partial class FormVerDetalleVenta : Form

    {
        private int idventa;
        private VentaService _ventaservice;
        public FormVerDetalleVenta(int idVenta)
        {

            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            clm_Producto.DataPropertyName = "clm_Producto";
            clm_Cantidad.DataPropertyName = "clm_Cantidad";
            clm_PrecioUnitario.DataPropertyName = "clm_PrecioUnitario";
            clm_Subtotal.DataPropertyName = "clm_Subtotal";
            
            idventa = idVenta;
            var ventaRepository = new VentaRepository(Program.Context);
            var productoRepository = new ProductoRepository(Program.Context);
            _ventaservice = new VentaService(Program.Context, ventaRepository, productoRepository);
            LlenarTabla();
        }

        private void LlenarTabla()
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
