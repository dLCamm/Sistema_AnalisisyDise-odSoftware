namespace Sistema.UI
{
    partial class frmReportes
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            labelCreditos = new Label();
            dgvDetalleAbonos = new DataGridView();
            ColFecha = new DataGridViewTextBoxColumn();
            colTipo = new DataGridViewTextBoxColumn();
            colEstado = new DataGridViewTextBoxColumn();
            colTipoPago = new DataGridViewTextBoxColumn();
            colTotal = new DataGridViewTextBoxColumn();
            btnExportarPdf = new Button();
            btnExportarExcel = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleAbonos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(31, 41, 55);
            panel1.Controls.Add(labelCreditos);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1287, 73);
            panel1.TabIndex = 0;
            // 
            // labelCreditos
            // 
            labelCreditos.AutoSize = true;
            labelCreditos.Font = new Font("Segoe UI Black", 25F, FontStyle.Bold);
            labelCreditos.ForeColor = Color.White;
            labelCreditos.Location = new Point(12, 9);
            labelCreditos.Name = "labelCreditos";
            labelCreditos.Size = new Size(240, 57);
            labelCreditos.TabIndex = 5;
            labelCreditos.Text = "REPORTES";
            labelCreditos.Click += labelCreditos_Click;
            // 
            // dgvDetalleAbonos
            // 
            dgvDetalleAbonos.AllowUserToAddRows = false;
            dgvDetalleAbonos.AllowUserToResizeColumns = false;
            dgvDetalleAbonos.AllowUserToResizeRows = false;
            dgvDetalleAbonos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvDetalleAbonos.BackgroundColor = Color.FromArgb(31, 41, 55);
            dgvDetalleAbonos.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(15, 19, 23);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 14F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(15, 19, 23);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvDetalleAbonos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvDetalleAbonos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalleAbonos.Columns.AddRange(new DataGridViewColumn[] { ColFecha, colTipo, colEstado, colTipoPago, colTotal });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(15, 19, 23);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 13F);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvDetalleAbonos.DefaultCellStyle = dataGridViewCellStyle4;
            dgvDetalleAbonos.EnableHeadersVisualStyles = false;
            dgvDetalleAbonos.GridColor = Color.FromArgb(70, 70, 75);
            dgvDetalleAbonos.Location = new Point(12, 168);
            dgvDetalleAbonos.Name = "dgvDetalleAbonos";
            dgvDetalleAbonos.ReadOnly = true;
            dgvDetalleAbonos.RowHeadersVisible = false;
            dgvDetalleAbonos.RowHeadersWidth = 51;
            dgvDetalleAbonos.RowTemplate.Height = 60;
            dgvDetalleAbonos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalleAbonos.Size = new Size(1101, 394);
            dgvDetalleAbonos.TabIndex = 5;
            // 
            // ColFecha
            // 
            ColFecha.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColFecha.HeaderText = "Fecha";
            ColFecha.MinimumWidth = 6;
            ColFecha.Name = "ColFecha";
            ColFecha.ReadOnly = true;
            // 
            // colTipo
            // 
            colTipo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colTipo.HeaderText = "Tipo";
            colTipo.MinimumWidth = 6;
            colTipo.Name = "colTipo";
            colTipo.ReadOnly = true;
            // 
            // colEstado
            // 
            colEstado.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colEstado.HeaderText = "Estado";
            colEstado.MinimumWidth = 6;
            colEstado.Name = "colEstado";
            colEstado.ReadOnly = true;
            // 
            // colTipoPago
            // 
            colTipoPago.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colTipoPago.HeaderText = "Tipo Pago";
            colTipoPago.MinimumWidth = 6;
            colTipoPago.Name = "colTipoPago";
            colTipoPago.ReadOnly = true;
            // 
            // colTotal
            // 
            colTotal.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colTotal.HeaderText = "Total";
            colTotal.MinimumWidth = 6;
            colTotal.Name = "colTotal";
            colTotal.ReadOnly = true;
            // 
            // btnExportarPdf
            // 
            btnExportarPdf.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExportarPdf.BackColor = Color.Red;
            btnExportarPdf.FlatAppearance.BorderColor = Color.Red;
            btnExportarPdf.Font = new Font("Lucida Bright", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportarPdf.ForeColor = SystemColors.ButtonHighlight;
            btnExportarPdf.Location = new Point(1130, 168);
            btnExportarPdf.Name = "btnExportarPdf";
            btnExportarPdf.Size = new Size(157, 65);
            btnExportarPdf.TabIndex = 6;
            btnExportarPdf.Text = "Exportar PDF";
            btnExportarPdf.UseVisualStyleBackColor = false;
            // 
            // btnExportarExcel
            // 
            btnExportarExcel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExportarExcel.BackColor = Color.ForestGreen;
            btnExportarExcel.FlatAppearance.BorderColor = Color.Red;
            btnExportarExcel.Font = new Font("Nirmala Text", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportarExcel.ForeColor = SystemColors.ButtonHighlight;
            btnExportarExcel.Location = new Point(1130, 253);
            btnExportarExcel.Name = "btnExportarExcel";
            btnExportarExcel.Size = new Size(157, 64);
            btnExportarExcel.TabIndex = 7;
            btnExportarExcel.Text = "Exportar Excel";
            btnExportarExcel.UseVisualStyleBackColor = false;
            // 
            // frmReportes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.FromArgb(15, 19, 23);
            ClientSize = new Size(1287, 921);
            ControlBox = false;
            Controls.Add(btnExportarExcel);
            Controls.Add(btnExportarPdf);
            Controls.Add(dgvDetalleAbonos);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmReportes";
            Text = "frmReportes";
            Load += frmReportes_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleAbonos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label labelCreditos;
        private DataGridView dgvDetalleAbonos;
        private DataGridViewTextBoxColumn ColFecha;
        private DataGridViewTextBoxColumn colTipo;
        private DataGridViewTextBoxColumn colEstado;
        private DataGridViewTextBoxColumn colTipoPago;
        private DataGridViewTextBoxColumn colTotal;
        private Button btnExportarPdf;
        private Button btnExportarExcel;
    }
}