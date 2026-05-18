namespace Sistema.UI
{
    partial class frmMantenimientoProducto
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
            txtNombre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtDescripcion = new TextBox();
            label3 = new Label();
            txtPrecioCompra = new TextBox();
            label4 = new Label();
            txtStockActual = new TextBox();
            label5 = new Label();
            txtStockMinimo = new TextBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            label7 = new Label();
            txtPrecioVenta = new TextBox();
            btnAnular = new Button();
            btnActivarProducto = new Button();
            cmbProveedor = new ComboBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(30, 30, 35);
            txtNombre.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtNombre.ForeColor = Color.White;
            txtNombre.Location = new Point(274, 30);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(771, 65);
            txtNombre.TabIndex = 0;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(25, 30);
            label1.Name = "label1";
            label1.Size = new Size(247, 31);
            label1.TabIndex = 1;
            label1.Text = "Nombre del Producto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(129, 149);
            label2.Name = "label2";
            label2.Size = new Size(143, 31);
            label2.TabIndex = 3;
            label2.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.FromArgb(30, 30, 35);
            txtDescripcion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtDescripcion.ForeColor = Color.White;
            txtDescripcion.Location = new Point(274, 146);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(771, 120);
            txtDescripcion.TabIndex = 2;
            txtDescripcion.TextChanged += txtDescripcion_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(25, 410);
            label3.Name = "label3";
            label3.Size = new Size(206, 31);
            label3.TabIndex = 5;
            label3.Text = "Precio de Compra:";
            // 
            // txtPrecioCompra
            // 
            txtPrecioCompra.BackColor = Color.FromArgb(30, 30, 35);
            txtPrecioCompra.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtPrecioCompra.ForeColor = Color.White;
            txtPrecioCompra.Location = new Point(237, 407);
            txtPrecioCompra.Name = "txtPrecioCompra";
            txtPrecioCompra.Size = new Size(243, 34);
            txtPrecioCompra.TabIndex = 4;
            txtPrecioCompra.TextChanged += txtPrecioCompra_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(153, 492);
            label4.Name = "label4";
            label4.Size = new Size(78, 31);
            label4.TabIndex = 7;
            label4.Text = "Stock:";
            // 
            // txtStockActual
            // 
            txtStockActual.BackColor = Color.FromArgb(30, 30, 35);
            txtStockActual.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtStockActual.ForeColor = Color.White;
            txtStockActual.Location = new Point(237, 489);
            txtStockActual.Name = "txtStockActual";
            txtStockActual.Size = new Size(243, 34);
            txtStockActual.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(623, 490);
            label5.Name = "label5";
            label5.Size = new Size(163, 31);
            label5.TabIndex = 9;
            label5.Text = "Stock Minimo:";
            // 
            // txtStockMinimo
            // 
            txtStockMinimo.BackColor = Color.FromArgb(30, 30, 35);
            txtStockMinimo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtStockMinimo.ForeColor = Color.White;
            txtStockMinimo.Location = new Point(802, 487);
            txtStockMinimo.Name = "txtStockMinimo";
            txtStockMinimo.Size = new Size(243, 34);
            txtStockMinimo.TabIndex = 8;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.Highlight;
            btnGuardar.FlatAppearance.BorderColor = Color.White;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Arial", 12F);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(623, 629);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(187, 47);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "Guardar Producto";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Red;
            btnCancelar.FlatAppearance.BorderColor = Color.White;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Arial", 12F);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(318, 629);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(106, 47);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(604, 408);
            label7.Name = "label7";
            label7.Size = new Size(182, 31);
            label7.TabIndex = 15;
            label7.Text = "Precio de Venta:";
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.BackColor = Color.FromArgb(30, 30, 35);
            txtPrecioVenta.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtPrecioVenta.ForeColor = Color.White;
            txtPrecioVenta.Location = new Point(802, 405);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(243, 34);
            txtPrecioVenta.TabIndex = 14;
            // 
            // btnAnular
            // 
            btnAnular.BackColor = Color.Red;
            btnAnular.FlatAppearance.BorderColor = Color.White;
            btnAnular.FlatStyle = FlatStyle.Flat;
            btnAnular.Font = new Font("Arial", 12F);
            btnAnular.ForeColor = Color.White;
            btnAnular.Location = new Point(898, 629);
            btnAnular.Name = "btnAnular";
            btnAnular.Size = new Size(188, 55);
            btnAnular.TabIndex = 16;
            btnAnular.Text = "⚠ Anular Producto";
            btnAnular.UseVisualStyleBackColor = false;
            btnAnular.Click += btnAnular_Click_1;
            // 
            // btnActivarProducto
            // 
            btnActivarProducto.BackColor = SystemColors.Highlight;
            btnActivarProducto.FlatAppearance.BorderColor = Color.White;
            btnActivarProducto.FlatStyle = FlatStyle.Flat;
            btnActivarProducto.Font = new Font("Arial", 12F);
            btnActivarProducto.ForeColor = Color.White;
            btnActivarProducto.Location = new Point(899, 558);
            btnActivarProducto.Name = "btnActivarProducto";
            btnActivarProducto.Size = new Size(187, 57);
            btnActivarProducto.TabIndex = 17;
            btnActivarProducto.Text = "Activar Producto";
            btnActivarProducto.UseVisualStyleBackColor = false;
            btnActivarProducto.Click += btnActivarProducto_Click;
            // 
            // cmbProveedor
            // 
            cmbProveedor.BackColor = Color.FromArgb(30, 30, 35);
            cmbProveedor.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbProveedor.ForeColor = Color.White;
            cmbProveedor.FormattingEnabled = true;
            cmbProveedor.Location = new Point(274, 310);
            cmbProveedor.Name = "cmbProveedor";
            cmbProveedor.Size = new Size(771, 39);
            cmbProveedor.TabIndex = 18;
            cmbProveedor.SelectedIndexChanged += cmbProveedor_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(129, 310);
            label6.Name = "label6";
            label6.Size = new Size(130, 31);
            label6.TabIndex = 19;
            label6.Text = "Proveedor:";
            // 
            // frmMantenimientoProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 41, 55);
            ClientSize = new Size(1098, 696);
            Controls.Add(label6);
            Controls.Add(cmbProveedor);
            Controls.Add(btnActivarProducto);
            Controls.Add(btnAnular);
            Controls.Add(label7);
            Controls.Add(txtPrecioVenta);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(label5);
            Controls.Add(txtStockMinimo);
            Controls.Add(label4);
            Controls.Add(txtStockActual);
            Controls.Add(label3);
            Controls.Add(txtPrecioCompra);
            Controls.Add(label2);
            Controls.Add(txtDescripcion);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmMantenimientoProducto";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmMantenimientoProducto";
            Load += frmMantenimientoProducto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private Label label1;
        private Label label2;
        private TextBox txtDescripcion;
        private Label label3;
        private TextBox txtPrecioCompra;
        private Label label4;
        private TextBox txtStockActual;
        private Label label5;
        private TextBox txtStockMinimo;
        private Button btnGuardar;
        private Button btnCancelar;
        private Label label7;
        private TextBox txtPrecioVenta;
        private Button btnAnular;
        private Button btnActivarProducto;
        private ComboBox cmbProveedor;
        private Label label6;
    }
}