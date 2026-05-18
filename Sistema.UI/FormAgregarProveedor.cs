using Sistema.BLL.Factories;
using Sistema.Entities.Clientes;
using Sistema.Entities.Proveedores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;



namespace Sistema.UI
{
    public partial class FormAgregarProveedor : Form
    {
        int proveedorId = 0;
        public FormAgregarProveedor(int? proveedorid= null)
        {
            InitializeComponent();
            if (proveedorid.HasValue)
            {
                proveedorId = proveedorid.Value;
                CargarDatosProveedor(proveedorId);
                CrearBotonAnular();
            }



        }

        private void CargarDatosProveedor(int proveedorId)
        {
            try
            {
                using (var service = ServiceFactory.CrearProveedorService())
                {
                    var proveedor = service.ObtenerProveedor(proveedorId);
                    if (proveedor != null)
                    {
                        txtNombre.Text = proveedor.Nombre;
                        txtDescripcion.Text = proveedor.Telefono;
                        txtPrecioCompra.Text = proveedor.Direccion;
                        txtPrecioVenta.Text = proveedor.Email;
                        textBox1.Text = proveedor.DPI.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Proveedor no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar al proveedor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private void CrearBotonAnular()
        {
            Button boton_anular = new Button();
            boton_anular.BackColor = Color.DarkRed;
            boton_anular.FlatAppearance.BorderSize = 0;
            boton_anular.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            boton_anular.ForeColor = Color.White;
            boton_anular.Location = new Point(668, 514);
            boton_anular.Name = "btnAnular";
            boton_anular.Size = new Size(172, 39);
            boton_anular.TabIndex = 28;
            boton_anular.Text = "Anular Proveedor";
            boton_anular.UseVisualStyleBackColor = false;
            boton_anular.Click += btnAnular_Click;
            Controls.Add(boton_anular);

        }

        private void btnAnular_Click(object? sender, EventArgs e)
        {
            try
            {
                using (var service = ServiceFactory.CrearProveedorService())
                {
                    service.AnularProveedor(proveedorId);
                }
                MessageBox.Show("Proveedor anulado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al anular el proveedor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                using (var _proveedorService = ServiceFactory.CrearProveedorService())
                {
                    if (proveedorId > 0)
                    {
                        _proveedorService.ActualizarProveedor(proveedorId, txtNombre.Text, txtDescripcion.Text, txtPrecioCompra.Text, txtPrecioVenta.Text, textBox1.Text, EstadoProveedor.Activo);
                        MessageBox.Show("Proveedor actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        _proveedorService.RegistrarProveedor(txtNombre.Text, txtDescripcion.Text, txtPrecioCompra.Text, textBox1.Text, txtPrecioVenta.Text);
                        MessageBox.Show("Proveedor guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

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
