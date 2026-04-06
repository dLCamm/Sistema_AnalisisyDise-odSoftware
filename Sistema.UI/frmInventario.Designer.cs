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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            btnBuscar = new Button();
            btnAgregarProducto = new Button();
            textBox1 = new TextBox();
            dgvProductos = new DataGridView();
            colNombre = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colStock = new DataGridViewTextBoxColumn();
            colAccion = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnBuscar);
            panel1.Controls.Add(btnAgregarProducto);
            panel1.Controls.Add(textBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1300, 76);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
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
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(666, 14);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(40, 41);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "🔍";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
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
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox1.BackColor = SystemColors.ButtonFace;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 13F);
            textBox1.Location = new Point(712, 18);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(329, 29);
            textBox1.TabIndex = 2;
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToResizeColumns = false;
            dgvProductos.AllowUserToResizeRows = false;
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
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { colNombre, colStatus, colStock, colAccion });
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
            // colNombre
            // 
            colNombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colNombre.HeaderText = "Nombre";
            colNombre.MinimumWidth = 6;
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            colNombre.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colStatus
            // 
            colStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 6;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            colStatus.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colStock
            // 
            colStock.HeaderText = "Stock";
            colStock.MinimumWidth = 6;
            colStock.Name = "colStock";
            colStock.ReadOnly = true;
            colStock.SortMode = DataGridViewColumnSortMode.NotSortable;
            colStock.Width = 125;
            // 
            // colAccion
            // 
            colAccion.HeaderText = "Actualizar";
            colAccion.MinimumWidth = 6;
            colAccion.Name = "colAccion";
            colAccion.ReadOnly = true;
            colAccion.SortMode = DataGridViewColumnSortMode.NotSortable;
            colAccion.Width = 125;
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
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button btnAgregarProducto;
        private Button btnBuscar;
        private TextBox textBox1;
        private Label label1;
        private DataGridView dgvProductos;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewTextBoxColumn colStock;
        private DataGridViewTextBoxColumn colAccion;
    }
}