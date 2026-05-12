using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Sistema.BLL.Services;
using Sistema.Entities.Ventas;
using Sistema.BLL.Factories;

namespace Sistema.UI
{
    public partial class FormVerVentas : Form
    {


        public FormVerVentas()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;

            clm_cliente.DataPropertyName = "clm_cliente";
            clm_Tipopago.DataPropertyName = "clm_Tipopago";
            clm_Fecha.DataPropertyName = "clm_Fecha";
            clm_Total.DataPropertyName = "clm_Total";
            clm_Estado.DataPropertyName = "clm_Estado";

            clm_id.DataPropertyName = "clm_id";



            Ver_todas_ventas(this, EventArgs.Empty);
        }

        private void textchanged_buscador(object sender, EventArgs e)
        {
            var term = textBox1.Text?.Trim() ?? string.Empty;
            if (string.IsNullOrWhiteSpace(term))
            {
                Ver_todas_ventas(this, EventArgs.Empty);
                return;
            }
            using (var service = ServiceFactory.CrearVentaService())
            {

                var ventas = service.ListarVentas().Where(p => p.Cliente.Nombre.IndexOf(term, StringComparison.OrdinalIgnoreCase) >= 0)
                    .ToList();
                FormVerVentas_Load(ventas);
            }

        }

        private void BtnVolver_Click(object? sender, EventArgs e)
        {
            // Buscar Form1 entre las ventanas abiertas y usar su método AbrirFormEnPanel
            var host = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            if (host != null)
            {
                host.AbrirFormEnPanel(new Form2());
                return;
            }

            // fallback: si no se encuentra Form1, abrimos Form2 como ventana normal (no nueva pestaña)
            var f2 = new Form2();
            f2.Show();
        }

        // Handler for designer Resize event
        private void FormVerVentas_Resize(object? sender, EventArgs e)
        {
            // Asegurarse que el control exista antes de ajustar la posición

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "clm_Detalle")
            {
                int idVenta = (int)dataGridView1.Rows[e.RowIndex].Cells["clm_id"].Value;

                FormVerDetalleVenta ventana = new FormVerDetalleVenta(idVenta);
                ventana.StartPosition = FormStartPosition.CenterScreen;
                ventana.ShowDialog();
            }

            if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "clm_anular")
            {
                int idVenta = (int)dataGridView1.CurrentRow.Cells["clm_id"].Value;
                var confirmResult = MessageBox.Show("¿Estás seguro de que deseas anular esta venta?", "Confirmar Anulación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        using (var _ventaService = ServiceFactory.CrearVentaService())
                        {
                            _ventaService.AnularVenta(idVenta);
                            MessageBox.Show("Venta anulada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Ver_todas_ventas(this, EventArgs.Empty); // Recargar la lista de ventas
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al anular la venta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }


        }

        private void Ver_todas_ventas(object sender, EventArgs e)
        {
            using (var _ventaService = ServiceFactory.CrearVentaService())
            {
                var ventas = _ventaService.ListarVentas();
                FormVerVentas_Load(ventas);
            }
        }



        private void FormVerVentas_Load(List<Venta> ventas)
        {
            try
            {

                dataGridView1.AutoGenerateColumns = false;

                dataGridView1.DataSource = ventas.OrderByDescending(v => v.Fecha).Select(v => new
                {
                    clm_id = v.Id,
                    clm_Fecha = v.Fecha,
                    clm_Tipopago = v.TipoPago.ToString(),
                    clm_Total = v.Total,
                    clm_Estado = v.Estado.ToString(),
                    clm_cliente = v.Cliente != null ? v.Cliente.Nombre : "Sin cliente",
                    Usuario = v.Usuario != null ? v.Usuario.Username : "Sin usuario"

                }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las ventas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var _ventaService = ServiceFactory.CrearVentaService())
            {
                DateTime fechaInicio = dateTimePicker1.Value.Date;
                DateTime fechaFin = dateTimePicker2.Value.Date.AddDays(1).AddTicks(-1);

                var ventas = _ventaService.ListarVentas().Where(v => v.Fecha >= fechaInicio && v.Fecha <= fechaFin)
                    .ToList();
                FormVerVentas_Load(ventas);
            }

        }

        private void FormVerVentas_Load(object sender, EventArgs e)
        {

        }
    }
}