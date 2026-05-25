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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btnFiltrosrCredito = new Button();
            label1 = new Label();
            txtBuscarCredito = new TextBox();
            labelCreditos = new Label();
            dgvCreditos = new DataGridView();
            menuFiltroscreditos = new ContextMenuStrip(components);
            verTodoToolStripMenuItem = new ToolStripMenuItem();
            pendientesToolStripMenuItem = new ToolStripMenuItem();
            pagadosToolStripMenuItem = new ToolStripMenuItem();
            vencidosToolStripMenuItem = new ToolStripMenuItem();
            canceladosToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCreditos).BeginInit();
            menuFiltroscreditos.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(15, 19, 23);
            panel1.Controls.Add(btnFiltrosrCredito);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtBuscarCredito);
            panel1.Controls.Add(labelCreditos);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1216, 76);
            panel1.TabIndex = 0;
            // 
            // btnFiltrosrCredito
            // 
            btnFiltrosrCredito.Anchor = AnchorStyles.Top;
            btnFiltrosrCredito.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFiltrosrCredito.ImageAlign = ContentAlignment.MiddleLeft;
            btnFiltrosrCredito.Location = new Point(848, 16);
            btnFiltrosrCredito.Name = "btnFiltrosrCredito";
            btnFiltrosrCredito.Size = new Size(116, 39);
            btnFiltrosrCredito.TabIndex = 6;
            btnFiltrosrCredito.Text = "Filtrar ▽";
            btnFiltrosrCredito.UseVisualStyleBackColor = true;
            btnFiltrosrCredito.Click += btnFiltrarCredito_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 16F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(320, 20);
            label1.Name = "label1";
            label1.Size = new Size(52, 35);
            label1.TabIndex = 7;
            label1.Text = "🔎";
            // 
            // txtBuscarCredito
            // 
            txtBuscarCredito.Anchor = AnchorStyles.Top;
            txtBuscarCredito.Font = new Font("Segoe UI", 16F);
            txtBuscarCredito.ForeColor = Color.Black;
            txtBuscarCredito.Location = new Point(378, 16);
            txtBuscarCredito.Name = "txtBuscarCredito";
            txtBuscarCredito.Size = new Size(444, 43);
            txtBuscarCredito.TabIndex = 6;
            txtBuscarCredito.TextChanged += txtBuscarCredito_TextChanged_1;
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
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(15, 19, 23);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvCreditos.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCreditos.Dock = DockStyle.Fill;
            dgvCreditos.GridColor = Color.DimGray;
            dgvCreditos.Location = new Point(0, 76);
            dgvCreditos.Name = "dgvCreditos";
            dgvCreditos.RowHeadersWidth = 51;
            dgvCreditos.Size = new Size(1216, 518);
            dgvCreditos.TabIndex = 1;
            // 
            // menuFiltroscreditos
            // 
            menuFiltroscreditos.ImageScalingSize = new Size(20, 20);
            menuFiltroscreditos.Items.AddRange(new ToolStripItem[] { verTodoToolStripMenuItem, pendientesToolStripMenuItem, pagadosToolStripMenuItem, vencidosToolStripMenuItem, canceladosToolStripMenuItem });
            menuFiltroscreditos.Name = "contextMenuStrip1";
            menuFiltroscreditos.Size = new Size(155, 124);
            // 
            // verTodoToolStripMenuItem
            // 
            verTodoToolStripMenuItem.Name = "verTodoToolStripMenuItem";
            verTodoToolStripMenuItem.Size = new Size(154, 24);
            verTodoToolStripMenuItem.Text = "Ver Todo";
            verTodoToolStripMenuItem.Click += verTodoToolStripMenuItem_Click;
            // 
            // pendientesToolStripMenuItem
            // 
            pendientesToolStripMenuItem.Name = "pendientesToolStripMenuItem";
            pendientesToolStripMenuItem.Size = new Size(154, 24);
            pendientesToolStripMenuItem.Text = "Pendientes";
            pendientesToolStripMenuItem.Click += pendientesToolStripMenuItem_Click;
            // 
            // pagadosToolStripMenuItem
            // 
            pagadosToolStripMenuItem.Name = "pagadosToolStripMenuItem";
            pagadosToolStripMenuItem.Size = new Size(154, 24);
            pagadosToolStripMenuItem.Text = "Pagados";
            pagadosToolStripMenuItem.Click += pagadosToolStripMenuItem_Click;
            // 
            // vencidosToolStripMenuItem
            // 
            vencidosToolStripMenuItem.Name = "vencidosToolStripMenuItem";
            vencidosToolStripMenuItem.Size = new Size(154, 24);
            vencidosToolStripMenuItem.Text = "Vencidos";
            vencidosToolStripMenuItem.Click += vencidosToolStripMenuItem_Click;
            // 
            // canceladosToolStripMenuItem
            // 
            canceladosToolStripMenuItem.Name = "canceladosToolStripMenuItem";
            canceladosToolStripMenuItem.Size = new Size(154, 24);
            canceladosToolStripMenuItem.Text = "Cancelados";
            canceladosToolStripMenuItem.Click += canceladosToolStripMenuItem_Click;
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
            menuFiltroscreditos.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label labelCreditos;
        private TextBox txtBuscarCredito;
        private DataGridView dgvCreditos;
        private Label label1;
        private ContextMenuStrip menuFiltroscreditos;
        private ToolStripMenuItem verTodoToolStripMenuItem;
        private ToolStripMenuItem pendientesToolStripMenuItem;
        private ToolStripMenuItem pagadosToolStripMenuItem;
        private ToolStripMenuItem vencidosToolStripMenuItem;
        private Button btnFiltrosrCredito;
        private ToolStripMenuItem canceladosToolStripMenuItem;
    }
}