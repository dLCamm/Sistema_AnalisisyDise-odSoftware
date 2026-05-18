using Sistema.BLL.Factories;
using Sistema.Entities.Compras;
using Sistema.Entities.Productos;
using Sistema.Entities.Ventas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sistema.UI
{
    public partial class FormVerCompras : Form, IReporteForm
    {
        List<Compra> comprass;
        List<Compra> comprasfiltradas;

        public FormVerCompras()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;

            // Ajustamos las columnas (clm_proveedor ya no se mapea aquí)
            clm_fecha.DataPropertyName = "clm_fecha";
            clm_total.DataPropertyName = "clm_total";
            clm_Estado.DataPropertyName = "clm_Estado";
            clm_id.DataPropertyName = "clm_id";

            this.dateTimePicker2.ValueChanged += (s, e) => AplicarFiltrosGlobales();

            Ver_todas_compras(this, EventArgs.Empty);
            recargar_combos(this, EventArgs.Empty);
        }

        private void AplicarFiltrosGlobales()
        {
            string estado = comboBox2.SelectedItem?.ToString() ?? string.Empty;

            DateTime fechaDesde = dateTimePicker1.Checked ? dateTimePicker1.Value.Date : DateTime.MinValue;
            DateTime fechaHasta = dateTimePicker1.Checked ? dateTimePicker2.Value.Date.AddDays(1).AddTicks(-1) : DateTime.MaxValue;

            var resultado = comprass.AsEnumerable();

            // 1. CORRECCIÓN: Se eliminó por completo el filtro por nombre de proveedor (term)

            // 2. CORRECCIÓN MERGE: Filtro de rango de fechas limpio
            if (fechaDesde != DateTime.MinValue)
            {
                resultado = resultado.Where(c => c.Fecha >= fechaDesde && c.Fecha <= fechaHasta);
            }

            // Filtro por Estado
            if (!string.IsNullOrEmpty(estado))
            {
                resultado = resultado.Where(v => v.Estado.ToString() == estado);
            }

            comprasfiltradas = resultado.ToList();
            FormVerCompras_Load();
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

        private void recargar_combos(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            using (var service = ServiceFactory.CrearCompraService())
            {
                var compras = service.ListarCompras();
                var estados = compras.Select(v => v.Estado.ToString()).Distinct().ToList();
                comboBox2.Items.AddRange(estados.ToArray());
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var compra = dataGridView1.Rows[e.RowIndex].Tag as Compra;
                if (compra != null)
                {
                    FormVerDetalleCompra ventana = new FormVerDetalleCompra(compra.Id);
                    ventana.StartPosition = FormStartPosition.CenterScreen;
                    ventana.ShowDialog();
                    Ver_todas_compras(this, EventArgs.Empty);
                }
            }
        }

        private void Ver_todas_compras(object sender, EventArgs e)
        {
            using var _compraService = ServiceFactory.CrearCompraService();
            var compra = _compraService.ListarCompras();
            comprass = compra;
            comprasfiltradas = compra;
            FormVerCompras_Load();
        }

        private void FormVerCompras_Load()
        {
            try
            {
                dataGridView1!.Rows.Clear();
                foreach (var c in comprasfiltradas)
                {
                    // Cargamos los datos directos de la Compra sin buscar Proveedores
                    int rowIndex = dataGridView1.Rows.Add(
                        c.Id,
                        c.Fecha.ToString("dd/MM/yyyy"),
                        c.Total.ToString("C"),
                        c.Estado.ToString()
                    );
                    dataGridView1.Rows[rowIndex].Tag = c;
                }
                if (comprasfiltradas.Count > 0 && dataGridView1.Rows.Count > 0)
                {
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[0].Selected = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las compras: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltrosGlobales();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AplicarFiltrosGlobales();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox2.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker1.Checked = false;
            dateTimePicker2.Value = DateTime.Now;
            AplicarFiltrosGlobales();
        }

        // 3. CORRECCIÓN EXPORTAR: Removida la columna Proveedor del objeto anónimo
        public object ObtenerDatosFiltrados()
        {
            return comprasfiltradas.Select(c => new
            {
                ID = c.Id,
                Fecha = c.Fecha.ToString("dd/MM/yyyy"),
                Total = string.Format("Q{0:N2}", c.Total),
                Estado = c.Estado.ToString()
            }).ToList();
        }

        public string ObtenerTituloReporte() => "Reporte de Compras Filtradas";

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
        }
    }
}