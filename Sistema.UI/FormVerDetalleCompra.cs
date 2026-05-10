using Sistema.BLL.Services;
using Sistema.Entities.Ventas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sistema.DAL.Repositories;
using Sistema.Entities.Compras;

namespace Sistema.UI
{
    public partial class FormVerDetalleCompra : Form
    {
        private CompraService _compraService;
        private int idcompra;
        public FormVerDetalleCompra(int idcompra)
        {
            InitializeComponent();
            this.idcompra = idcompra;
            var compraRepository = new CompraRepository(Program.Context);
            var productoRepository = new ProductoRepository(Program.Context);
            var proveedorRepository = new ProveedorRepository(Program.Context);
            _compraService = new CompraService(Program.Context, compraRepository, productoRepository, proveedorRepository);
            clm_producto.DataPropertyName = "clm_producto";
            clm_cantidad.DataPropertyName = "clm_cantidad";
            clm_preciocompra.DataPropertyName = "clm_preciocompra";
            clm_subtotal.DataPropertyName = "clm_subtotal";
            LlenarTabla();  
        }

        private void LlenarTabla()
        {
            var detallecompra = _compraService.ObtenerCompra(idcompra);

            label5.Text = detallecompra.Fecha.ToString("dd/MM/yyyy HH:mm");
            label6.Text = detallecompra.Proveedor.Nombre;
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
}
