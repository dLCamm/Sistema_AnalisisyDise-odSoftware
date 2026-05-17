using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

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
            cmbTipoReporte.Items.Add("Créditos");

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

                case "Créditos":
                    formularioAbrir = new frmCréditos();
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

        // --- Eventos Adicionales ---

        private void btnExportarPdf_Click(object sender, EventArgs e)
        {
            // Lógica para exportar a PDF
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            // Lógica para exportar a Excel
        }

        private void dgvResultados_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Lógica del DataGridView
        }
    }
}