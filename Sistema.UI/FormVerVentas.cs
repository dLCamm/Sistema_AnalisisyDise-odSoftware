using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Sistema.UI
{
    public partial class FormVerVentas : Form
    {


        public FormVerVentas()
        {
            InitializeComponent();
        }

        private void BtnVolver_Click(object? sender, EventArgs e)
        {
            // Buscar Form1 entre las ventanas abiertas y usar su método AbrirFormEnPanel
            var host = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            if (host != null)
            {
                host.AbrirFormEnPanel(new Form2());
                return;
            }

            // fallback: si no se encuentra Form1, abrimos Form2 como ventana normal (no nueva pestaña)
            var f2 = new Form2();
            f2.Show();
        }

        // Handler for designer Resize event
        private void FormVerVentas_Resize(object? sender, EventArgs e)
        {
            // Asegurarse que el control exista antes de ajustar la posición

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            FormVerDetalleVenta ventanaModaldetalle = new FormVerDetalleVenta();


            
            ventanaModaldetalle.StartPosition = FormStartPosition.CenterScreen;
            ventanaModaldetalle.ShowDialog(); ventanaModaldetalle.ResumeLayout();
            

        }
    }
}