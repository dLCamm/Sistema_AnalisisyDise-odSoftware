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
        // Propiedades desde Form2
        public DateTime FechaVencimiento { get; private set; }
        public decimal AbonoInicial { get; private set; }

        public frmMantenomientoCredito()
        {
            InitializeComponent();
        }

        private void btnGuardarCredito_Click(object sender, EventArgs e)
        {
            // 1. Validar la fecha ingresada
            if (!DateTime.TryParse(txtAbonoInicial.Text, out DateTime fecha))
            {
                MessageBox.Show("Ingrese una fecha válida (ej: 30/06/2026)");
                return;
            }

            // 2. Validar el abono
            decimal.TryParse(txtAbonoInicial.Text, out decimal abono);

            // 3. Asignar valores y cerrar con éxito
            this.FechaVencimiento = fecha;
            this.AbonoInicial = abono;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelarCr_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMantenomientoCredito_Load(object sender, EventArgs e)
        {
            
        }

        private void txtFechaVencimiento_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAbonoInicial_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
