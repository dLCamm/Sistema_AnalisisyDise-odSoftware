using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Sistema.BLL.Services;
using Sistema.Entities.Ventas;
using Sistema.BLL.Factories;

namespace Sistema.UI
{
    // 1. Implementamos IReporteForm para que el formulario de reportes pueda extraer los datos filtrados
    public partial class FormVerVentas : Form, IReporteForm
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

            // Enlazamos los eventos de cambio de fecha para que filtren automáticamente
            this.dateTimePicker1.ValueChanged += (s, e) => AplicarFiltrosGlobales();
            this.dateTimePicker2.ValueChanged += (s, e) => AplicarFiltrosGlobales();

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

            // CONTROL DE RANGO DE FECHAS (dateTimePicker1 = Desde, dateTimePicker2 = Hasta)
            // Si el primer picker está activado, tomamos el rango. Si no, ignoramos las fechas.
            DateTime fechaDesde = dateTimePicker1.Checked ? dateTimePicker1.Value.Date : DateTime.MinValue;
            // Para la fecha máxima tomamos las 23:59:59 de ese día para no ignorar ventas de la noche
            DateTime fechaHasta = dateTimePicker1.Checked ? dateTimePicker2.Value.Date.AddDays(1).AddTicks(-1) : DateTime.MaxValue;

            if (ventass == null) return;

            // SIEMPRE empezamos desde la lista completa original en memoria
            var resultado = ventass.AsEnumerable();

            // Filtro por Buscador (Nombre Cliente)
            if (!string.IsNullOrWhiteSpace(term))
            {
                resultado = resultado.Where(p => p.Cliente != null && p.Cliente.Nombre.IndexOf(term, StringComparison.OrdinalIgnoreCase) >= 0);
            }

            // Filtro por Rango de Fechas
            if (fechaDesde != DateTime.MinValue)
            {
                resultado = resultado.Where(v => v.Fecha >= fechaDesde && v.Fecha <= fechaHasta);
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

            // Refrescamos el DataGridView
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
            if (e.RowIndex < 0) return;

            int idVenta = (int)dataGridView1.Rows[e.RowIndex].Cells["clm_id"].Value;
            FormVerDetalleVenta ventana = new FormVerDetalleVenta(idVenta);
            ventana.StartPosition = FormStartPosition.CenterScreen;
            ventana.ShowDialog();

            // Al regresar del modal, volvemos a traer todo de la BD para capturar si cambió el crédito
            Ver_todas_ventas(this, EventArgs.Empty);
        }

        private void Ver_todas_ventas(object sender, EventArgs e)
        {
            using (var _ventaService = ServiceFactory.CrearVentaService())
            {
                var ventas = _ventaService.ListarVentas();
                ventass = ventas; // Sincroniza la lista base original de la base de datos
                ventasFiltradas = ventas;
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

        // BOTÓN BUSCAR/FILTRAR
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Para garantizar que los estados se actualicen en tiempo real, volvemos a consultar la base de datos
                using (var _ventaService = ServiceFactory.CrearVentaService())
                {
                    ventass = _ventaService.ListarVentas();
                }
                AplicarFiltrosGlobales();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al filtrar las ventas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // BOTÓN LIMPIAR FILTROS
        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;

            // Restablecemos los pickers de fecha
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker1.Checked = false;
            dateTimePicker2.Value = DateTime.Now;

            // Recargamos el listado fresco de la base de datos
            Ver_todas_ventas(this, EventArgs.Empty);
        }

        private void FormVerVentas_Load(object sender, EventArgs e)
        {
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            // El evento ya fue mapeado de manera centralizada en el constructor
        }

        // IMPLEMENTACIÓN DE LA INTERFAZ IREPORTEFORM PARA EXPORTAR SOLO LO FILTRADO
        public object ObtenerDatosFiltrados()
        {
            return ventasFiltradas.Select(v => new {
                ID = v.Id,
                Fecha = v.Fecha.ToString("dd/MM/yyyy"),
                Cliente = v.Cliente != null ? v.Cliente.Nombre : "Sin cliente",
                TipoPago = v.TipoPago.ToString(),
                Total = string.Format("Q{0:N2}", v.Total),
                Estado = v.Estado.ToString()
            }).ToList();
        }

        public string ObtenerTituloReporte() => "Reporte de Ventas y Créditos";
    }
}