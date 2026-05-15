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
        List<Venta> ventass;
        List<Venta> ventasFiltradas;

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
            recargar_combos(this, EventArgs.Empty);
        }

        private void textchanged_buscador(object sender, EventArgs e)
        {
            AplicarFiltrosGlobales();
            

        }

        private void AplicarFiltrosGlobales()
        {
            var term = textBox1.Text?.Trim() ?? string.Empty;
            string tipopago = comboBox1.SelectedItem?.ToString() ?? string.Empty;
            string estado = comboBox2.SelectedItem?.ToString() ?? string.Empty;
            DateTime fecha = dateTimePicker1.Checked ? dateTimePicker1.Value.Date : DateTime.MinValue;

            // SIEMPRE empezamos desde la lista completa original
            var resultado = ventass.AsEnumerable();

            // Filtro por Buscador (Nombre Cliente)
            if (!string.IsNullOrWhiteSpace(term))
            {
                resultado = resultado.Where(p => p.Cliente.Nombre.IndexOf(term, StringComparison.OrdinalIgnoreCase) >= 0);
            }

            // Filtro por Fecha
            if (fecha != DateTime.MinValue)
            {
                resultado = resultado.Where(v => v.Fecha.Date == fecha);
            }

            // Filtro por Tipo de Pago
            if (!string.IsNullOrEmpty(tipopago))
            {
                resultado = resultado.Where(v => v.TipoPago.ToString() == tipopago);
            }

            // Filtro por Estado
            if (!string.IsNullOrEmpty(estado))
            {
                resultado = resultado.Where(v => v.Estado.ToString() == estado);
            }

            // Actualizamos la lista que se muestra
            ventasFiltradas = resultado.ToList();

            // Aquí actualizas tu UI (por ejemplo, asignando ventasFiltradas al DataGridView)
            FormVerVentas_Load();
        }

        private void recargar_combos(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            using (var service = ServiceFactory.CrearVentaService())
            {
                var ventas = service.ListarVentas();
                var tiposPago = ventas.Select(v => v.TipoPago.ToString()).Distinct().ToList();
                var estados = ventas.Select(v => v.Estado.ToString()).Distinct().ToList();
                comboBox1.Items.AddRange(tiposPago.ToArray());
                comboBox2.Items.AddRange(estados.ToArray());
            }
        }

        private void BtnVolver_Click(object? sender, EventArgs e)
        {
           
            var host = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            if (host != null)
            {
                host.AbrirFormEnPanel(new Form2());
                return;
            }

            
            var f2 = new Form2();
            f2.Show();
        }

    
        private void FormVerVentas_Resize(object? sender, EventArgs e)
        {
          

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int idVenta = (int)dataGridView1.Rows[e.RowIndex].Cells["clm_id"].Value;
            FormVerDetalleVenta ventana = new FormVerDetalleVenta(idVenta);
            ventana.StartPosition = FormStartPosition.CenterScreen;
            ventana.ShowDialog();
            Ver_todas_ventas(this, EventArgs.Empty);

        }

        private void Ver_todas_ventas(object sender, EventArgs e)
        {
            using (var _ventaService = ServiceFactory.CrearVentaService())
            {
                var ventas = _ventaService.ListarVentas();
                ventasFiltradas = ventas;
                ventass = ventas;
                FormVerVentas_Load();
            }
        }



        private void FormVerVentas_Load()
        {
            try
            {

                dataGridView1.AutoGenerateColumns = false;

                dataGridView1.DataSource = ventasFiltradas.OrderByDescending(v => v.Fecha).Select(v => new
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
            try
            {
                AplicarFiltrosGlobales();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al filtrar las ventas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker1.Checked = false;
            AplicarFiltrosGlobales();

        }

        private void FormVerVentas_Load(object sender, EventArgs e)
        {

        }
    }
}