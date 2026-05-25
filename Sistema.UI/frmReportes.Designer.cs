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
            label1 = new Label();
            lblTotal = new Label();
            pnlReportes = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(15, 19, 23);
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
            btnExportarPdf.Click += btnExportarPdf_Click_1;
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
            btnExportarExcel.Click += btnExportarExcel_Click_1;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.ActiveCaption;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.Black;
            btnBuscar.Location = new Point(271, 115);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(175, 44);
            btnBuscar.TabIndex = 29;
            btnBuscar.Text = "Generar Reporte";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // cmbTipoReporte
            // 
            cmbTipoReporte.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbTipoReporte.FormattingEnabled = true;
            cmbTipoReporte.Location = new Point(24, 115);
            cmbTipoReporte.Name = "cmbTipoReporte";
            cmbTipoReporte.Size = new Size(206, 39);
            cmbTipoReporte.TabIndex = 30;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 860);
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
            lblTotal.Location = new Point(1219, 860);
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
            pnlReportes.Size = new Size(1263, 657);
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
        private Label label1;
        private Label lblTotal;
        private Panel pnlReportes;
    }
}