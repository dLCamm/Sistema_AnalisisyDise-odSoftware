namespace Sistema.UI
{
    partial class FormCaja
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
            label1 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            label8 = new Label();
            panel3 = new Panel();
            label3 = new Label();
            label6 = new Label();
            panel4 = new Panel();
            label7 = new Label();
            label9 = new Label();
            dataGridView1 = new DataGridView();
            folderBrowserDialog1 = new FolderBrowserDialog();
            button1 = new Button();
            label13 = new Label();
            comboBox2 = new ComboBox();
            button2 = new Button();
            label15 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label16 = new Label();
            comboBox1 = new ComboBox();
            label17 = new Label();
            comboBox3 = new ComboBox();
            label18 = new Label();
            clm_id = new DataGridViewTextBoxColumn();
            clm_tipo = new DataGridViewTextBoxColumn();
            clm_monto = new DataGridViewTextBoxColumn();
            clm_origen = new DataGridViewTextBoxColumn();
            clm_descripcion = new DataGridViewTextBoxColumn();
            clm_fecha = new DataGridViewTextBoxColumn();
            clm_estado = new DataGridViewTextBoxColumn();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(99, 60);
            label1.Name = "label1";
            label1.Size = new Size(151, 62);
            label1.TabIndex = 8;
            label1.Text = "CAJA";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(57, 14);
            label4.Name = "label4";
            label4.Size = new Size(323, 67);
            label4.TabIndex = 12;
            label4.Text = "Saldo Actual";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(48, 55, 73);
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(181, 141);
            panel2.Name = "panel2";
            panel2.RightToLeft = RightToLeft.No;
            panel2.Size = new Size(460, 185);
            panel2.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Semibold", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(159, 93);
            label8.Name = "label8";
            label8.Size = new Size(134, 62);
            label8.TabIndex = 12;
            label8.Text = "Q100";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(48, 55, 73);
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(672, 141);
            panel3.Name = "panel3";
            panel3.RightToLeft = RightToLeft.No;
            panel3.Size = new Size(460, 185);
            panel3.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(161, 93);
            label3.Name = "label3";
            label3.Size = new Size(134, 62);
            label3.TabIndex = 12;
            label3.Text = "Q100";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(33, 14);
            label6.Name = "label6";
            label6.Size = new Size(407, 67);
            label6.TabIndex = 12;
            label6.Text = "Ingresos Totales";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(48, 55, 73);
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label9);
            panel4.Location = new Point(1161, 141);
            panel4.Name = "panel4";
            panel4.RightToLeft = RightToLeft.No;
            panel4.Size = new Size(460, 185);
            panel4.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(159, 93);
            label7.Name = "label7";
            label7.Size = new Size(134, 62);
            label7.TabIndex = 12;
            label7.Text = "Q100";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(30, 14);
            label9.Name = "label9";
            label9.Size = new Size(388, 67);
            label9.TabIndex = 12;
            label9.Text = "Egresos Totales";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.FromArgb(15, 19, 23);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(15, 19, 23);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(15, 19, 23);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { clm_id, clm_tipo, clm_monto, clm_origen, clm_descripcion, clm_fecha, clm_estado });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(15, 19, 23);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(2, 8, 2, 8);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(70, 70, 75);
            dataGridView1.Location = new Point(181, 513);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 31;
            dataGridView1.Size = new Size(1440, 188);
            dataGridView1.TabIndex = 15;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(1391, 453);
            button1.Name = "button1";
            button1.Size = new Size(230, 42);
            button1.TabIndex = 16;
            button1.Text = "Nuevo Registro Manual";
            button1.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.White;
            label13.Location = new Point(461, 443);
            label13.Name = "label13";
            label13.Size = new Size(54, 20);
            label13.TabIndex = 40;
            label13.Text = "Origen";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(461, 467);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(136, 28);
            comboBox2.TabIndex = 39;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Font = new Font("Segoe UI Semibold", 9.2F, FontStyle.Bold);
            button2.Location = new Point(751, 467);
            button2.Name = "button2";
            button2.Size = new Size(173, 28);
            button2.TabIndex = 38;
            button2.Text = "Filtrar";
            button2.UseVisualStyleBackColor = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.White;
            label15.Location = new Point(603, 445);
            label15.Name = "label15";
            label15.Size = new Size(47, 20);
            label15.TabIndex = 37;
            label15.Text = "Fecha";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Checked = false;
            dateTimePicker1.CustomFormat = "";
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(603, 468);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.ShowCheckBox = true;
            dateTimePicker1.Size = new Size(137, 27);
            dateTimePicker1.TabIndex = 36;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.White;
            label16.Location = new Point(181, 445);
            label16.Name = "label16";
            label16.Size = new Size(39, 20);
            label16.TabIndex = 42;
            label16.Text = "Tipo";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(181, 467);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(132, 28);
            comboBox1.TabIndex = 41;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.White;
            label17.Location = new Point(319, 443);
            label17.Name = "label17";
            label17.Size = new Size(54, 20);
            label17.TabIndex = 44;
            label17.Text = "Estado";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(319, 467);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(136, 28);
            comboBox3.TabIndex = 43;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Black", 25.2F, FontStyle.Bold);
            label18.ForeColor = Color.White;
            label18.Location = new Point(764, 356);
            label18.Name = "label18";
            label18.Size = new Size(299, 57);
            label18.TabIndex = 45;
            label18.Text = "Movimientos";
            // 
            // clm_id
            // 
            clm_id.HeaderText = "Id";
            clm_id.MinimumWidth = 6;
            clm_id.Name = "clm_id";
            clm_id.ReadOnly = true;
            clm_id.Visible = false;
            // 
            // clm_tipo
            // 
            clm_tipo.HeaderText = "Tipo";
            clm_tipo.MinimumWidth = 6;
            clm_tipo.Name = "clm_tipo";
            clm_tipo.ReadOnly = true;
            // 
            // clm_monto
            // 
            clm_monto.HeaderText = "Monto";
            clm_monto.MinimumWidth = 6;
            clm_monto.Name = "clm_monto";
            clm_monto.ReadOnly = true;
            // 
            // clm_origen
            // 
            clm_origen.HeaderText = "Origen";
            clm_origen.MinimumWidth = 6;
            clm_origen.Name = "clm_origen";
            clm_origen.ReadOnly = true;
            // 
            // clm_descripcion
            // 
            clm_descripcion.HeaderText = "Descripción";
            clm_descripcion.MinimumWidth = 6;
            clm_descripcion.Name = "clm_descripcion";
            clm_descripcion.ReadOnly = true;
            // 
            // clm_fecha
            // 
            clm_fecha.HeaderText = "Fecha";
            clm_fecha.MinimumWidth = 6;
            clm_fecha.Name = "clm_fecha";
            clm_fecha.ReadOnly = true;
            // 
            // clm_estado
            // 
            clm_estado.HeaderText = "Estado";
            clm_estado.MinimumWidth = 6;
            clm_estado.Name = "clm_estado";
            clm_estado.ReadOnly = true;
            // 
            // FormCaja
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(15, 19, 23);
            ClientSize = new Size(1831, 1055);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(comboBox3);
            Controls.Add(label16);
            Controls.Add(comboBox1);
            Controls.Add(label13);
            Controls.Add(comboBox2);
            Controls.Add(button2);
            Controls.Add(label15);
            Controls.Add(dateTimePicker1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label1);
            Name = "FormCaja";
            Text = "FormCaja";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label4;
        private Panel panel2;
        private Label label8;
        private Panel panel3;
        private Label label3;
        private Label label6;
        private Panel panel4;
        private Label label7;
        private Label label9;
        private DataGridView dataGridView1;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button button1;
        private Label label13;
        private ComboBox comboBox2;
        private Button button2;
        private Label label15;
        private DateTimePicker dateTimePicker1;
        private Label label16;
        private ComboBox comboBox1;
        private Label label17;
        private ComboBox comboBox3;
        private Label label18;
        private DataGridViewTextBoxColumn clm_id;
        private DataGridViewTextBoxColumn clm_tipo;
        private DataGridViewTextBoxColumn clm_monto;
        private DataGridViewTextBoxColumn clm_origen;
        private DataGridViewTextBoxColumn clm_descripcion;
        private DataGridViewTextBoxColumn clm_fecha;
        private DataGridViewTextBoxColumn clm_estado;
    }
}