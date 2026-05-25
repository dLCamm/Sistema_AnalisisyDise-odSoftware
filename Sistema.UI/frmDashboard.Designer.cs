namespace Sistema.UI
{
    partial class frmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultLegend skDefaultLegend1 = new LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultLegend();
            LiveChartsCore.Drawing.Padding padding1 = new LiveChartsCore.Drawing.Padding();
            LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultTooltip skDefaultTooltip1 = new LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultTooltip();
            LiveChartsCore.Drawing.Padding padding2 = new LiveChartsCore.Drawing.Padding();
            LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultLegend skDefaultLegend2 = new LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultLegend();
            LiveChartsCore.Drawing.Padding padding3 = new LiveChartsCore.Drawing.Padding();
            LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultTooltip skDefaultTooltip2 = new LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultTooltip();
            LiveChartsCore.Drawing.Padding padding4 = new LiveChartsCore.Drawing.Padding();
            LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultLegend skDefaultLegend3 = new LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultLegend();
            LiveChartsCore.Drawing.Padding padding5 = new LiveChartsCore.Drawing.Padding();
            LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultTooltip skDefaultTooltip3 = new LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultTooltip();
            LiveChartsCore.Drawing.Padding padding6 = new LiveChartsCore.Drawing.Padding();
            panel1 = new Panel();
            labelCreditos = new Label();
            panel2 = new Panel();
            lblVentasHoy = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            lblCajaActual = new Label();
            label3 = new Label();
            panel4 = new Panel();
            pictureBox3 = new PictureBox();
            lblCreditosPendientes = new Label();
            label4 = new Label();
            panel5 = new Panel();
            pictureBox4 = new PictureBox();
            lblStockBajo = new Label();
            label5 = new Label();
            cartesianChart1 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            cartesianChart2 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            cartesianChart3 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            label2 = new Label();
            label6 = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(15, 19, 23);
            panel1.Controls.Add(labelCreditos);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1745, 76);
            panel1.TabIndex = 0;
            // 
            // labelCreditos
            // 
            labelCreditos.AutoSize = true;
            labelCreditos.Font = new Font("Segoe UI Black", 25F, FontStyle.Bold);
            labelCreditos.ForeColor = Color.White;
            labelCreditos.Location = new Point(22, 9);
            labelCreditos.Name = "labelCreditos";
            labelCreditos.Size = new Size(162, 57);
            labelCreditos.TabIndex = 5;
            labelCreditos.Text = "INICIO";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top;
            panel2.BackColor = Color.FromArgb(31, 41, 55);
            panel2.Controls.Add(lblVentasHoy);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(43, 97);
            panel2.Name = "panel2";
            panel2.Size = new Size(366, 177);
            panel2.TabIndex = 1;
            // 
            // lblVentasHoy
            // 
            lblVentasHoy.AutoSize = true;
            lblVentasHoy.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVentasHoy.ForeColor = Color.Lime;
            lblVentasHoy.Location = new Point(14, 91);
            lblVentasHoy.Name = "lblVentasHoy";
            lblVentasHoy.Size = new Size(86, 41);
            lblVentasHoy.TabIndex = 2;
            lblVentasHoy.Text = "0000";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(14, 11);
            label1.Name = "label1";
            label1.Size = new Size(227, 28);
            label1.TabIndex = 1;
            label1.Text = "TOTAL DE VENTAS HOY";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.venticon;
            pictureBox1.Location = new Point(261, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top;
            panel3.BackColor = Color.FromArgb(31, 41, 55);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(lblCajaActual);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(466, 94);
            panel3.Name = "panel3";
            panel3.Size = new Size(366, 177);
            panel3.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(211, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(42, 39);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // lblCajaActual
            // 
            lblCajaActual.AutoSize = true;
            lblCajaActual.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCajaActual.ForeColor = Color.Turquoise;
            lblCajaActual.Location = new Point(15, 91);
            lblCajaActual.Name = "lblCajaActual";
            lblCajaActual.Size = new Size(86, 41);
            lblCajaActual.TabIndex = 4;
            lblCajaActual.Text = "0000";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(15, 11);
            label3.Name = "label3";
            label3.Size = new Size(137, 28);
            label3.TabIndex = 3;
            label3.Text = "CAJA ACTUAL";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top;
            panel4.BackColor = Color.FromArgb(31, 41, 55);
            panel4.Controls.Add(pictureBox3);
            panel4.Controls.Add(lblCreditosPendientes);
            panel4.Controls.Add(label4);
            panel4.Cursor = Cursors.Hand;
            panel4.Location = new Point(889, 94);
            panel4.Name = "panel4";
            panel4.Size = new Size(366, 177);
            panel4.TabIndex = 2;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(284, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(42, 41);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // lblCreditosPendientes
            // 
            lblCreditosPendientes.AutoSize = true;
            lblCreditosPendientes.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreditosPendientes.ForeColor = Color.Gold;
            lblCreditosPendientes.Location = new Point(12, 91);
            lblCreditosPendientes.Name = "lblCreditosPendientes";
            lblCreditosPendientes.Size = new Size(86, 41);
            lblCreditosPendientes.TabIndex = 6;
            lblCreditosPendientes.Text = "0000";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(12, 11);
            label4.Name = "label4";
            label4.Size = new Size(223, 28);
            label4.TabIndex = 5;
            label4.Text = "CRÉDITOS PENDIENTES";
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top;
            panel5.BackColor = Color.FromArgb(31, 41, 55);
            panel5.Controls.Add(pictureBox4);
            panel5.Controls.Add(lblStockBajo);
            panel5.Controls.Add(label5);
            panel5.Cursor = Cursors.Hand;
            panel5.Location = new Point(1315, 94);
            panel5.Name = "panel5";
            panel5.Size = new Size(366, 177);
            panel5.TabIndex = 2;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(308, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(43, 44);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // lblStockBajo
            // 
            lblStockBajo.AutoSize = true;
            lblStockBajo.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStockBajo.ForeColor = Color.Red;
            lblStockBajo.Location = new Point(13, 91);
            lblStockBajo.Name = "lblStockBajo";
            lblStockBajo.Size = new Size(86, 41);
            lblStockBajo.TabIndex = 8;
            lblStockBajo.Text = "0000";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(13, 11);
            label5.Name = "label5";
            label5.Size = new Size(289, 28);
            label5.TabIndex = 7;
            label5.Text = "PRODUCTOS SIN EXISTENCIAS";
            // 
            // cartesianChart1
            // 
            cartesianChart1.AutoUpdateEnabled = true;
            cartesianChart1.BackColor = Color.FromArgb(15, 19, 23);
            cartesianChart1.BorderStyle = BorderStyle.FixedSingle;
            cartesianChart1.ChartTheme = null;
            skDefaultLegend1.AnimationsSpeed = TimeSpan.Parse("00:00:00.1500000");
            skDefaultLegend1.Content = null;
            skDefaultLegend1.IsValid = false;
            skDefaultLegend1.Opacity = 1F;
            padding1.Bottom = 0F;
            padding1.Left = 0F;
            padding1.Right = 0F;
            padding1.Top = 0F;
            skDefaultLegend1.Padding = padding1;
            skDefaultLegend1.RemoveOnCompleted = false;
            skDefaultLegend1.RotateTransform = 0F;
            skDefaultLegend1.X = 0F;
            skDefaultLegend1.Y = 0F;
            cartesianChart1.Legend = skDefaultLegend1;
            cartesianChart1.Location = new Point(22, 524);
            cartesianChart1.MatchAxesScreenDataRatio = false;
            cartesianChart1.Name = "cartesianChart1";
            cartesianChart1.Size = new Size(510, 430);
            cartesianChart1.TabIndex = 5;
            skDefaultTooltip1.AnimationsSpeed = TimeSpan.Parse("00:00:00.1500000");
            skDefaultTooltip1.Content = null;
            skDefaultTooltip1.IsValid = false;
            skDefaultTooltip1.Opacity = 1F;
            padding2.Bottom = 0F;
            padding2.Left = 0F;
            padding2.Right = 0F;
            padding2.Top = 0F;
            skDefaultTooltip1.Padding = padding2;
            skDefaultTooltip1.RemoveOnCompleted = false;
            skDefaultTooltip1.RotateTransform = 0F;
            skDefaultTooltip1.Wedge = 10;
            skDefaultTooltip1.X = 0F;
            skDefaultTooltip1.Y = 0F;
            cartesianChart1.Tooltip = skDefaultTooltip1;
            cartesianChart1.TooltipFindingStrategy = LiveChartsCore.Measure.TooltipFindingStrategy.Automatic;
            cartesianChart1.UpdaterThrottler = TimeSpan.Parse("00:00:00.0500000");
            // 
            // cartesianChart2
            // 
            cartesianChart2.AutoUpdateEnabled = true;
            cartesianChart2.BackColor = Color.FromArgb(15, 19, 23);
            cartesianChart2.BorderStyle = BorderStyle.FixedSingle;
            cartesianChart2.ChartTheme = null;
            skDefaultLegend2.AnimationsSpeed = TimeSpan.Parse("00:00:00.1500000");
            skDefaultLegend2.Content = null;
            skDefaultLegend2.IsValid = false;
            skDefaultLegend2.Opacity = 1F;
            padding3.Bottom = 0F;
            padding3.Left = 0F;
            padding3.Right = 0F;
            padding3.Top = 0F;
            skDefaultLegend2.Padding = padding3;
            skDefaultLegend2.RemoveOnCompleted = false;
            skDefaultLegend2.RotateTransform = 0F;
            skDefaultLegend2.X = 0F;
            skDefaultLegend2.Y = 0F;
            cartesianChart2.Legend = skDefaultLegend2;
            cartesianChart2.Location = new Point(572, 524);
            cartesianChart2.MatchAxesScreenDataRatio = false;
            cartesianChart2.Name = "cartesianChart2";
            cartesianChart2.Size = new Size(510, 430);
            cartesianChart2.TabIndex = 6;
            skDefaultTooltip2.AnimationsSpeed = TimeSpan.Parse("00:00:00.1500000");
            skDefaultTooltip2.Content = null;
            skDefaultTooltip2.IsValid = false;
            skDefaultTooltip2.Opacity = 1F;
            padding4.Bottom = 0F;
            padding4.Left = 0F;
            padding4.Right = 0F;
            padding4.Top = 0F;
            skDefaultTooltip2.Padding = padding4;
            skDefaultTooltip2.RemoveOnCompleted = false;
            skDefaultTooltip2.RotateTransform = 0F;
            skDefaultTooltip2.Wedge = 10;
            skDefaultTooltip2.X = 0F;
            skDefaultTooltip2.Y = 0F;
            cartesianChart2.Tooltip = skDefaultTooltip2;
            cartesianChart2.TooltipFindingStrategy = LiveChartsCore.Measure.TooltipFindingStrategy.Automatic;
            cartesianChart2.UpdaterThrottler = TimeSpan.Parse("00:00:00.0500000");
            // 
            // cartesianChart3
            // 
            cartesianChart3.AutoUpdateEnabled = true;
            cartesianChart3.BackColor = Color.FromArgb(15, 19, 23);
            cartesianChart3.BorderStyle = BorderStyle.FixedSingle;
            cartesianChart3.ChartTheme = null;
            skDefaultLegend3.AnimationsSpeed = TimeSpan.Parse("00:00:00.1500000");
            skDefaultLegend3.Content = null;
            skDefaultLegend3.IsValid = false;
            skDefaultLegend3.Opacity = 1F;
            padding5.Bottom = 0F;
            padding5.Left = 0F;
            padding5.Right = 0F;
            padding5.Top = 0F;
            skDefaultLegend3.Padding = padding5;
            skDefaultLegend3.RemoveOnCompleted = false;
            skDefaultLegend3.RotateTransform = 0F;
            skDefaultLegend3.X = 0F;
            skDefaultLegend3.Y = 0F;
            cartesianChart3.Legend = skDefaultLegend3;
            cartesianChart3.Location = new Point(1124, 524);
            cartesianChart3.MatchAxesScreenDataRatio = false;
            cartesianChart3.Name = "cartesianChart3";
            cartesianChart3.Size = new Size(536, 430);
            cartesianChart3.TabIndex = 7;
            skDefaultTooltip3.AnimationsSpeed = TimeSpan.Parse("00:00:00.1500000");
            skDefaultTooltip3.Content = null;
            skDefaultTooltip3.IsValid = false;
            skDefaultTooltip3.Opacity = 1F;
            padding6.Bottom = 0F;
            padding6.Left = 0F;
            padding6.Right = 0F;
            padding6.Top = 0F;
            skDefaultTooltip3.Padding = padding6;
            skDefaultTooltip3.RemoveOnCompleted = false;
            skDefaultTooltip3.RotateTransform = 0F;
            skDefaultTooltip3.Wedge = 10;
            skDefaultTooltip3.X = 0F;
            skDefaultTooltip3.Y = 0F;
            cartesianChart3.Tooltip = skDefaultTooltip3;
            cartesianChart3.TooltipFindingStrategy = LiveChartsCore.Measure.TooltipFindingStrategy.Automatic;
            cartesianChart3.UpdaterThrottler = TimeSpan.Parse("00:00:00.0500000");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(201, 468);
            label2.Name = "label2";
            label2.Size = new Size(168, 28);
            label2.TabIndex = 8;
            label2.Text = "VENTAS POR DÍA";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(696, 468);
            label6.Name = "label6";
            label6.Size = new Size(280, 28);
            label6.TabIndex = 9;
            label6.Text = "PRODUCTOS MÁS VENDIDOS";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(1286, 468);
            label7.Name = "label7";
            label7.Size = new Size(230, 28);
            label7.TabIndex = 10;
            label7.Text = "INGRESOS VS. EGRESOS";
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 19, 23);
            ClientSize = new Size(1745, 996);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(cartesianChart3);
            Controls.Add(cartesianChart2);
            Controls.Add(cartesianChart1);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmDashboard";
            Text = "frmDashboard";
            Load += frmDashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label labelCreditos;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label label1;
        private PictureBox pictureBox1;
        private Label lblVentasHoy;
        private Label lblCajaActual;
        private Label label3;
        private Label lblCreditosPendientes;
        private Label label4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label lblStockBajo;
        private Label label5;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart1;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart2;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart3;
        private Label label2;
        private Label label6;
        private Label label7;
    }
}