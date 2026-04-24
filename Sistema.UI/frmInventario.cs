using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistema.UI
{
    public partial class frmInventario : Form
    {
        public frmInventario()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            
            frmMantenimientoProducto ventanaModal = new frmMantenimientoProducto();

            ventanaModal.ShowDialog();
        }

        private void frmInventario_Load(object sender, EventArgs e)
        {
        
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvProductos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvProductos.Columns[e.ColumnIndex].Name == "colStatus" && e.Value != null)
            {
                string estado = e.Value.ToString();

                if (estado == "Activo")
                {
                    e.CellStyle.ForeColor = Color.FromArgb(70, 120, 255); // Azul
                }
                else if (estado == "Stock Bajo")
                {
                    e.CellStyle.ForeColor = Color.FromArgb(255, 180, 0); // Naranja
                }
                else if (estado == "Sin Existencias")
                {
                    e.CellStyle.ForeColor = Color.FromArgb(180, 180, 180); // Gris
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
