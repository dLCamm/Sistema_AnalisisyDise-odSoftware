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
            label4 = new Label();
            txtFechaEmision = new TextBox();
            label1 = new Label();
            txtFechaVencimiento = new TextBox();
            labelnCreditos = new Label();
            btnCancelarCr = new Button();
            btnGuardarCredito = new Button();
            panel1 = new Panel();
            label2 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(68, 49);
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
            txtFechaEmision.Location = new Point(360, 122);
            txtFechaEmision.Name = "txtFechaEmision";
            txtFechaEmision.Size = new Size(280, 34);
            txtFechaEmision.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(158, 123);
            label1.Name = "label1";
            label1.Size = new Size(196, 31);
            label1.TabIndex = 14;
            label1.Text = "💵 Abono Inicial:";
            // 
            // txtFechaVencimiento
            // 
            txtFechaVencimiento.BackColor = Color.FromArgb(30, 30, 35);
            txtFechaVencimiento.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtFechaVencimiento.ForeColor = Color.White;
            txtFechaVencimiento.Location = new Point(360, 48);
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
            btnCancelarCr.Location = new Point(495, 313);
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
            btnGuardarCredito.Location = new Point(152, 313);
            btnGuardarCredito.Name = "btnGuardarCredito";
            btnGuardarCredito.Size = new Size(213, 46);
            btnGuardarCredito.TabIndex = 16;
            btnGuardarCredito.Text = "Guardar";
            btnGuardarCredito.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtFechaVencimiento);
            panel1.Controls.Add(txtFechaEmision);
            panel1.ForeColor = Color.FromArgb(15, 19, 23);
            panel1.Location = new Point(38, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(787, 206);
            panel1.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(646, 60);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 15;
            label2.Text = "(Opcional)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(646, 136);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 16;
            label3.Text = "(Opcional)";
            // 
            // frmMantenomientoCredito
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 41, 55);
            ClientSize = new Size(861, 404);
            Controls.Add(panel1);
            Controls.Add(btnCancelarCr);
            Controls.Add(btnGuardarCredito);
            Controls.Add(labelnCreditos);
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
        private Label label4;
        private TextBox txtFechaEmision;
        private Label label1;
        private TextBox txtFechaVencimiento;
        private Label labelnCreditos;
        private Button btnCancelarCr;
        private Button btnGuardarCredito;
        private Panel panel1;
        private Label label3;
        private Label label2;
    }
}