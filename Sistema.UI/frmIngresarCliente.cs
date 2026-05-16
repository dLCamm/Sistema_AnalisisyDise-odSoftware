using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sistema.Entities.Clientes;
using Sistema.BLL.Services;
using Sistema.BLL.Factories;

namespace Sistema.UI
{
    public partial class frmIngresarCliente : Form
    {


        

        public frmIngresarCliente()
        {
            InitializeComponent();
        
        }

        private void InitializeComponent()
        {
            label7 = new Label();
            txtPrecioVenta = new TextBox();
            btnCancelar = new Button();
            btnGuardar = new Button();
            label3 = new Label();
            txtPrecioCompra = new TextBox();
            label2 = new Label();
            txtDescripcion = new TextBox();
            label1 = new Label();
            txtNombre = new TextBox();
            label8 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(125, 283);
            label7.Name = "label7";
            label7.Size = new Size(208, 31);
            label7.TabIndex = 31;
            label7.Text = "Correo Electronico";
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.BackColor = Color.FromArgb(30, 30, 35);
            txtPrecioVenta.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtPrecioVenta.ForeColor = Color.White;
            txtPrecioVenta.Location = new Point(378, 283);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(391, 34);
            txtPrecioVenta.TabIndex = 30;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.LightCoral;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.Location = new Point(446, 436);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(105, 39);
            btnCancelar.TabIndex = 29;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.ActiveCaption;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.Black;
            btnGuardar.Location = new Point(227, 436);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(172, 39);
            btnGuardar.TabIndex = 28;
            btnGuardar.Text = "Guardar Cliente";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(125, 222);
            label3.Name = "label3";
            label3.Size = new Size(113, 31);
            label3.TabIndex = 21;
            label3.Text = "Dirección";
            // 
            // txtPrecioCompra
            // 
            txtPrecioCompra.BackColor = Color.FromArgb(30, 30, 35);
            txtPrecioCompra.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtPrecioCompra.ForeColor = Color.White;
            txtPrecioCompra.Location = new Point(378, 222);
            txtPrecioCompra.Name = "txtPrecioCompra";
            txtPrecioCompra.Size = new Size(391, 34);
            txtPrecioCompra.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(125, 157);
            label2.Name = "label2";
            label2.Size = new Size(104, 31);
            label2.TabIndex = 19;
            label2.Text = "Telefono";
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.FromArgb(30, 30, 35);
            txtDescripcion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtDescripcion.ForeColor = Color.White;
            txtDescripcion.Location = new Point(378, 157);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(391, 34);
            txtDescripcion.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(125, 94);
            label1.Name = "label1";
            label1.Size = new Size(178, 31);
            label1.TabIndex = 17;
            label1.Text = "Nombre Cliente";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(30, 30, 35);
            txtNombre.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtNombre.ForeColor = Color.White;
            txtNombre.Location = new Point(378, 94);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(391, 34);
            txtNombre.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(237, 25);
            label8.Name = "label8";
            label8.Size = new Size(348, 38);
            label8.TabIndex = 32;
            label8.Text = "Ingreso de Nuevo Cliente";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(125, 345);
            label4.Name = "label4";
            label4.Size = new Size(51, 31);
            label4.TabIndex = 34;
            label4.Text = "DPI";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(30, 30, 35);
            textBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(378, 345);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(391, 34);
            textBox1.TabIndex = 33;
            // 
            // frmIngresarCliente
            // 
            BackColor = Color.FromArgb(31, 41, 55);
            ClientSize = new Size(892, 532);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtPrecioVenta);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(label3);
            Controls.Add(txtPrecioCompra);
            Controls.Add(label2);
            Controls.Add(txtDescripcion);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Name = "frmIngresarCliente";
            Load += frmIngresarCliente_Load;
            ResumeLayout(false);
            PerformLayout();

        }



        private void btnCancelar_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object? sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtDescripcion.Text == "" || txtPrecioCompra.Text == "" || txtPrecioVenta.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var service = ServiceFactory.CrearClienteService())
                {
                    Cliente cliente = new Cliente();
                    cliente.Nombre = txtNombre.Text;
                    cliente.Telefono = txtDescripcion.Text;
                    cliente.Direccion = txtPrecioCompra.Text;
                    cliente.Email = txtPrecioVenta.Text;
                    cliente.DPI = long.Parse(textBox1.Text);


                    service.CrearCliente(cliente);
                }


                MessageBox.Show("Cliente guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el cliente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

        }

        private void frmIngresarCliente_Load(object? sender, EventArgs e)
        {

        }
    }
}