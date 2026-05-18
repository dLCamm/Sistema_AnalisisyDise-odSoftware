using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sistema.Entities.Proveedores;
using Sistema.BLL.Factories;



namespace Sistema.UI
{
    public partial class FormAgregarProveedor : Form
    {
        public FormAgregarProveedor()
        {
            InitializeComponent();
            
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var _proveedorService = ServiceFactory.CrearProveedorService())
                {
                    _proveedorService.RegistrarProveedor(txtNombre.Text, txtDescripcion.Text, txtPrecioCompra.Text, txtPrecioVenta.Text, "asdfasf");
                    MessageBox.Show("Proveedor guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de Guardado, Intente de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;

            }
            this.Close();
        }
    }
}
