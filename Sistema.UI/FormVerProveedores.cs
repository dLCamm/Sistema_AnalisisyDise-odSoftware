using Sistema.BLL.Factories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistema.UI
{
    public partial class FormVerProveedores : Form
    {
        public FormVerProveedores()
        {
            InitializeComponent();
            
        }

        private void FormVerProveedores_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1!.Rows.Clear();
                using (var service = ServiceFactory.CrearProveedorService())
                {
                    var proveedores = service.ListarProveedores();
                    foreach (var proveedor in proveedores)
                    {
                        int rowIndex = dataGridView1.Rows.Add();
                        var row = dataGridView1.Rows[rowIndex];
                        row.Cells["clm_id"].Value = proveedor.Id;
                        row.Cells["clm_dpi"].Value = proveedor.DPI;
                        row.Cells["clm_nombre"].Value = proveedor.Nombre;
                        row.Cells["clm_telefono"].Value = proveedor.Telefono;
                        row.Cells["clm_direccion"].Value = proveedor.Direccion;
                        row.Cells["clm_correo"].Value = proveedor.Email;
                        row.Cells["clm_estado"].Value = proveedor.Estado.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar proveedores: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAgregarProveedor agregarProveedorForm = new FormAgregarProveedor();
            agregarProveedorForm.ShowDialog();
            FormVerProveedores_Load(sender, e);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                int proveedorId = Convert.ToInt32(row.Cells["clm_id"].Value);
                // Abrir el formulario de edición con el ID del proveedor
                FormAgregarProveedor editarProveedorForm = new FormAgregarProveedor(proveedorId);
                editarProveedorForm.ShowDialog();
                FormVerProveedores_Load(sender, e);
            }

        }
    }
}
