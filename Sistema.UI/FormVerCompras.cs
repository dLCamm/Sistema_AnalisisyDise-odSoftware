using Sistema.Entities.Ventas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistema.UI
{
    public partial class FormVerCompras : Form
    {
        public FormVerCompras()
        {
            InitializeComponent();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FormVerDetalleCompra ventana = new FormVerDetalleCompra();
            ventana.StartPosition = FormStartPosition.CenterScreen;
            ventana.ShowDialog();
        }
    }
}
