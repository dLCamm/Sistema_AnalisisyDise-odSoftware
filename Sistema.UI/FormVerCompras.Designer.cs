namespace Sistema.UI
{
    partial class FormVerCompras
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
            dataGridView1 = new DataGridView();
            clm_id = new DataGridViewTextBoxColumn();
            clm_proveedor = new DataGridViewTextBoxColumn();
            clm_Estado = new DataGridViewTextBoxColumn();
            clm_fecha = new DataGridViewTextBoxColumn();
            clm_total = new DataGridViewTextBoxColumn();
            label1 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            button3 = new Button();
            button2 = new Button();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            comboBox2 = new ComboBox();
            label6 = new Label();
            dateTimePicker2 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.FromArgb(15, 19, 23);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(15, 19, 23);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(15, 19, 23);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { clm_id, clm_proveedor, clm_Estado, clm_fecha, clm_total });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(15, 19, 23);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(30, 30, 35);
            dataGridView1.Location = new Point(12, 164);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1779, 794);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // clm_id
            // 
            clm_id.DataPropertyName = "clm_id";
            clm_id.HeaderText = "Id";
            clm_id.MinimumWidth = 6;
            clm_id.Name = "clm_id";
            clm_id.Visible = false;
            clm_id.Width = 125;
            // 
            // clm_proveedor
            // 
            clm_proveedor.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clm_proveedor.DataPropertyName = "clm_proveedor";
            clm_proveedor.HeaderText = "Proveedor";
            clm_proveedor.MinimumWidth = 6;
            clm_proveedor.Name = "clm_proveedor";
            clm_proveedor.ReadOnly = true;
            // 
            // clm_Estado
            // 
            clm_Estado.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clm_Estado.DataPropertyName = "clm_Estado";
            clm_Estado.HeaderText = "Estado";
            clm_Estado.MinimumWidth = 6;
            clm_Estado.Name = "clm_Estado";
            clm_Estado.ReadOnly = true;
            // 
            // clm_fecha
            // 
            clm_fecha.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clm_fecha.DataPropertyName = "clm_fecha";
            clm_fecha.HeaderText = "Fecha";
            clm_fecha.MinimumWidth = 6;
            clm_fecha.Name = "clm_fecha";
            clm_fecha.ReadOnly = true;
            // 
            // clm_total
            // 
            clm_total.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clm_total.DataPropertyName = "clm_total";
            clm_total.HeaderText = "Total ";
            clm_total.MinimumWidth = 6;
            clm_total.Name = "clm_total";
            clm_total.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 25F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(23, 22);
            label1.Name = "label1";
            label1.Size = new Size(518, 57);
            label1.TabIndex = 9;
            label1.Text = "COMPRAS REALIZADAS";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(23, 977);
            button1.Name = "button1";
            button1.Size = new Size(146, 43);
            button1.TabIndex = 10;
            button1.Text = "Volver a Compras";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(556, 44);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Buscar por Proveedor";
            textBox1.Size = new Size(315, 27);
            textBox1.TabIndex = 11;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.BackColor = SystemColors.ActiveCaption;
            button3.Location = new Point(1707, 122);
            button3.Name = "button3";
            button3.Size = new Size(125, 36);
            button3.TabIndex = 32;
            button3.Text = "Limpiar Filtros";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Location = new Point(1491, 47);
            button2.Name = "button2";
            button2.Size = new Size(173, 30);
            button2.TabIndex = 31;
            button2.Text = "Filtrar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(1143, 24);
            label2.Name = "label2";
            label2.Size = new Size(32, 20);
            label2.TabIndex = 30;
            label2.Text = "Día";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Checked = false;
            dateTimePicker1.CustomFormat = "";
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(1143, 47);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.ShowCheckBox = true;
            dateTimePicker1.Size = new Size(137, 27);
            dateTimePicker1.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(15, 19, 23);
            label4.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(1560, 988);
            label4.Name = "label4";
            label4.Size = new Size(231, 20);
            label4.TabIndex = 33;
            label4.Text = "*Presionar 2 veces para ver detalles";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(1001, 46);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(136, 28);
            comboBox2.TabIndex = 34;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(1001, 22);
            label6.Name = "label6";
            label6.Size = new Size(54, 20);
            label6.TabIndex = 35;
            label6.Text = "Estado";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Checked = false;
            dateTimePicker2.CustomFormat = "";
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(1296, 47);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.ShowCheckBox = true;
            dateTimePicker2.Size = new Size(137, 27);
            dateTimePicker2.TabIndex = 36;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // FormVerCompras
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 19, 23);
            ClientSize = new Size(1834, 1048);
            Controls.Add(dateTimePicker2);
            Controls.Add(label6);
            Controls.Add(comboBox2);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "FormVerCompras";
            Text = "FormVerCompras";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Button button1;
        private TextBox textBox1;
        private Button button3;
        private Button button2;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private ComboBox comboBox2;
        private Label label6;
        private DataGridViewTextBoxColumn clm_id;
        private DataGridViewTextBoxColumn clm_proveedor;
        private DataGridViewTextBoxColumn clm_Estado;
        private DataGridViewTextBoxColumn clm_fecha;
        private DataGridViewTextBoxColumn clm_total;
        private DateTimePicker dateTimePicker2;
    }
}