namespace Sistema.UI
{
    partial class frmCréditos
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
            txtBuscarCredito = new TextBox();
            btnNuevoCredito = new Button();
            labelCreditos = new Label();
            dgvCreditos = new DataGridView();
            menuFiltroscreditos = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCreditos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(31, 41, 55);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(menuFiltroscreditos);
            panel1.Controls.Add(txtBuscarCredito);
            panel1.Controls.Add(btnNuevoCredito);
            panel1.Controls.Add(labelCreditos);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1216, 76);
            panel1.TabIndex = 0;
            // 
            // txtBuscarCredito
            // 
            txtBuscarCredito.Anchor = AnchorStyles.Top;
            txtBuscarCredito.Font = new Font("Segoe UI", 12F);
            txtBuscarCredito.ForeColor = Color.Black;
            txtBuscarCredito.Location = new Point(421, 21);
            txtBuscarCredito.Name = "txtBuscarCredito";
            txtBuscarCredito.Size = new Size(375, 34);
            txtBuscarCredito.TabIndex = 6;
            txtBuscarCredito.TextChanged += txtBuscarCredito_TextChanged;
            // 
            // btnNuevoCredito
            // 
            btnNuevoCredito.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNuevoCredito.BackColor = Color.RoyalBlue;
            btnNuevoCredito.Cursor = Cursors.Hand;
            btnNuevoCredito.FlatAppearance.BorderSize = 0;
            btnNuevoCredito.FlatStyle = FlatStyle.Flat;
            btnNuevoCredito.Font = new Font("Segoe UI", 13F);
            btnNuevoCredito.ForeColor = Color.White;
            btnNuevoCredito.Location = new Point(991, 12);
            btnNuevoCredito.Name = "btnNuevoCredito";
            btnNuevoCredito.Size = new Size(213, 46);
            btnNuevoCredito.TabIndex = 5;
            btnNuevoCredito.Text = "+Nuevo Crédito";
            btnNuevoCredito.UseVisualStyleBackColor = false;
            btnNuevoCredito.Click += btnNuevoCredito_Click;
            // 
            // labelCreditos
            // 
            labelCreditos.AutoSize = true;
            labelCreditos.Font = new Font("Segoe UI Black", 25F, FontStyle.Bold);
            labelCreditos.ForeColor = Color.White;
            labelCreditos.Location = new Point(21, 9);
            labelCreditos.Name = "labelCreditos";
            labelCreditos.Size = new Size(233, 57);
            labelCreditos.TabIndex = 4;
            labelCreditos.Text = "CRÉDITOS";
            // 
            // dgvCreditos
            // 
            dgvCreditos.BackgroundColor = Color.FromArgb(15, 19, 23);
            dgvCreditos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCreditos.Dock = DockStyle.Fill;
            dgvCreditos.Location = new Point(0, 76);
            dgvCreditos.Name = "dgvCreditos";
            dgvCreditos.RowHeadersWidth = 51;
            dgvCreditos.Size = new Size(1216, 518);
            dgvCreditos.TabIndex = 1;
            // 
            // menuFiltroscreditos
            // 
            menuFiltroscreditos.Anchor = AnchorStyles.Top;
            menuFiltroscreditos.Font = new Font("Segoe UI", 10F);
            menuFiltroscreditos.ImageAlign = ContentAlignment.MiddleLeft;
            menuFiltroscreditos.Location = new Point(814, 21);
            menuFiltroscreditos.Name = "menuFiltroscreditos";
            menuFiltroscreditos.Size = new Size(97, 32);
            menuFiltroscreditos.TabIndex = 6;
            menuFiltroscreditos.Text = "Filtrar ▽";
            menuFiltroscreditos.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(376, 24);
            label1.Name = "label1";
            label1.Size = new Size(39, 26);
            label1.TabIndex = 7;
            label1.Text = "🔎";
            // 
            // frmCréditos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 19, 23);
            ClientSize = new Size(1216, 594);
            Controls.Add(dgvCreditos);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCréditos";
            Text = "frmCréditos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCreditos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label labelCreditos;
        private Button btnNuevoCredito;
        private TextBox txtBuscarCredito;
        private DataGridView dgvCreditos;
        private Button menuFiltroscreditos;
        private Label label1;
    }
}