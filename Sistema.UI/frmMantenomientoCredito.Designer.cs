namespace Sistema.UI
{
    partial class frmMantenomientoCredito
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
            lblnombrecredito = new Label();
            label4 = new Label();
            txtFechaEmision = new TextBox();
            label3 = new Label();
            txtDPI = new TextBox();
            label1 = new Label();
            txtFechaVencimiento = new TextBox();
            labelnCreditos = new Label();
            btnCancelarCr = new Button();
            btnGuardarCredito = new Button();
            txtTotalCrédito = new TextBox();
            label2 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            txtNombreCliente = new TextBox();
            panel1 = new Panel();
            txtDireccion = new TextBox();
            label6 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblnombrecredito
            // 
            lblnombrecredito.AutoSize = true;
            lblnombrecredito.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblnombrecredito.ForeColor = Color.White;
            lblnombrecredito.Location = new Point(51, 83);
            lblnombrecredito.Name = "lblnombrecredito";
            lblnombrecredito.Size = new Size(130, 31);
            lblnombrecredito.TabIndex = 2;
            lblnombrecredito.Text = "👤 Cliente:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(69, 145);
            label4.Name = "label4";
            label4.Size = new Size(286, 31);
            label4.TabIndex = 11;
            label4.Text = "📅 Fecha de Vencimiento:";
            // 
            // txtFechaEmision
            // 
            txtFechaEmision.BackColor = Color.FromArgb(30, 30, 35);
            txtFechaEmision.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtFechaEmision.ForeColor = Color.White;
            txtFechaEmision.Location = new Point(361, 84);
            txtFechaEmision.Name = "txtFechaEmision";
            txtFechaEmision.Size = new Size(280, 34);
            txtFechaEmision.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(85, 161);
            label3.Name = "label3";
            label3.Size = new Size(96, 31);
            label3.TabIndex = 9;
            label3.Text = "💳 DPI:";
            // 
            // txtDPI
            // 
            txtDPI.BackColor = Color.FromArgb(30, 30, 35);
            txtDPI.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtDPI.ForeColor = Color.White;
            txtDPI.Location = new Point(196, 158);
            txtDPI.Name = "txtDPI";
            txtDPI.Size = new Size(540, 34);
            txtDPI.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(117, 87);
            label1.Name = "label1";
            label1.Size = new Size(238, 31);
            label1.TabIndex = 14;
            label1.Text = "📅 Fecha de Emisión:";
            // 
            // txtFechaVencimiento
            // 
            txtFechaVencimiento.BackColor = Color.FromArgb(30, 30, 35);
            txtFechaVencimiento.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtFechaVencimiento.ForeColor = Color.White;
            txtFechaVencimiento.Location = new Point(361, 144);
            txtFechaVencimiento.Name = "txtFechaVencimiento";
            txtFechaVencimiento.Size = new Size(280, 34);
            txtFechaVencimiento.TabIndex = 13;
            // 
            // labelnCreditos
            // 
            labelnCreditos.AutoSize = true;
            labelnCreditos.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold);
            labelnCreditos.ForeColor = Color.White;
            labelnCreditos.Location = new Point(12, 7);
            labelnCreditos.Name = "labelnCreditos";
            labelnCreditos.Size = new Size(222, 35);
            labelnCreditos.TabIndex = 15;
            labelnCreditos.Text = "NUEVO CRÉDITO";
            // 
            // btnCancelarCr
            // 
            btnCancelarCr.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancelarCr.BackColor = Color.RoyalBlue;
            btnCancelarCr.Cursor = Cursors.Hand;
            btnCancelarCr.FlatAppearance.BorderSize = 0;
            btnCancelarCr.FlatStyle = FlatStyle.Flat;
            btnCancelarCr.Font = new Font("Segoe UI", 13F);
            btnCancelarCr.ForeColor = Color.White;
            btnCancelarCr.Location = new Point(495, 673);
            btnCancelarCr.Name = "btnCancelarCr";
            btnCancelarCr.Size = new Size(213, 46);
            btnCancelarCr.TabIndex = 17;
            btnCancelarCr.Text = "Cancelar";
            btnCancelarCr.UseVisualStyleBackColor = false;
            btnCancelarCr.Click += btnCancelarCr_Click;
            // 
            // btnGuardarCredito
            // 
            btnGuardarCredito.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGuardarCredito.BackColor = Color.RoyalBlue;
            btnGuardarCredito.Cursor = Cursors.Hand;
            btnGuardarCredito.FlatAppearance.BorderSize = 0;
            btnGuardarCredito.FlatStyle = FlatStyle.Flat;
            btnGuardarCredito.Font = new Font("Segoe UI", 13F);
            btnGuardarCredito.ForeColor = Color.White;
            btnGuardarCredito.Location = new Point(150, 673);
            btnGuardarCredito.Name = "btnGuardarCredito";
            btnGuardarCredito.Size = new Size(213, 46);
            btnGuardarCredito.TabIndex = 16;
            btnGuardarCredito.Text = "Guardar";
            btnGuardarCredito.UseVisualStyleBackColor = false;
            // 
            // txtTotalCrédito
            // 
            txtTotalCrédito.BackColor = Color.FromArgb(30, 30, 35);
            txtTotalCrédito.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtTotalCrédito.ForeColor = Color.White;
            txtTotalCrédito.Location = new Point(361, 26);
            txtTotalCrédito.Name = "txtTotalCrédito";
            txtTotalCrédito.Size = new Size(280, 34);
            txtTotalCrédito.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(130, 29);
            label2.Name = "label2";
            label2.Size = new Size(225, 31);
            label2.TabIndex = 18;
            label2.Text = "💵Total del Crédito:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(45, 325);
            label5.Name = "label5";
            label5.Size = new Size(136, 26);
            label5.TabIndex = 20;
            label5.Text = "📞 Teléfono:";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(30, 30, 35);
            textBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(196, 317);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(374, 34);
            textBox1.TabIndex = 21;
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.BackColor = Color.FromArgb(30, 30, 35);
            txtNombreCliente.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtNombreCliente.ForeColor = Color.White;
            txtNombreCliente.Location = new Point(196, 60);
            txtNombreCliente.Multiline = true;
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(540, 65);
            txtNombreCliente.TabIndex = 22;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtFechaEmision);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtFechaVencimiento);
            panel1.Controls.Add(txtTotalCrédito);
            panel1.Controls.Add(label2);
            panel1.ForeColor = Color.FromArgb(15, 19, 23);
            panel1.Location = new Point(35, 406);
            panel1.Name = "panel1";
            panel1.Size = new Size(794, 206);
            panel1.TabIndex = 23;
            // 
            // txtDireccion
            // 
            txtDireccion.BackColor = Color.FromArgb(30, 30, 35);
            txtDireccion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtDireccion.ForeColor = Color.White;
            txtDireccion.Location = new Point(196, 223);
            txtDireccion.Multiline = true;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(540, 65);
            txtDireccion.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(23, 244);
            label6.Name = "label6";
            label6.Size = new Size(158, 31);
            label6.TabIndex = 24;
            label6.Text = "📍 Dirección:";
            // 
            // frmMantenomientoCredito
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 41, 55);
            ClientSize = new Size(861, 755);
            Controls.Add(txtDireccion);
            Controls.Add(label6);
            Controls.Add(panel1);
            Controls.Add(txtNombreCliente);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(btnCancelarCr);
            Controls.Add(btnGuardarCredito);
            Controls.Add(labelnCreditos);
            Controls.Add(label3);
            Controls.Add(txtDPI);
            Controls.Add(lblnombrecredito);
            ForeColor = Color.FromArgb(31, 41, 55);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "frmMantenomientoCredito";
            Text = "Nuevo Crédito";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblnombrecredito;
        private Label label4;
        private TextBox txtFechaEmision;
        private Label label3;
        private TextBox txtDPI;
        private Label label1;
        private TextBox txtFechaVencimiento;
        private Label labelnCreditos;
        private Button btnCancelarCr;
        private Button btnGuardarCredito;
        private TextBox txtTotalCrédito;
        private Label label2;
        private Label label5;
        private TextBox textBox1;
        private TextBox txtNombreCliente;
        private Panel panel1;
        private TextBox txtDireccion;
        private Label label6;
    }
}