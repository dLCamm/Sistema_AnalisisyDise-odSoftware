namespace Sistema.UI
{
    partial class frmDetalleCredito
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            pnlDetallecredito = new Panel();
            txtDetalleVencimiento = new TextBox();
            txtDetalleEmision = new TextBox();
            txtDetalleTelefono = new TextBox();
            txtDetalleDpi = new TextBox();
            txtDetalleCliente = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            labelCreditos = new Label();
            pnlResumen = new Panel();
            dgvDetalleAbonos = new DataGridView();
            colAbono = new DataGridViewTextBoxColumn();
            colfecha = new DataGridViewTextBoxColumn();
            pnlTotales = new Panel();
            dgvTotales = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            colSaldoPendiente = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            btnAgregarAbono = new Button();
            btnCancelarCredito = new Button();
            label4 = new Label();
            btnAnularAbono = new Button();
            pnlNuevoAbono = new Panel();
            btnCancelarAb = new Button();
            btnGuardarAbono = new Button();
            txtCantidadAbono = new TextBox();
            label6 = new Label();
            pnlDetallecredito.SuspendLayout();
            pnlResumen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleAbonos).BeginInit();
            pnlTotales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTotales).BeginInit();
            pnlNuevoAbono.SuspendLayout();
            SuspendLayout();
            // 
            // pnlDetallecredito
            // 
            pnlDetallecredito.BackColor = Color.FromArgb(31, 41, 55);
            pnlDetallecredito.Controls.Add(txtDetalleVencimiento);
            pnlDetallecredito.Controls.Add(txtDetalleEmision);
            pnlDetallecredito.Controls.Add(txtDetalleTelefono);
            pnlDetallecredito.Controls.Add(txtDetalleDpi);
            pnlDetallecredito.Controls.Add(txtDetalleCliente);
            pnlDetallecredito.Controls.Add(label5);
            pnlDetallecredito.Controls.Add(label3);
            pnlDetallecredito.Controls.Add(label2);
            pnlDetallecredito.Controls.Add(label1);
            pnlDetallecredito.Controls.Add(labelCreditos);
            pnlDetallecredito.Location = new Point(40, 48);
            pnlDetallecredito.Name = "pnlDetallecredito";
            pnlDetallecredito.Size = new Size(709, 559);
            pnlDetallecredito.TabIndex = 0;
            pnlDetallecredito.Paint += pnlDetallecredito_Paint;
            // 
            // txtDetalleVencimiento
            // 
            txtDetalleVencimiento.BackColor = Color.FromArgb(30, 30, 35);
            txtDetalleVencimiento.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtDetalleVencimiento.ForeColor = Color.White;
            txtDetalleVencimiento.Location = new Point(45, 511);
            txtDetalleVencimiento.Name = "txtDetalleVencimiento";
            txtDetalleVencimiento.Size = new Size(390, 34);
            txtDetalleVencimiento.TabIndex = 18;
            // 
            // txtDetalleEmision
            // 
            txtDetalleEmision.BackColor = Color.FromArgb(30, 30, 35);
            txtDetalleEmision.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtDetalleEmision.ForeColor = Color.White;
            txtDetalleEmision.Location = new Point(45, 411);
            txtDetalleEmision.Name = "txtDetalleEmision";
            txtDetalleEmision.Size = new Size(390, 34);
            txtDetalleEmision.TabIndex = 17;
            // 
            // txtDetalleTelefono
            // 
            txtDetalleTelefono.BackColor = Color.FromArgb(30, 30, 35);
            txtDetalleTelefono.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtDetalleTelefono.ForeColor = Color.White;
            txtDetalleTelefono.Location = new Point(45, 305);
            txtDetalleTelefono.Name = "txtDetalleTelefono";
            txtDetalleTelefono.Size = new Size(390, 34);
            txtDetalleTelefono.TabIndex = 16;
            // 
            // txtDetalleDpi
            // 
            txtDetalleDpi.BackColor = Color.FromArgb(30, 30, 35);
            txtDetalleDpi.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtDetalleDpi.ForeColor = Color.White;
            txtDetalleDpi.Location = new Point(45, 192);
            txtDetalleDpi.Name = "txtDetalleDpi";
            txtDetalleDpi.Size = new Size(390, 34);
            txtDetalleDpi.TabIndex = 15;
            // 
            // txtDetalleCliente
            // 
            txtDetalleCliente.BackColor = Color.FromArgb(30, 30, 35);
            txtDetalleCliente.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtDetalleCliente.ForeColor = Color.White;
            txtDetalleCliente.Location = new Point(45, 76);
            txtDetalleCliente.Name = "txtDetalleCliente";
            txtDetalleCliente.Size = new Size(622, 34);
            txtDetalleCliente.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(45, 253);
            label5.Name = "label5";
            label5.Size = new Size(136, 26);
            label5.TabIndex = 9;
            label5.Text = "📞 Teléfono:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(45, 470);
            label3.Name = "label3";
            label3.Size = new Size(268, 26);
            label3.TabIndex = 8;
            label3.Text = "📅 Fecha de Vencimiento:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(45, 367);
            label2.Name = "label2";
            label2.Size = new Size(224, 26);
            label2.TabIndex = 7;
            label2.Text = "📅 Fecha de Emisión:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(45, 137);
            label1.Name = "label1";
            label1.Size = new Size(86, 26);
            label1.TabIndex = 6;
            label1.Text = "💳 DPI:";
            // 
            // labelCreditos
            // 
            labelCreditos.AutoSize = true;
            labelCreditos.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCreditos.ForeColor = Color.White;
            labelCreditos.Location = new Point(45, 22);
            labelCreditos.Name = "labelCreditos";
            labelCreditos.Size = new Size(121, 26);
            labelCreditos.TabIndex = 5;
            labelCreditos.Text = "👤 Cliente:";
            // 
            // pnlResumen
            // 
            pnlResumen.BackColor = Color.FromArgb(31, 41, 55);
            pnlResumen.Controls.Add(dgvDetalleAbonos);
            pnlResumen.Location = new Point(781, 48);
            pnlResumen.Name = "pnlResumen";
            pnlResumen.Size = new Size(754, 559);
            pnlResumen.TabIndex = 1;
            // 
            // dgvDetalleAbonos
            // 
            dgvDetalleAbonos.AllowUserToAddRows = false;
            dgvDetalleAbonos.AllowUserToResizeColumns = false;
            dgvDetalleAbonos.AllowUserToResizeRows = false;
            dgvDetalleAbonos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvDetalleAbonos.BackgroundColor = Color.FromArgb(31, 41, 55);
            dgvDetalleAbonos.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(15, 19, 23);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(15, 19, 23);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDetalleAbonos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDetalleAbonos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalleAbonos.Columns.AddRange(new DataGridViewColumn[] { colAbono, colfecha });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(15, 19, 23);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 13F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvDetalleAbonos.DefaultCellStyle = dataGridViewCellStyle2;
            dgvDetalleAbonos.EnableHeadersVisualStyles = false;
            dgvDetalleAbonos.GridColor = Color.FromArgb(70, 70, 75);
            dgvDetalleAbonos.Location = new Point(3, 3);
            dgvDetalleAbonos.Name = "dgvDetalleAbonos";
            dgvDetalleAbonos.ReadOnly = true;
            dgvDetalleAbonos.RowHeadersVisible = false;
            dgvDetalleAbonos.RowHeadersWidth = 51;
            dgvDetalleAbonos.RowTemplate.Height = 60;
            dgvDetalleAbonos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalleAbonos.Size = new Size(748, 553);
            dgvDetalleAbonos.TabIndex = 4;
            // 
            // colAbono
            // 
            colAbono.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colAbono.HeaderText = "Abono";
            colAbono.MinimumWidth = 6;
            colAbono.Name = "colAbono";
            colAbono.ReadOnly = true;
            // 
            // colfecha
            // 
            colfecha.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colfecha.HeaderText = "Fecha";
            colfecha.MinimumWidth = 6;
            colfecha.Name = "colfecha";
            colfecha.ReadOnly = true;
            // 
            // pnlTotales
            // 
            pnlTotales.BackColor = Color.FromArgb(31, 41, 55);
            pnlTotales.Controls.Add(dgvTotales);
            pnlTotales.Location = new Point(778, 692);
            pnlTotales.Name = "pnlTotales";
            pnlTotales.Size = new Size(754, 134);
            pnlTotales.TabIndex = 2;
            // 
            // dgvTotales
            // 
            dgvTotales.AllowUserToAddRows = false;
            dgvTotales.AllowUserToResizeColumns = false;
            dgvTotales.AllowUserToResizeRows = false;
            dgvTotales.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvTotales.BackgroundColor = Color.FromArgb(31, 41, 55);
            dgvTotales.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(15, 19, 23);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 14F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(15, 19, 23);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvTotales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvTotales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTotales.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, colSaldoPendiente, dataGridViewTextBoxColumn2 });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(15, 19, 23);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 13F);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvTotales.DefaultCellStyle = dataGridViewCellStyle4;
            dgvTotales.EnableHeadersVisualStyles = false;
            dgvTotales.GridColor = Color.FromArgb(70, 70, 75);
            dgvTotales.Location = new Point(3, 3);
            dgvTotales.Name = "dgvTotales";
            dgvTotales.ReadOnly = true;
            dgvTotales.RowHeadersVisible = false;
            dgvTotales.RowHeadersWidth = 51;
            dgvTotales.RowTemplate.Height = 60;
            dgvTotales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTotales.Size = new Size(748, 128);
            dgvTotales.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn1.HeaderText = "Total Crédito";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // colSaldoPendiente
            // 
            colSaldoPendiente.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colSaldoPendiente.HeaderText = "Total Abonado";
            colSaldoPendiente.MinimumWidth = 6;
            colSaldoPendiente.Name = "colSaldoPendiente";
            colSaldoPendiente.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn2.HeaderText = "Saldo Pendiente";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // btnAgregarAbono
            // 
            btnAgregarAbono.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAgregarAbono.BackColor = Color.RoyalBlue;
            btnAgregarAbono.Cursor = Cursors.Hand;
            btnAgregarAbono.FlatAppearance.BorderSize = 0;
            btnAgregarAbono.FlatStyle = FlatStyle.Flat;
            btnAgregarAbono.Font = new Font("Segoe UI", 13F);
            btnAgregarAbono.ForeColor = Color.White;
            btnAgregarAbono.Location = new Point(337, 624);
            btnAgregarAbono.Name = "btnAgregarAbono";
            btnAgregarAbono.Size = new Size(213, 46);
            btnAgregarAbono.TabIndex = 6;
            btnAgregarAbono.Text = "+Agregar Abono";
            btnAgregarAbono.UseVisualStyleBackColor = false;
            btnAgregarAbono.Click += btnAgregarAbono_Click;
            // 
            // btnCancelarCredito
            // 
            btnCancelarCredito.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancelarCredito.BackColor = Color.RoyalBlue;
            btnCancelarCredito.Cursor = Cursors.Hand;
            btnCancelarCredito.FlatAppearance.BorderSize = 0;
            btnCancelarCredito.FlatStyle = FlatStyle.Flat;
            btnCancelarCredito.Font = new Font("Segoe UI", 13F);
            btnCancelarCredito.ForeColor = Color.White;
            btnCancelarCredito.Location = new Point(40, 624);
            btnCancelarCredito.Name = "btnCancelarCredito";
            btnCancelarCredito.Size = new Size(213, 46);
            btnCancelarCredito.TabIndex = 7;
            btnCancelarCredito.Text = "⚠️Cancelar Crédito";
            btnCancelarCredito.UseVisualStyleBackColor = false;
            btnCancelarCredito.Click += btnCancelarCredito_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(31, 41, 55);
            label4.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(40, 10);
            label4.Name = "label4";
            label4.Size = new Size(139, 35);
            label4.TabIndex = 8;
            label4.Text = "DETALLES";
            // 
            // btnAnularAbono
            // 
            btnAnularAbono.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAnularAbono.BackColor = Color.RoyalBlue;
            btnAnularAbono.Cursor = Cursors.Hand;
            btnAnularAbono.FlatAppearance.BorderSize = 0;
            btnAnularAbono.FlatStyle = FlatStyle.Flat;
            btnAnularAbono.Font = new Font("Segoe UI", 13F);
            btnAnularAbono.ForeColor = Color.White;
            btnAnularAbono.Location = new Point(40, 721);
            btnAnularAbono.Name = "btnAnularAbono";
            btnAnularAbono.Size = new Size(213, 46);
            btnAnularAbono.TabIndex = 9;
            btnAnularAbono.Text = "Anular Abono";
            btnAnularAbono.UseVisualStyleBackColor = false;
            btnAnularAbono.Click += btnAnularAbono_Click;
            // 
            // pnlNuevoAbono
            // 
            pnlNuevoAbono.BackColor = Color.FromArgb(31, 41, 55);
            pnlNuevoAbono.Controls.Add(btnCancelarAb);
            pnlNuevoAbono.Controls.Add(btnGuardarAbono);
            pnlNuevoAbono.Controls.Add(txtCantidadAbono);
            pnlNuevoAbono.Controls.Add(label6);
            pnlNuevoAbono.Font = new Font("Segoe UI", 7F);
            pnlNuevoAbono.Location = new Point(337, 692);
            pnlNuevoAbono.Name = "pnlNuevoAbono";
            pnlNuevoAbono.Size = new Size(412, 134);
            pnlNuevoAbono.TabIndex = 10;
            pnlNuevoAbono.Visible = false;
            // 
            // btnCancelarAb
            // 
            btnCancelarAb.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancelarAb.BackColor = Color.RoyalBlue;
            btnCancelarAb.Cursor = Cursors.Hand;
            btnCancelarAb.FlatAppearance.BorderSize = 0;
            btnCancelarAb.FlatStyle = FlatStyle.Flat;
            btnCancelarAb.Font = new Font("Segoe UI", 13F);
            btnCancelarAb.ForeColor = Color.White;
            btnCancelarAb.Location = new Point(242, 79);
            btnCancelarAb.Name = "btnCancelarAb";
            btnCancelarAb.Size = new Size(128, 41);
            btnCancelarAb.TabIndex = 13;
            btnCancelarAb.Text = "Cancelar";
            btnCancelarAb.UseVisualStyleBackColor = false;
            btnCancelarAb.Click += btnCancelarAb_Click;
            // 
            // btnGuardarAbono
            // 
            btnGuardarAbono.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGuardarAbono.BackColor = Color.RoyalBlue;
            btnGuardarAbono.Cursor = Cursors.Hand;
            btnGuardarAbono.FlatAppearance.BorderSize = 0;
            btnGuardarAbono.FlatStyle = FlatStyle.Flat;
            btnGuardarAbono.Font = new Font("Segoe UI", 13F);
            btnGuardarAbono.ForeColor = Color.White;
            btnGuardarAbono.Location = new Point(34, 79);
            btnGuardarAbono.Name = "btnGuardarAbono";
            btnGuardarAbono.Size = new Size(128, 41);
            btnGuardarAbono.TabIndex = 11;
            btnGuardarAbono.Text = "Guardar";
            btnGuardarAbono.UseVisualStyleBackColor = false;
            btnGuardarAbono.Click += btnGuardarAbono_Click;
            // 
            // txtCantidadAbono
            // 
            txtCantidadAbono.BackColor = Color.FromArgb(30, 30, 35);
            txtCantidadAbono.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtCantidadAbono.ForeColor = Color.White;
            txtCantidadAbono.Location = new Point(116, 18);
            txtCantidadAbono.Name = "txtCantidadAbono";
            txtCantidadAbono.Size = new Size(210, 34);
            txtCantidadAbono.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(31, 41, 55);
            label6.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(4, 21);
            label6.Name = "label6";
            label6.Size = new Size(106, 28);
            label6.TabIndex = 12;
            label6.Text = "Cantidad:";
            // 
            // frmDetalleCredito
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 19, 23);
            ClientSize = new Size(1582, 861);
            Controls.Add(pnlNuevoAbono);
            Controls.Add(btnAnularAbono);
            Controls.Add(label4);
            Controls.Add(btnCancelarCredito);
            Controls.Add(btnAgregarAbono);
            Controls.Add(pnlTotales);
            Controls.Add(pnlResumen);
            Controls.Add(pnlDetallecredito);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "frmDetalleCredito";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Detalles del Crédito";
            Load += frmDetalleCredito_Load;
            pnlDetallecredito.ResumeLayout(false);
            pnlDetallecredito.PerformLayout();
            pnlResumen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDetalleAbonos).EndInit();
            pnlTotales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTotales).EndInit();
            pnlNuevoAbono.ResumeLayout(false);
            pnlNuevoAbono.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlDetallecredito;
        private Panel pnlResumen;
        private Panel pnlTotales;
        private Button btnAgregarAbono;
        private Button btnCancelarCredito;
        private DataGridView dgvTotales;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn colSaldoPendiente;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private Label labelCreditos;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label5;
        private Button btnAnularAbono;
        private Panel pnlNuevoAbono;
        private Label label6;
        private TextBox txtCantidadAbono;
        private Button btnCancelarAb;
        private Button btnGuardarAbono;
        private TextBox txtDetalleVencimiento;
        private TextBox txtDetalleEmision;
        private TextBox txtDetalleTelefono;
        private TextBox txtDetalleDpi;
        private TextBox txtDetalleCliente;
        private DataGridView dgvDetalleAbonos;
        private DataGridViewTextBoxColumn colAbono;
        private DataGridViewTextBoxColumn colfecha;
    }
}