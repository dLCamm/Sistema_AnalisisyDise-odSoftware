using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sistema.BLL.Factories;


namespace Sistema.UI
{
    public partial class FormVerClientes : Form
    {
        public FormVerClientes()
        {
            InitializeComponent();
        }

        private void FormVerClientes_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1!.Rows.Clear();
                using (var service = ServiceFactory.CrearClienteService())
                {
                    var clientes = service.ListarClientes();
                    foreach (var cliente in clientes)
                    {
                        int rowIndex = dataGridView1.Rows.Add();
                        var row = dataGridView1.Rows[rowIndex];
                        row.Cells["clm_id"].Value = cliente.Id;
                        row.Cells["clm_dpi"].Value = cliente.DPI;
                        row.Cells["clm_nombre"].Value = cliente.Nombre;
                        row.Cells["clm_telefono"].Value = cliente.Telefono;
                        row.Cells["clm_direccion"].Value = cliente.Direccion;
                        row.Cells["clm_fecha"].Value = cliente.FechaRegistro.ToString("dd/MM/yyyy");
                        row.Cells["clm_correo"].Value = cliente.Email;
                        row.Cells["clm_estado"].Value = cliente.Estado.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar clientes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                int clienteId = Convert.ToInt32(row.Cells["clm_id"].Value);
                // Abrir el formulario de edición con el ID del cliente
                frmIngresarCliente editarClienteForm = new frmIngresarCliente(clienteId);
                editarClienteForm.ShowDialog();
                FormVerClientes_Load(sender, e);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmIngresarCliente nuevoCliente = new frmIngresarCliente();
            nuevoCliente.ShowDialog();
            FormVerClientes_Load(sender, e);
        }
    }
}
