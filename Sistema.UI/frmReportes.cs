using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Sistema.BLL.Services;
using Sistema.BLL.Factories;
using Sistema.Entities.DTOs.Ventas;
using Sistema.Entities.DTOs.Caja;
using Sistema.Entities.DTOs.Creditos;
using Sistema.Entities.DTOs.Compras;

namespace Sistema.UI
{
    public partial class frmReportes : Form
    {
        private readonly ReporteService _reporteService;
        private readonly ExportService _exportService;

        public frmReportes()
        {
            InitializeComponent();
            _reporteService = ServiceFactory.CrearReporteService();
            _exportService = new ExportService();

            // ACTIVADO: Permite que el Grid cree las columnas solo
            dgvResultados.AutoGenerateColumns = true;

            ConfigurarFiltrosInciales();
        }

        private void ConfigurarFiltrosInciales()
        {
            cmbTipoReporte.Items.Clear();
            cmbTipoReporte.Items.AddRange(new string[] { "Ventas", "Caja", "Créditos", "Compras" });
            cmbTipoReporte.SelectedIndex = 0;

            dtpInicio.Value = DateTime.Now.AddDays(-30);
            dtpFin.Value = DateTime.Now;

            if (cmbEstadoFiltro != null) cmbEstadoFiltro.Visible = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime inicio = dtpInicio.Value.Date;
                DateTime fin = dtpFin.Value.Date;
                string seleccion = cmbTipoReporte.Text;

                dgvResultados.DataSource = null;

                if (seleccion == "Ventas")
                {
                    var ventas = _reporteService.ObtenerVentasPorDia(inicio, fin);
                    dgvResultados.DataSource = ventas;
                    lblTotal.Text = "Total: Q " + ventas.Sum(v => v.TotalVentas).ToString("N2");
                }
                else if (seleccion == "Caja")
                {
                    var caja = _reporteService.ObtenerCajaPorDia(inicio, fin);
                    dgvResultados.DataSource = caja;
                    lblTotal.Text = "Balance: Q " + caja.Sum(c => c.Ingresos - c.Egresos).ToString("N2");
                }
                else if (seleccion == "Créditos")
                {
                    var creditos = _reporteService.ObtenerClientesConDeuda();
                    dgvResultados.DataSource = creditos;
                    lblTotal.Text = "Deuda Total: Q " + creditos.Sum(c => c.TotalCredito).ToString("N2");
                }
                else if (seleccion == "Compras")
                {
                    var compras = _reporteService.ObtenerComprasPorFecha(inicio, fin);
                    dgvResultados.DataSource = compras;
                    lblTotal.Text = "Total Compras: Q " + compras.Sum(c => c.Total).ToString("N2");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }
        }

        private void btnExportarPdf_Click_1(object sender, EventArgs e)
        {
            // 1. Validamos que haya algo en el Grid
            if (dgvResultados.DataSource == null)
            {
                MessageBox.Show("No hay datos para exportar.");
                return;
            }

            try
            {
                string seleccion = cmbTipoReporte.Text;
                string nombreArchivo = $"Reporte_{seleccion}_{DateTime.Now:yyyyMMdd}.pdf";

                // 2. Usamos 'dynamic' para que el servicio acepte cualquier lista (Ventas, Compras, etc.)
                dynamic datos = dgvResultados.DataSource;

                // 3. Exportamos
                _exportService.ExportarPdf(datos, $"Reporte de {seleccion}", nombreArchivo);

                MessageBox.Show($"✅ PDF de {seleccion} generado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar PDF: " + ex.Message);
            }
        }

        private void btnExportarExcel_Click_1(object sender, EventArgs e)
        {
            // 1. Validamos que haya algo en el Grid
            if (dgvResultados.DataSource == null)
            {
                MessageBox.Show("No hay datos para exportar.");
                return;
            }

            try
            {
                string seleccion = cmbTipoReporte.Text;
                string ruta = AppDomain.CurrentDomain.BaseDirectory + $"Reporte_{seleccion}_{DateTime.Now:yyyyMMdd}.csv";

                // 2. Tomamos los datos directamente del DataSource del Grid
                dynamic datos = dgvResultados.DataSource;

                // 3. Exportamos al CSV
                _exportService.ExportarCsv(datos, ruta);

                MessageBox.Show($"✅ CSV de {seleccion} generado exitosamente en:\n{ruta}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar Excel/CSV: " + ex.Message);
            }
        }

        private void cmbTipoReporte_SelectedIndexChanged(object sender, EventArgs e) { }
        private void dtpInicio_ValueChanged(object sender, EventArgs e) { }
        private void dtpFin_ValueChanged(object sender, EventArgs e) { }
        private void btnExportarPdf_Click(object sender, EventArgs e) { }
        private void btnExportarExcel_Click(object sender, EventArgs e) { }
        private void dgvResultados_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}