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
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(272, 35);
            label8.Name = "label8";
            label8.Size = new Size(318, 31);
            label8.TabIndex = 43;
            label8.Text = "Ingreso de Nuevo Proveedor";
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
            btnCancelar.BackColor = Color.Red;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(432, 416);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(105, 39);
            btnCancelar.TabIndex = 40;
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
            btnGuardar.Location = new Point(213, 416);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(172, 39);
            btnGuardar.TabIndex = 39;
            btnGuardar.Text = "Guardar Proveedor";
            btnGuardar.UseVisualStyleBackColor = false;
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
            label1.BackColor = Color.FromArgb(15, 19, 23);
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
            // FormAgregarProveedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 19, 23);
            ClientSize = new Size(862, 535);
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
    }
}