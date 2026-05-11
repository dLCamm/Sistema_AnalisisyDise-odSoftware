using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistema.UI
{
    public partial class frmDetalleCredito : Form
    {
        // 1. Crea una variable para guardar el ID que recibes
        private int _creditoId;

        // 2. Modifica el constructor para que reciba el id
        public frmDetalleCredito(int id)
        {
            InitializeComponent();
            this._creditoId = id; // Guardamos el ID para usarlo después
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelarAb_Click(object sender, EventArgs e)
        {
            pnlNuevoAbono.Visible = false;
            txtCantidadAbono.Clear();
        }

        private void btnAgregarAbono_Click(object sender, EventArgs e)
        {
            pnlNuevoAbono.Visible = !pnlNuevoAbono.Visible;
        }

        private void btnCancelarCredito_Click(object sender, EventArgs e)
        {

        }

        private void btnAnularAbono_Click(object sender, EventArgs e)
        {

        }

        private void pnlNuevoAbono_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtCantidadAbono_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardarAbono_Click(object sender, EventArgs e)
        {

        }

        private void dgvDetalleAbonos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvTotales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmDetalleCredito_Load(object sender, EventArgs e)
        {

        }

        private void pnlDetallecredito_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
