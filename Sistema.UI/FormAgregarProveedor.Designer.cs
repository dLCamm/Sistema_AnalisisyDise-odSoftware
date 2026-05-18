namespace Sistema.UI
{
    partial class FormAgregarProveedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label8 = new Label();
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
            label4 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(280, 29);
            label8.Name = "label8";
            label8.Size = new Size(257, 76);
            label8.TabIndex = 43;
            label8.Text = "Ingreso de Nuevo \r\nProveedor";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(101, 333);
            label7.Name = "label7";
            label7.Size = new Size(208, 31);
            label7.TabIndex = 42;
            label7.Text = "Correo Electronico";
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.BackColor = Color.FromArgb(30, 30, 35);
            txtPrecioVenta.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtPrecioVenta.ForeColor = Color.White;
            txtPrecioVenta.Location = new Point(354, 333);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(391, 34);
            txtPrecioVenta.TabIndex = 41;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.LightCoral;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.Location = new Point(212, 514);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(105, 39);
            btnCancelar.TabIndex = 40;
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
            btnGuardar.Location = new Point(390, 514);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(172, 39);
            btnGuardar.TabIndex = 39;
            btnGuardar.Text = "Guardar Proveedor";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(101, 272);
            label3.Name = "label3";
            label3.Size = new Size(113, 31);
            label3.TabIndex = 38;
            label3.Text = "Dirección";
            // 
            // txtPrecioCompra
            // 
            txtPrecioCompra.BackColor = Color.FromArgb(30, 30, 35);
            txtPrecioCompra.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtPrecioCompra.ForeColor = Color.White;
            txtPrecioCompra.Location = new Point(354, 272);
            txtPrecioCompra.Name = "txtPrecioCompra";
            txtPrecioCompra.Size = new Size(391, 34);
            txtPrecioCompra.TabIndex = 37;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(101, 207);
            label2.Name = "label2";
            label2.Size = new Size(104, 31);
            label2.TabIndex = 36;
            label2.Text = "Telefono";
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.FromArgb(30, 30, 35);
            txtDescripcion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtDescripcion.ForeColor = Color.White;
            txtDescripcion.Location = new Point(354, 207);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(391, 34);
            txtDescripcion.TabIndex = 35;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(101, 144);
            label1.Name = "label1";
            label1.Size = new Size(216, 31);
            label1.TabIndex = 34;
            label1.Text = "Nombre Proveedor";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(30, 30, 35);
            txtNombre.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtNombre.ForeColor = Color.White;
            txtNombre.Location = new Point(354, 144);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(391, 34);
            txtNombre.TabIndex = 33;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(101, 399);
            label4.Name = "label4";
            label4.Size = new Size(51, 31);
            label4.TabIndex = 44;
            label4.Text = "DPI";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(30, 30, 35);
            textBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(354, 399);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(391, 34);
            textBox1.TabIndex = 45;
            // 
            // FormAgregarProveedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 41, 55);
            ClientSize = new Size(862, 615);
            Controls.Add(textBox1);
            Controls.Add(label4);
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
            Name = "FormAgregarProveedor";
            Text = "FormAgregarProveedor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private Label label7;
        private TextBox txtPrecioVenta;
        private Button btnCancelar;
        private Button btnGuardar;
        private Label label3;
        private TextBox txtPrecioCompra;
        private Label label2;
        private TextBox txtDescripcion;
        private Label label1;
        private TextBox txtNombre;
        private Label label4;
        private TextBox textBox1;
    }
}