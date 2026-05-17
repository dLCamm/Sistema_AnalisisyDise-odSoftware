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
            panel1.BackColor = Color.FromArgb(31, 41, 55);
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
            labelCreditos.Location = new Point(12, 9);
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
            panel2.Location = new Point(22, 120);
            panel2.Name = "panel2";
            panel2.Size = new Size(402, 264);
            panel2.TabIndex = 1;
            // 
            // lblVentasHoy
            // 
            lblVentasHoy.AutoSize = true;
            lblVentasHoy.Font = new Font("Yu Gothic UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVentasHoy.ForeColor = Color.Lime;
            lblVentasHoy.Location = new Point(14, 111);
            lblVentasHoy.Name = "lblVentasHoy";
            lblVentasHoy.Size = new Size(221, 106);
            lblVentasHoy.TabIndex = 2;
            lblVentasHoy.Text = "0000";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(0, 16);
            label1.Name = "label1";
            label1.Size = new Size(342, 41);
            label1.TabIndex = 1;
            label1.Text = "TOTAL DE VENTAS HOY";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.venticon;
            pictureBox1.Location = new Point(344, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(55, 52);
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
            panel3.Location = new Point(445, 120);
            panel3.Name = "panel3";
            panel3.Size = new Size(402, 257);
            panel3.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(342, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(57, 54);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // lblCajaActual
            // 
            lblCajaActual.AutoSize = true;
            lblCajaActual.Font = new Font("Yu Gothic UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCajaActual.ForeColor = Color.Turquoise;
            lblCajaActual.Location = new Point(32, 111);
            lblCajaActual.Name = "lblCajaActual";
            lblCajaActual.Size = new Size(221, 106);
            lblCajaActual.TabIndex = 4;
            lblCajaActual.Text = "0000";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(3, 16);
            label3.Name = "label3";
            label3.Size = new Size(209, 41);
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
            panel4.Location = new Point(866, 120);
            panel4.Name = "panel4";
            panel4.Size = new Size(402, 257);
            panel4.TabIndex = 2;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(342, 5);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(57, 61);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // lblCreditosPendientes
            // 
            lblCreditosPendientes.AutoSize = true;
            lblCreditosPendientes.Font = new Font("Yu Gothic UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreditosPendientes.ForeColor = Color.Gold;
            lblCreditosPendientes.Location = new Point(14, 111);
            lblCreditosPendientes.Name = "lblCreditosPendientes";
            lblCreditosPendientes.Size = new Size(221, 106);
            lblCreditosPendientes.TabIndex = 6;
            lblCreditosPendientes.Text = "0000";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(3, 11);
            label4.Name = "label4";
            label4.Size = new Size(343, 41);
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
            panel5.Location = new Point(1287, 120);
            panel5.Name = "panel5";
            panel5.Size = new Size(431, 257);
            panel5.TabIndex = 2;
            panel5.Paint += panel5_Paint;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(371, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(57, 60);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // lblStockBajo
            // 
            lblStockBajo.AutoSize = true;
            lblStockBajo.Font = new Font("Yu Gothic UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStockBajo.ForeColor = Color.Red;
            lblStockBajo.Location = new Point(13, 111);
            lblStockBajo.Name = "lblStockBajo";
            lblStockBajo.Size = new Size(221, 106);
            lblStockBajo.TabIndex = 8;
            lblStockBajo.Text = "0000";
            lblStockBajo.Click += lblStockBajo_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(13, 11);
            label5.Name = "label5";
            label5.Size = new Size(353, 41);
            label5.TabIndex = 7;
            label5.Text = "PRODUCTOS SIN STOCK";
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 19, 23);
            ClientSize = new Size(1745, 1102);
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
    }
}