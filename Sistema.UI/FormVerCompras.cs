using Sistema.BLL.Services;
using Sistema.DAL.Repositories;
using Sistema.Entities.Compras;
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
    public partial class FormVerCompras : Form
    {
        private CompraService _compraService;
        public FormVerCompras()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;

            clm_proveedor.DataPropertyName = "clm_proveedor";
            
            clm_fecha.DataPropertyName = "clm_fecha";
            clm_total.DataPropertyName = "clm_total";
            clm_Estado.DataPropertyName = "clm_Estado";

            clm_id.DataPropertyName = "clm_id";
            var compraRepository = new CompraRepository(Program.Context);
            var productoRepository = new ProductoRepository(Program.Context);
            var proveedorRepository = new ProveedorRepository(Program.Context);
       
            _compraService = new CompraService(Program.Context, compraRepository, productoRepository, proveedorRepository);
            Ver_todas_compras(this, EventArgs.Empty);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var host = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            if (host != null)
            {
                host.AbrirFormEnPanel(new FormCompras());
                return;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var compra = dataGridView1.Rows[e.RowIndex].Tag as Compra;
                if (compra != null)
                {
                    FormVerDetalleCompra ventana = new FormVerDetalleCompra(compra.Id);
                    ventana.StartPosition = FormStartPosition.CenterScreen;
                    ventana.ShowDialog();
                }
            }
        }

        private void Ver_todas_compras(object sender, EventArgs e)
        {
            var compra = _compraService.ListarCompras();
            FormVerCompras_Load(compra);
        }

        private void FormVerCompras_Load(List<Compra> compras)
        {
            try
            {
                dataGridView1!.Rows.Clear();
                foreach (var c in compras)
                {
                    int rowIndex = dataGridView1.Rows.Add(
                        c.Id,
                        c.Proveedor?.Nombre ?? "Desconocido",
                        c.Estado.ToString(),
                        c.Fecha.ToString("dd/MM/yyyy"),
                        c.Total.ToString("C")
                    );
                    dataGridView1.Rows[rowIndex].Tag = c;
                }
                if (compras.Count > 0 && dataGridView1.Rows.Count > 0)
                {
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[0].Selected = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las ventas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
    }
}
