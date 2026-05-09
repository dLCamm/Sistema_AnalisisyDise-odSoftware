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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            clm_nombre = new DataGridViewTextBoxColumn();
            clm_descripcion = new DataGridViewTextBoxColumn();
            dataGridView2 = new DataGridView();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            button3 = new Button();
            button4 = new Button();
            clm_productoname = new DataGridViewTextBoxColumn();
            clm_preciocompra = new DataGridViewTextBoxColumn();
            clm_cantidad = new DataGridViewTextBoxColumn();
            clm_subtotal = new DataGridViewTextBoxColumn();
            clm_btnaumentar = new DataGridViewButtonColumn();
            clm_btndismin = new DataGridViewButtonColumn();
            clm_eliminar = new DataGridViewButtonColumn();
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
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { clm_nombre, clm_descripcion });
            dataGridView1.Location = new Point(28, 155);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(678, 574);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            dataGridView1.KeyDown += dataGridView1_KeyDown;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
            clm_descripcion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clm_descripcion.HeaderText = "Descripción";
            clm_descripcion.MinimumWidth = 6;
            clm_descripcion.Name = "clm_descripcion";
            clm_descripcion.ReadOnly = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { clm_productoname, clm_preciocompra, clm_cantidad, clm_subtotal, clm_btnaumentar, clm_btndismin, clm_eliminar });
            dataGridView2.Location = new Point(737, 155);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(916, 574);
            dataGridView2.TabIndex = 10;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(743, 743);
            label4.Name = "label4";
            label4.Size = new Size(55, 28);
            label4.TabIndex = 13;
            label4.Text = "Total";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(804, 746);
            label5.Name = "label5";
            label5.Size = new Size(63, 25);
            label5.TabIndex = 14;
            label5.Text = "label5";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(743, 788);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(200, 28);
            comboBox1.TabIndex = 15;
            comboBox1.Text = "Proveedor";
            // 
            // button1
            // 
            button1.Location = new Point(963, 788);
            button1.Name = "button1";
            button1.Size = new Size(166, 29);
            button1.TabIndex = 16;
            button1.Text = "Agregar Proveedor";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1496, 124);
            button2.Name = "button2";
            button2.Size = new Size(157, 29);
            button2.TabIndex = 17;
            button2.Text = "Ver Compras";
            button2.UseVisualStyleBackColor = true;
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
            button3.Location = new Point(1072, 833);
            button3.Name = "button3";
            button3.Size = new Size(213, 47);
            button3.TabIndex = 19;
            button3.Text = "Agregar Compra";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(497, 122);
            button4.Name = "button4";
            button4.Size = new Size(209, 28);
            button4.TabIndex = 20;
            button4.Text = "Agregar Producto";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // clm_productoname
            // 
            clm_productoname.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clm_productoname.FillWeight = 33.64486F;
            clm_productoname.HeaderText = "Producto";
            clm_productoname.MinimumWidth = 6;
            clm_productoname.Name = "clm_productoname";
            clm_productoname.ReadOnly = true;
            // 
            // clm_preciocompra
            // 
            clm_preciocompra.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clm_preciocompra.FillWeight = 33.64486F;
            clm_preciocompra.HeaderText = "Precio de Compra";
            clm_preciocompra.MinimumWidth = 6;
            clm_preciocompra.Name = "clm_preciocompra";
            clm_preciocompra.ReadOnly = true;
            // 
            // clm_cantidad
            // 
            clm_cantidad.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clm_cantidad.FillWeight = 33.64486F;
            clm_cantidad.HeaderText = "Cantidad";
            clm_cantidad.MinimumWidth = 6;
            clm_cantidad.Name = "clm_cantidad";
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
            // clm_btnaumentar
            // 
            clm_btnaumentar.HeaderText = "+";
            clm_btnaumentar.MinimumWidth = 6;
            clm_btnaumentar.Name = "clm_btnaumentar";
            clm_btnaumentar.Text = "+";
            clm_btnaumentar.ToolTipText = "+";
            clm_btnaumentar.Width = 60;
            // 
            // clm_btndismin
            // 
            clm_btndismin.HeaderText = "-";
            clm_btndismin.MinimumWidth = 6;
            clm_btndismin.Name = "clm_btndismin";
            clm_btndismin.Text = "-";
            clm_btndismin.Width = 60;
            // 
            // clm_eliminar
            // 
            clm_eliminar.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clm_eliminar.FillWeight = 33.64486F;
            clm_eliminar.HeaderText = "Eliminar";
            clm_eliminar.MinimumWidth = 6;
            clm_eliminar.Name = "clm_eliminar";
            clm_eliminar.Text = "Borrar";
            // 
            // FormCompras
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 19, 23);
            ClientSize = new Size(1688, 947);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(label4);
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
        private Label label4;
        private Label label5;
        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private Button button3;
        private Button button4;
        private DataGridViewTextBoxColumn clm_nombre;
        private DataGridViewTextBoxColumn clm_descripcion;
        private DataGridViewTextBoxColumn clm_productoname;
        private DataGridViewTextBoxColumn clm_preciocompra;
        private DataGridViewTextBoxColumn clm_cantidad;
        private DataGridViewTextBoxColumn clm_subtotal;
        private DataGridViewButtonColumn clm_btnaumentar;
        private DataGridViewButtonColumn clm_btndismin;
        private DataGridViewButtonColumn clm_eliminar;
    }
}