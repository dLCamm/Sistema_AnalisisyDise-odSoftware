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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            labelCreditos = new Label();
            dgvResultados = new DataGridView();
            btnExportarPdf = new Button();
            btnExportarExcel = new Button();
            dtpInicio = new DateTimePicker();
            dtpFin = new DateTimePicker();
            btnBuscar = new Button();
            cmbTipoReporte = new ComboBox();
            pnlGraficaVentas = new Panel();
            pnlGraficaProductos = new Panel();
            pnlGraficaCaja = new Panel();
            label1 = new Label();
            lblTotal = new Label();
            cmbEstadoFiltro = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).BeginInit();
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
            // 
            // dgvResultados
            // 
            dgvResultados.AllowUserToAddRows = false;
            dgvResultados.AllowUserToResizeColumns = false;
            dgvResultados.AllowUserToResizeRows = false;
            dgvResultados.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvResultados.BackgroundColor = Color.FromArgb(31, 41, 55);
            dgvResultados.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(15, 19, 23);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(15, 19, 23);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvResultados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(15, 19, 23);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 13F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvResultados.DefaultCellStyle = dataGridViewCellStyle2;
            dgvResultados.EnableHeadersVisualStyles = false;
            dgvResultados.GridColor = Color.FromArgb(70, 70, 75);
            dgvResultados.Location = new Point(12, 168);
            dgvResultados.Name = "dgvResultados";
            dgvResultados.ReadOnly = true;
            dgvResultados.RowHeadersVisible = false;
            dgvResultados.RowHeadersWidth = 51;
            dgvResultados.RowTemplate.Height = 60;
            dgvResultados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvResultados.Size = new Size(1101, 394);
            dgvResultados.TabIndex = 5;
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
            btnExportarPdf.Click += btnExportarPdf_Click_1;
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
            btnExportarExcel.Click += btnExportarExcel_Click_1;
            // 
            // dtpInicio
            // 
            dtpInicio.Location = new Point(12, 111);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.Size = new Size(292, 27);
            dtpInicio.TabIndex = 8;
            // 
            // dtpFin
            // 
            dtpFin.Location = new Point(351, 111);
            dtpFin.Name = "dtpFin";
            dtpFin.Size = new Size(290, 27);
            dtpFin.TabIndex = 9;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.ActiveCaption;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.Black;
            btnBuscar.Location = new Point(1097, 105);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(127, 39);
            btnBuscar.TabIndex = 29;
            btnBuscar.Text = "⌕ Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // cmbTipoReporte
            // 
            cmbTipoReporte.FormattingEnabled = true;
            cmbTipoReporte.Location = new Point(680, 114);
            cmbTipoReporte.Name = "cmbTipoReporte";
            cmbTipoReporte.Size = new Size(151, 28);
            cmbTipoReporte.TabIndex = 30;
            cmbTipoReporte.SelectedIndexChanged += cmbTipoReporte_SelectedIndexChanged;
            // 
            // pnlGraficaVentas
            // 
            pnlGraficaVentas.Location = new Point(12, 630);
            pnlGraficaVentas.Name = "pnlGraficaVentas";
            pnlGraficaVentas.Size = new Size(402, 279);
            pnlGraficaVentas.TabIndex = 32;
            // 
            // pnlGraficaProductos
            // 
            pnlGraficaProductos.Location = new Point(439, 627);
            pnlGraficaProductos.Name = "pnlGraficaProductos";
            pnlGraficaProductos.Size = new Size(392, 282);
            pnlGraficaProductos.TabIndex = 33;
            // 
            // pnlGraficaCaja
            // 
            pnlGraficaCaja.Location = new Point(863, 627);
            pnlGraficaCaja.Name = "pnlGraficaCaja";
            pnlGraficaCaja.Size = new Size(392, 282);
            pnlGraficaCaja.TabIndex = 34;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 565);
            label1.Name = "label1";
            label1.Size = new Size(61, 26);
            label1.TabIndex = 6;
            label1.Text = "Total";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.White;
            lblTotal.Location = new Point(1057, 565);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(56, 26);
            lblTotal.TabIndex = 35;
            lblTotal.Text = "0000";
            // 
            // cmbEstadoFiltro
            // 
            cmbEstadoFiltro.FormattingEnabled = true;
            cmbEstadoFiltro.Location = new Point(852, 113);
            cmbEstadoFiltro.Name = "cmbEstadoFiltro";
            cmbEstadoFiltro.Size = new Size(151, 28);
            cmbEstadoFiltro.TabIndex = 36;
            // 
            // frmReportes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.FromArgb(15, 19, 23);
            ClientSize = new Size(1287, 921);
            ControlBox = false;
            Controls.Add(cmbEstadoFiltro);
            Controls.Add(lblTotal);
            Controls.Add(label1);
            Controls.Add(pnlGraficaCaja);
            Controls.Add(pnlGraficaProductos);
            Controls.Add(pnlGraficaVentas);
            Controls.Add(cmbTipoReporte);
            Controls.Add(btnBuscar);
            Controls.Add(dtpFin);
            Controls.Add(dtpInicio);
            Controls.Add(btnExportarExcel);
            Controls.Add(btnExportarPdf);
            Controls.Add(dgvResultados);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmReportes";
            Text = "frmReportes";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label labelCreditos;
        private DataGridView dgvResultados;
        private Button btnExportarPdf;
        private Button btnExportarExcel;
        private DateTimePicker dtpInicio;
        private DateTimePicker dtpFin;
        private Button btnBuscar;
        private ComboBox cmbTipoReporte;
        private Panel pnlGraficaVentas;
        private Panel pnlGraficaProductos;
        private Panel pnlGraficaCaja;
        private Label label1;
        private Label lblTotal;
        private ComboBox cmbEstadoFiltro;
    }
}