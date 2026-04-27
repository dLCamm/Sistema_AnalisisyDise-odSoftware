namespace Sistema.UI
{
    partial class frmInventario
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            textBox1 = new TextBox();
            btnFiltrar = new Button();
            menuFiltros = new ContextMenuStrip(components);
            verTodoToolStripMenuItem = new ToolStripMenuItem();
            stockBajoToolStripMenuItem = new ToolStripMenuItem();
            sinExistenciasToolStripMenuItem = new ToolStripMenuItem();
            txtBuscar = new TextBox();
            label1 = new Label();
            btnAgregarProducto = new Button();
            dgvProductos = new DataGridView();
            panel1.SuspendLayout();
            menuFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(btnFiltrar);
            panel1.Controls.Add(txtBuscar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnAgregarProducto);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1300, 76);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top;
            textBox1.BackColor = Color.FromArgb(15, 19, 23);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 14F);
            textBox1.ForeColor = SystemColors.Window;
            textBox1.Location = new Point(451, 23);
            textBox1.Margin = new Padding(0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(36, 32);
            textBox1.TabIndex = 5;
            textBox1.Text = "🔎";
            // 
            // btnFiltrar
            // 
            btnFiltrar.Anchor = AnchorStyles.Top;
            btnFiltrar.ContextMenuStrip = menuFiltros;
            btnFiltrar.Font = new Font("Segoe UI", 10F);
            btnFiltrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnFiltrar.Location = new Point(882, 21);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(97, 32);
            btnFiltrar.TabIndex = 5;
            btnFiltrar.Text = "Filtrar ▽";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // menuFiltros
            // 
            menuFiltros.ImageScalingSize = new Size(20, 20);
            menuFiltros.Items.AddRange(new ToolStripItem[] { verTodoToolStripMenuItem, stockBajoToolStripMenuItem, sinExistenciasToolStripMenuItem });
            menuFiltros.Name = "menuFiltros";
            menuFiltros.Size = new Size(174, 76);
            menuFiltros.Opening += menuFiltros_Opening;
            // 
            // verTodoToolStripMenuItem
            // 
            verTodoToolStripMenuItem.Name = "verTodoToolStripMenuItem";
            verTodoToolStripMenuItem.Size = new Size(173, 24);
            verTodoToolStripMenuItem.Text = "Ver Todo";
            verTodoToolStripMenuItem.Click += verTodoToolStripMenuItem_Click;
            // 
            // stockBajoToolStripMenuItem
            // 
            stockBajoToolStripMenuItem.Name = "stockBajoToolStripMenuItem";
            stockBajoToolStripMenuItem.Size = new Size(173, 24);
            stockBajoToolStripMenuItem.Text = "Stock Bajo";
            stockBajoToolStripMenuItem.Click += stockBajoToolStripMenuItem_Click;
            // 
            // sinExistenciasToolStripMenuItem
            // 
            sinExistenciasToolStripMenuItem.Name = "sinExistenciasToolStripMenuItem";
            sinExistenciasToolStripMenuItem.Size = new Size(173, 24);
            sinExistenciasToolStripMenuItem.Text = "Sin Existencias";
            sinExistenciasToolStripMenuItem.Click += sinExistenciasToolStripMenuItem_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Top;
            txtBuscar.Font = new Font("Segoe UI", 12F);
            txtBuscar.Location = new Point(490, 21);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(375, 34);
            txtBuscar.TabIndex = 4;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 25F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(21, 9);
            label1.Name = "label1";
            label1.Size = new Size(286, 57);
            label1.TabIndex = 3;
            label1.Text = "PRODUCTOS";
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAgregarProducto.BackColor = Color.RoyalBlue;
            btnAgregarProducto.Cursor = Cursors.Hand;
            btnAgregarProducto.FlatAppearance.BorderSize = 0;
            btnAgregarProducto.FlatStyle = FlatStyle.Flat;
            btnAgregarProducto.Font = new Font("Segoe UI", 13F);
            btnAgregarProducto.ForeColor = Color.White;
            btnAgregarProducto.Location = new Point(1065, 14);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(213, 39);
            btnAgregarProducto.TabIndex = 0;
            btnAgregarProducto.Text = "+Agregar Producto";
            btnAgregarProducto.UseVisualStyleBackColor = false;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToResizeColumns = false;
            dgvProductos.AllowUserToResizeRows = false;
            dgvProductos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvProductos.BackgroundColor = Color.FromArgb(15, 19, 23);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(15, 19, 23);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(15, 19, 23);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(15, 19, 23);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 13F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvProductos.DefaultCellStyle = dataGridViewCellStyle2;
            dgvProductos.EnableHeadersVisualStyles = false;
            dgvProductos.GridColor = Color.FromArgb(30, 30, 35);
            dgvProductos.Location = new Point(0, 69);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersVisible = false;
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.RowTemplate.Height = 60;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(1300, 919);
            dgvProductos.TabIndex = 3;
            dgvProductos.CellContentClick += dgvProductos_CellContentClick;
            dgvProductos.CellFormatting += dgvProductos_CellFormatting;
            // 
            // frmInventario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 19, 23);
            ClientSize = new Size(1300, 1000);
            Controls.Add(dgvProductos);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmInventario";
            Text = "Form2";
            Load += frmInventario_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuFiltros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
        }

        private void textBuscar_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private Panel panel1;
        private Button btnAgregarProducto;
        private Label label1;
        private DataGridView dgvProductos;
        private ContextMenuStrip menuFiltros;
        private ToolStripMenuItem verTodoToolStripMenuItem;
        private ToolStripMenuItem stockBajoToolStripMenuItem;
        private ToolStripMenuItem sinExistenciasToolStripMenuItem;
        private Button btnFiltrar;
        private TextBox txtBuscar;
        private TextBox textBox1;
    }
}