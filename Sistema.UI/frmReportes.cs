using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Sistema.BLL.Services;

namespace Sistema.UI
{
    public partial class frmReportes : Form
    {
        public frmReportes()
        {
            InitializeComponent();
            ConfigurarComponentes();
        }

        private void ConfigurarComponentes()
        {
            cmbTipoReporte.Items.Clear();
            cmbTipoReporte.Items.Add("Ventas");
            cmbTipoReporte.Items.Add("Compras");
  

            cmbTipoReporte.DropDownStyle = ComboBoxStyle.DropDownList;

            if (cmbTipoReporte.Items.Count > 0)
            {
                cmbTipoReporte.SelectedIndex = 0;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // 1. Validar selección
            if (cmbTipoReporte.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un tipo de reporte.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string opcionSeleccionada = cmbTipoReporte.SelectedItem.ToString();
            Form formularioAbrir = null;

            // 2. Instanciar el formulario según la selección
            switch (opcionSeleccionada)
            {
                case "Ventas":
                    formularioAbrir = new FormVerVentas();
                    break;

                case "Compras":
                    formularioAbrir = new FormVerCompras();
                    break;


                default:
                    MessageBox.Show("Tipo de reporte no reconocido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            // 3. Cargar el formulario incrustado dentro del panel pnlReportes
            if (formularioAbrir != null)
            {
                AbrirFormularioEnPanel(formularioAbrir);
            }
        }

        /// <summary>
        /// Método encargado de limpiar el panel e incrustar el nuevo formulario.
        /// </summary>
        private void AbrirFormularioEnPanel(Form formularioHijo)
        {
            // Si ya hay un formulario o controles cargados en el panel, los limpia
            if (pnlReportes.Controls.Count > 0)
            {
                pnlReportes.Controls.Clear();
            }

            // Configuraciones críticas para que el formulario se comporte como un control dentro del panel
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;

            // Se agrega al panel y se muestra
            pnlReportes.Controls.Add(formularioHijo);
            pnlReportes.Tag = formularioHijo;
            formularioHijo.Show();
        }

     
        

        private void dgvResultados_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Lógica del DataGridView
        }

        private void btnExportarPdf_Click_1(object sender, EventArgs e)
        {
            // 1. Verificar si hay un formulario cargado en el panel
            if (pnlReportes.Controls.Count == 0 || pnlReportes.Tag == null)
            {
                MessageBox.Show("No hay ningún reporte activo para exportar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (pnlReportes.Tag is IReporteForm formularioActivo)
            {
                dynamic datosFiltrados = formularioActivo.ObtenerDatosFiltrados();

                if (datosFiltrados == null || datosFiltrados.Count == 0)
                {
                    MessageBox.Show("No hay datos en la lista actual para ser exportados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                //Configurar el cuadro de diálogo para guardar el archivo
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "Archivos PDF (*.pdf)|*.pdf";
                    sfd.FileName = $"{formularioActivo.ObtenerTituloReporte()}_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            // Instanciar el servicio de exportación y ejecutamos pasándole la ruta elegida
                            ExportService exportador = new ExportService();
                            exportador.ExportarPdf(datosFiltrados, formularioActivo.ObtenerTituloReporte(), sfd.FileName);

                            MessageBox.Show("Reporte en PDF generado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error al generar el PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }

        }

        private void btnExportarExcel_Click_1(object sender, EventArgs e)
        {
            if (pnlReportes.Controls.Count == 0 || pnlReportes.Tag == null)
            {
                MessageBox.Show("No hay ningún reporte activo para exportar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (pnlReportes.Tag is IReporteForm formularioActivo)
            {
                dynamic datosFiltrados = formularioActivo.ObtenerDatosFiltrados();

                if (datosFiltrados == null || datosFiltrados.Count == 0)
                {
                    MessageBox.Show("No hay datos en la lista actual para ser exportados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "Archivos CSV (*.csv)|*.csv";
                    sfd.FileName = $"{formularioActivo.ObtenerTituloReporte()}_{DateTime.Now:yyyyMMdd_HHmmss}.csv";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            ExportService exportador = new ExportService();

                            // Exportamos a CSV usando la lista dinámica filtrada
                            exportador.ExportarCsv(datosFiltrados, sfd.FileName);

                            MessageBox.Show("Reporte en CSV generado exitosamente (Compatible con Excel).", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error al generar el CSV: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }

        }
    }
}