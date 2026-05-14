using System.Drawing;
using System.Windows.Forms;

namespace Sistema.UI
{
    partial class FormVerVentas
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
            btnVolver = new Button();
            dataGridView1 = new DataGridView();
            clm_cliente = new DataGridViewTextBoxColumn();
            clm_Tipopago = new DataGridViewTextBoxColumn();
            clm_Fecha = new DataGridViewTextBoxColumn();
            clm_Total = new DataGridViewTextBoxColumn();
            clm_Estado = new DataGridViewTextBoxColumn();
            clm_id = new DataGridViewTextBoxColumn();
            label1 = new Label();
            textBox1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            button1 = new Button();
            label4 = new Label();
            comboBox1 = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            comboBox2 = new ComboBox();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.BackColor = SystemColors.ActiveCaption;
            btnVolver.Location = new Point(28, 897);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(133, 39);
            btnVolver.TabIndex = 0;
            btnVolver.Text = "Volver a Ventas";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += BtnVolver_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.FromArgb(15, 19, 23);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(15, 19, 23);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(15, 19, 23);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { clm_cliente, clm_Tipopago, clm_Fecha, clm_Total, clm_Estado, clm_id });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(15, 19, 23);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(70, 70, 75);
            dataGridView1.Location = new Point(-3, 119);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1659, 761);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // clm_cliente
            // 
            clm_cliente.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clm_cliente.FillWeight = 22.4598885F;
            clm_cliente.HeaderText = "Cliente";
            clm_cliente.MinimumWidth = 6;
            clm_cliente.Name = "clm_cliente";
            clm_cliente.ReadOnly = true;
            clm_cliente.ToolTipText = "Cliente";
            // 
            // clm_Tipopago
            // 
            clm_Tipopago.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clm_Tipopago.FillWeight = 22.4598885F;
            clm_Tipopago.HeaderText = "Tipo de Pago";
            clm_Tipopago.MinimumWidth = 6;
            clm_Tipopago.Name = "clm_Tipopago";
            clm_Tipopago.ReadOnly = true;
            // 
            // clm_Fecha
            // 
            clm_Fecha.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clm_Fecha.FillWeight = 22.4598885F;
            clm_Fecha.HeaderText = "Fecha";
            clm_Fecha.MinimumWidth = 6;
            clm_Fecha.Name = "clm_Fecha";
            clm_Fecha.ReadOnly = true;
            // 
            // clm_Total
            // 
            clm_Total.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clm_Total.FillWeight = 22.4598885F;
            clm_Total.HeaderText = "Total";
            clm_Total.MinimumWidth = 6;
            clm_Total.Name = "clm_Total";
            clm_Total.ReadOnly = true;
            // 
            // clm_Estado
            // 
            clm_Estado.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clm_Estado.FillWeight = 22.4598885F;
            clm_Estado.HeaderText = "Estado";
            clm_Estado.MinimumWidth = 6;
            clm_Estado.Name = "clm_Estado";
            clm_Estado.ReadOnly = true;
            // 
            // clm_id
            // 
            clm_id.HeaderText = "ID";
            clm_id.MinimumWidth = 6;
            clm_id.Name = "clm_id";
            clm_id.ReadOnly = true;
            clm_id.Visible = false;
            clm_id.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 25F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(28, 34);
            label1.Name = "label1";
            label1.Size = new Size(475, 57);
            label1.TabIndex = 8;
            label1.Text = "VENTAS REALIZADAS";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(538, 50);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Buscar por Cliente";
            textBox1.Size = new Size(237, 27);
            textBox1.TabIndex = 9;
            textBox1.TextChanged += textchanged_buscador;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Checked = false;
            dateTimePicker1.CustomFormat = "";
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(1127, 50);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.ShowCheckBox = true;
            dateTimePicker1.Size = new Size(137, 27);
            dateTimePicker1.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(1127, 27);
            label2.Name = "label2";
            label2.Size = new Size(32, 20);
            label2.TabIndex = 12;
            label2.Text = "Día";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(1275, 47);
            button1.Name = "button1";
            button1.Size = new Size(173, 30);
            button1.TabIndex = 14;
            button1.Text = "Filtrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(15, 19, 23);
            label4.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(1362, 883);
            label4.Name = "label4";
            label4.Size = new Size(231, 20);
            label4.TabIndex = 22;
            label4.Text = "*Presionar 2 veces para ver detalles";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(985, 50);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(136, 28);
            comboBox1.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(985, 26);
            label5.Name = "label5";
            label5.Size = new Size(97, 20);
            label5.TabIndex = 24;
            label5.Text = "Tipo de Pago";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(843, 26);
            label6.Name = "label6";
            label6.Size = new Size(54, 20);
            label6.TabIndex = 26;
            label6.Text = "Estado";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(843, 50);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(136, 28);
            comboBox2.TabIndex = 25;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.Location = new Point(1520, 71);
            button3.Name = "button3";
            button3.Size = new Size(125, 36);
            button3.TabIndex = 28;
            button3.Text = "Limpiar Filtros";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // FormVerVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 19, 23);
            ClientSize = new Size(1657, 974);
            Controls.Add(button3);
            Controls.Add(label6);
            Controls.Add(comboBox2);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(btnVolver);
            Name = "FormVerVentas";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Ver Ventas";
            Resize += FormVerVentas_Resize;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        // Declaración del control para que el diseñador pueda resolverlo
        private System.Windows.Forms.Button btnVolver;

        #endregion

        private DataGridView dataGridView1;

        private Label label1;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Button button1;
        private DataGridViewTextBoxColumn clm_cliente;
        private DataGridViewTextBoxColumn clm_Tipopago;
        private DataGridViewTextBoxColumn clm_Fecha;
        private DataGridViewTextBoxColumn clm_Total;
        private DataGridViewTextBoxColumn clm_Estado;
        private DataGridViewTextBoxColumn clm_id;
        private Label label4;
        private ComboBox comboBox1;
        private Label label5;
        private Label label6;
        private ComboBox comboBox2;
        private Button button3;
    }


}