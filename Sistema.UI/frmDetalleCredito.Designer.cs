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
            pnlDetallecredito.SuspendLayout();
            pnlResumen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleAbonos).BeginInit();
            pnlTotales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTotales).BeginInit();
            SuspendLayout();
            // 
            // pnlDetallecredito
            // 
            pnlDetallecredito.BackColor = Color.FromArgb(31, 41, 55);
            pnlDetallecredito.Controls.Add(label3);
            pnlDetallecredito.Controls.Add(label2);
            pnlDetallecredito.Controls.Add(label1);
            pnlDetallecredito.Controls.Add(labelCreditos);
            pnlDetallecredito.Location = new Point(40, 48);
            pnlDetallecredito.Name = "pnlDetallecredito";
            pnlDetallecredito.Size = new Size(709, 559);
            pnlDetallecredito.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(45, 443);
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
            label2.Location = new Point(45, 314);
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
            label1.Location = new Point(45, 176);
            label1.Name = "label1";
            label1.Size = new Size(86, 26);
            label1.TabIndex = 6;
            label1.Text = "👤 DPI:";
            // 
            // labelCreditos
            // 
            labelCreditos.AutoSize = true;
            labelCreditos.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCreditos.ForeColor = Color.White;
            labelCreditos.Location = new Point(45, 46);
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
            pnlTotales.Location = new Point(781, 652);
            pnlTotales.Name = "pnlTotales";
            pnlTotales.Size = new Size(754, 118);
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
            dgvTotales.Size = new Size(748, 112);
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
            btnAgregarAbono.Location = new Point(109, 673);
            btnAgregarAbono.Name = "btnAgregarAbono";
            btnAgregarAbono.Size = new Size(213, 46);
            btnAgregarAbono.TabIndex = 6;
            btnAgregarAbono.Text = "+Agregar Abono";
            btnAgregarAbono.UseVisualStyleBackColor = false;
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
            btnCancelarCredito.Location = new Point(455, 673);
            btnCancelarCredito.Name = "btnCancelarCredito";
            btnCancelarCredito.Size = new Size(213, 46);
            btnCancelarCredito.TabIndex = 7;
            btnCancelarCredito.Text = "⚠️Cancelar Crédito";
            btnCancelarCredito.UseVisualStyleBackColor = false;
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
            // frmDetalleCredito
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 19, 23);
            ClientSize = new Size(1582, 803);
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
            pnlDetallecredito.ResumeLayout(false);
            pnlDetallecredito.PerformLayout();
            pnlResumen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDetalleAbonos).EndInit();
            pnlTotales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTotales).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlDetallecredito;
        private Panel pnlResumen;
        private Panel pnlTotales;
        private Button btnAgregarAbono;
        private Button btnCancelarCredito;
        private DataGridView dgvDetalleAbonos;
        private DataGridViewTextBoxColumn colAbono;
        private DataGridViewTextBoxColumn colfecha;
        private DataGridView dgvTotales;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn colSaldoPendiente;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private Label labelCreditos;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
    }
}