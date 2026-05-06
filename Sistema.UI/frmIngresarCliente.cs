using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(124, 255);
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
            txtPrecioVenta.Location = new Point(377, 255);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(391, 34);
            txtPrecioVenta.TabIndex = 30;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Red;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(455, 338);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(105, 39);
            btnCancelar.TabIndex = 29;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.Highlight;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(236, 338);
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
            label3.Location = new Point(124, 194);
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
            txtPrecioCompra.Location = new Point(377, 194);
            txtPrecioCompra.Name = "txtPrecioCompra";
            txtPrecioCompra.Size = new Size(391, 34);
            txtPrecioCompra.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(124, 129);
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
            txtDescripcion.Location = new Point(377, 129);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(391, 34);
            txtDescripcion.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(15, 19, 23);
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(124, 66);
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
            txtNombre.Location = new Point(377, 66);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(391, 34);
            txtNombre.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(309, 18);
            label8.Name = "label8";
            label8.Size = new Size(277, 31);
            label8.TabIndex = 32;
            label8.Text = "Ingreso de Nuevo Cliente";
            // 
            // frmIngresarCliente
            // 
            BackColor = Color.FromArgb(15, 19, 23);
            ClientSize = new Size(892, 427);
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



        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void frmIngresarCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
