using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistema.UI
{
    public partial class frmMantenomientoCredito : Form
    {
        // Propiedades para que el formulario de Ventas las pueda leer al cerrar 
        public DateTime FechaVencimiento { get; private set; }
        public decimal AbonoInicial { get; private set; }

        public frmMantenomientoCredito()
        {
            InitializeComponent();

            // Configuración del calendario para que no permita fechas pasadas
            dtpFechaVencimiento.Format = DateTimePickerFormat.Short;
            dtpFechaVencimiento.MinDate = DateTime.Now;
        }

        private void btnGuardarCredito_Click(object sender, EventArgs e)
        {
            // 1. Asignar la fecha directamente desde el DateTimePicker
            this.FechaVencimiento = dtpFechaVencimiento.Value;

            // 2. Validar el abono inicial
            if (decimal.TryParse(txtAbonoInicial.Text, out decimal abono))
            {
                this.AbonoInicial = abono;
            }
            else
            {
                this.AbonoInicial = 0; // Si no ponen nada el abono es 0
            }

            // 3. Cerrar con éxito
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelarCr_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void frmMantenomientoCredito_Load(object sender, EventArgs e) { }
    }
}