using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sistema.BLL.Services;
using Sistema.DAL.Repositories;
using Sistema.Entities.Proveedores;


namespace Sistema.UI
{
    public partial class FormAgregarProveedor : Form
    {
        private ProveedorService _proveedorService;
        public FormAgregarProveedor()
        {
            InitializeComponent();
            if (Program.Context != null)
            {
                var proveedorRepository = new ProveedorRepository(Program.Context);
                _proveedorService = new ProveedorService(Program.Context, proveedorRepository);

            }
            else
            {
                MessageBox.Show("Error al inicializar el servicio de ventas. Contexto no disponible.");
                this.Close();
                return;
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                _proveedorService.RegistrarProveedor(txtNombre.Text, txtDescripcion.Text, txtPrecioCompra.Text, txtPrecioVenta.Text);
                MessageBox.Show("Proveedor guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de Guardado, Intente de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;

            }
        }
    }
}
