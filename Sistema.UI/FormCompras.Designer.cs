namespace Sistema.UI
{
    partial class FormCompras
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            clm_nombre = new DataGridViewTextBoxColumn();
            clm_descripcion = new DataGridViewTextBoxColumn();
            clm_proveedor = new DataGridViewTextBoxColumn();
            dataGridView2 = new DataGridView();
            clm_productoname = new DataGridViewTextBoxColumn();
            clm_preciocompra = new DataGridViewTextBoxColumn();
            clm_cantidad = new DataGridViewTextBoxColumn();
            clm_subtotal = new DataGridViewTextBoxColumn();
            clm_btndismin = new DataGridViewButtonColumn();
            clm_btnaumentar = new DataGridViewButtonColumn();
            clm_eliminar = new DataGridViewButtonColumn();
            label2 = new Label();
            label5 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            button3 = new Button();
            button4 = new Button();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 25F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(28, 37);
            label1.Name = "label1";
            label1.Size = new Size(237, 57);
            label1.TabIndex = 8;
            label1.Text = "COMPRAS";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.FromArgb(15, 19, 23);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(15, 19, 23);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(15, 19, 23);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { clm_nombre, clm_descripcion, clm_proveedor });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(15, 19, 23);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(5, 10, 5, 10);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(30, 30, 35);
            dataGridView1.Location = new Point(28, 155);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(678, 627);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            dataGridView1.KeyDown += dataGridView1_KeyDown;
            // 
            // clm_nombre
            // 
            clm_nombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clm_nombre.HeaderText = "Nombre";
            clm_nombre.MinimumWidth = 6;
            clm_nombre.Name = "clm_nombre";
            clm_nombre.ReadOnly = true;
            // 
            // clm_descripcion
            // 
            clm_descripcion.HeaderText = "Descripción";
            clm_descripcion.MinimumWidth = 6;
            clm_descripcion.Name = "clm_descripcion";
            clm_descripcion.ReadOnly = true;
            clm_descripcion.Width = 400;
            // 
            // clm_proveedor
            // 
            clm_proveedor.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clm_proveedor.HeaderText = "Proveedor";
            clm_proveedor.MinimumWidth = 6;
            clm_proveedor.Name = "clm_proveedor";
            clm_proveedor.ReadOnly = true;
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView2.BackgroundColor = Color.FromArgb(15, 19, 23);
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(15, 19, 23);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(15, 19, 23);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { clm_productoname, clm_preciocompra, clm_cantidad, clm_subtotal, clm_btndismin, clm_btnaumentar, clm_eliminar });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(15, 19, 23);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.Padding = new Padding(5);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.GridColor = Color.FromArgb(30, 30, 35);
            dataGridView2.Location = new Point(737, 155);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(916, 627);
            dataGridView2.TabIndex = 10;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            dataGridView2.CellEndEdit += dataGridView2_CellEndEdit;
            // 
            // clm_productoname
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            clm_productoname.DefaultCellStyle = dataGridViewCellStyle4;
            clm_productoname.FillWeight = 33.64486F;
            clm_productoname.HeaderText = "Producto";
            clm_productoname.MinimumWidth = 6;
            clm_productoname.Name = "clm_productoname";
            clm_productoname.ReadOnly = true;
            clm_productoname.Width = 300;
            // 
            // clm_preciocompra
            // 
            clm_preciocompra.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clm_preciocompra.FillWeight = 33.64486F;
            clm_preciocompra.HeaderText = "Precio de Compra";
            clm_preciocompra.MinimumWidth = 6;
            clm_preciocompra.Name = "clm_preciocompra";
            // 
            // clm_cantidad
            // 
            clm_cantidad.FillWeight = 33.64486F;
            clm_cantidad.HeaderText = "Cantidad";
            clm_cantidad.MinimumWidth = 6;
            clm_cantidad.Name = "clm_cantidad";
            clm_cantidad.Width = 125;
            // 
            // clm_subtotal
            // 
            clm_subtotal.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clm_subtotal.FillWeight = 33.64486F;
            clm_subtotal.HeaderText = "Subtotal";
            clm_subtotal.MinimumWidth = 6;
            clm_subtotal.Name = "clm_subtotal";
            clm_subtotal.ReadOnly = true;
            // 
            // clm_btndismin
            // 
            clm_btndismin.HeaderText = "";
            clm_btndismin.MinimumWidth = 6;
            clm_btndismin.Name = "clm_btndismin";
            clm_btndismin.Text = "-";
            clm_btndismin.UseColumnTextForButtonValue = true;
            clm_btndismin.Width = 50;
            // 
            // clm_btnaumentar
            // 
            clm_btnaumentar.HeaderText = "";
            clm_btnaumentar.MinimumWidth = 6;
            clm_btnaumentar.Name = "clm_btnaumentar";
            clm_btnaumentar.Text = "+";
            clm_btnaumentar.UseColumnTextForButtonValue = true;
            clm_btnaumentar.Width = 50;
            // 
            // clm_eliminar
            // 
            clm_eliminar.FillWeight = 33.64486F;
            clm_eliminar.HeaderText = "Eliminar";
            clm_eliminar.MinimumWidth = 6;
            clm_eliminar.Name = "clm_eliminar";
            clm_eliminar.Text = "Borrar";
            clm_eliminar.UseColumnTextForButtonValue = true;
            clm_eliminar.Width = 125;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(15, 19, 23);
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(737, 118);
            label2.Name = "label2";
            label2.Size = new Size(187, 28);
            label2.TabIndex = 11;
            label2.Text = "Carrito de Compras";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaption;
            label5.Font = new Font("Segoe UI", 15.8F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(739, 801);
            label5.Name = "label5";
            label5.Size = new Size(82, 37);
            label5.TabIndex = 14;
            label5.Text = "Total";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 11F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(444, 116);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(262, 33);
            comboBox1.TabIndex = 15;
            comboBox1.Text = "Proveedor";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(1487, 113);
            button1.Name = "button1";
            button1.Size = new Size(166, 33);
            button1.TabIndex = 16;
            button1.Text = "Agregar Proveedor";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(1519, 900);
            button2.Name = "button2";
            button2.Size = new Size(157, 35);
            button2.TabIndex = 17;
            button2.Text = "Ver Compras";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(28, 122);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Buscar Productos";
            textBox1.Size = new Size(364, 27);
            textBox1.TabIndex = 18;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(1068, 886);
            button3.Name = "button3";
            button3.Size = new Size(213, 47);
            button3.TabIndex = 19;
            button3.Text = "Agregar Compra";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaption;
            button4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(28, 795);
            button4.Name = "button4";
            button4.Size = new Size(209, 32);
            button4.TabIndex = 20;
            button4.Text = "Agregar Producto";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(15, 19, 23);
            label3.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(1442, 801);
            label3.Name = "label3";
            label3.Size = new Size(211, 20);
            label3.TabIndex = 21;
            label3.Text = "*El Precio de compra es editable";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(15, 19, 23);
            label4.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(444, 93);
            label4.Name = "label4";
            label4.Size = new Size(137, 20);
            label4.TabIndex = 22;
            label4.Text = "Filtrar por proveedor";
            // 
            // FormCompras
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 19, 23);
            ClientSize = new Size(1688, 947);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "FormCompras";
            Text = "FormCompras";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Label label2;
        private Label label5;
        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private Button button3;
        private Button button4;
        private Label label3;
        private DataGridViewTextBoxColumn clm_productoname;
        private DataGridViewTextBoxColumn clm_preciocompra;
        private DataGridViewTextBoxColumn clm_cantidad;
        private DataGridViewTextBoxColumn clm_subtotal;
        private DataGridViewButtonColumn clm_btndismin;
        private DataGridViewButtonColumn clm_btnaumentar;
        private DataGridViewButtonColumn clm_eliminar;
        private DataGridViewTextBoxColumn clm_nombre;
        private DataGridViewTextBoxColumn clm_descripcion;
        private DataGridViewTextBoxColumn clm_proveedor;
        private Label label4;
    }
}