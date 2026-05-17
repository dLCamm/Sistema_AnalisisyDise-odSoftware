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
            panel1 = new Panel();
            labelCreditos = new Label();
            btnExportarPdf = new Button();
            btnExportarExcel = new Button();
            btnBuscar = new Button();
            cmbTipoReporte = new ComboBox();
            pnlGraficaVentas = new Panel();
            pnlGraficaProductos = new Panel();
            pnlGraficaCaja = new Panel();
            label1 = new Label();
            lblTotal = new Label();
            pnlReportes = new Panel();
            panel1.SuspendLayout();
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
            // btnExportarPdf
            // 
            btnExportarPdf.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExportarPdf.BackColor = Color.Red;
            btnExportarPdf.FlatAppearance.BorderColor = Color.Red;
            btnExportarPdf.Font = new Font("Lucida Bright", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportarPdf.ForeColor = SystemColors.ButtonHighlight;
            btnExportarPdf.Location = new Point(940, 103);
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
            btnExportarExcel.Location = new Point(1118, 104);
            btnExportarExcel.Name = "btnExportarExcel";
            btnExportarExcel.Size = new Size(157, 64);
            btnExportarExcel.TabIndex = 7;
            btnExportarExcel.Text = "Exportar Excel";
            btnExportarExcel.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.ActiveCaption;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.Black;
            btnBuscar.Location = new Point(194, 113);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(135, 44);
            btnBuscar.TabIndex = 29;
            btnBuscar.Text = "⌕ Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // cmbTipoReporte
            // 
            cmbTipoReporte.FormattingEnabled = true;
            cmbTipoReporte.Location = new Point(12, 129);
            cmbTipoReporte.Name = "cmbTipoReporte";
            cmbTipoReporte.Size = new Size(151, 28);
            cmbTipoReporte.TabIndex = 30;
            // 
            // pnlGraficaVentas
            // 
            pnlGraficaVentas.Location = new Point(12, 804);
            pnlGraficaVentas.Name = "pnlGraficaVentas";
            pnlGraficaVentas.Size = new Size(402, 105);
            pnlGraficaVentas.TabIndex = 32;
            // 
            // pnlGraficaProductos
            // 
            pnlGraficaProductos.Location = new Point(439, 804);
            pnlGraficaProductos.Name = "pnlGraficaProductos";
            pnlGraficaProductos.Size = new Size(392, 105);
            pnlGraficaProductos.TabIndex = 33;
            // 
            // pnlGraficaCaja
            // 
            pnlGraficaCaja.Location = new Point(863, 804);
            pnlGraficaCaja.Name = "pnlGraficaCaja";
            pnlGraficaCaja.Size = new Size(392, 105);
            pnlGraficaCaja.TabIndex = 34;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 686);
            label1.Name = "label1";
            label1.Size = new Size(61, 26);
            label1.TabIndex = 6;
            label1.Text = "Total";
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Right;
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.White;
            lblTotal.Location = new Point(1219, 686);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(56, 26);
            lblTotal.TabIndex = 35;
            lblTotal.Text = "0000";
            // 
            // pnlReportes
            // 
            pnlReportes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlReportes.BackColor = Color.FromArgb(31, 41, 55);
            pnlReportes.Location = new Point(12, 179);
            pnlReportes.Name = "pnlReportes";
            pnlReportes.Size = new Size(1263, 504);
            pnlReportes.TabIndex = 36;
            // 
            // frmReportes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.FromArgb(15, 19, 23);
            ClientSize = new Size(1287, 921);
            ControlBox = false;
            Controls.Add(pnlReportes);
            Controls.Add(lblTotal);
            Controls.Add(label1);
            Controls.Add(pnlGraficaCaja);
            Controls.Add(pnlGraficaProductos);
            Controls.Add(pnlGraficaVentas);
            Controls.Add(cmbTipoReporte);
            Controls.Add(btnBuscar);
            Controls.Add(btnExportarExcel);
            Controls.Add(btnExportarPdf);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmReportes";
            Text = "frmReportes";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label labelCreditos;
        private Button btnExportarPdf;
        private Button btnExportarExcel;
        private Button btnBuscar;
        private ComboBox cmbTipoReporte;
        private Panel pnlGraficaVentas;
        private Panel pnlGraficaProductos;
        private Panel pnlGraficaCaja;
        private Label label1;
        private Label lblTotal;
        private Panel pnlReportes;
    }
}