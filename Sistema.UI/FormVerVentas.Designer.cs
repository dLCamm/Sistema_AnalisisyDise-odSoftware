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
            clm_Detalle = new DataGridViewButtonColumn();
            clm_anular = new DataGridViewButtonColumn();
            clm_id = new DataGridViewTextBoxColumn();
            label1 = new Label();
            textBox1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.BackColor = SystemColors.ActiveCaption;
            btnVolver.Location = new Point(509, 35);
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { clm_cliente, clm_Tipopago, clm_Fecha, clm_Total, clm_Estado, clm_Detalle, clm_anular, clm_id });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(15, 19, 23);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(70, 70, 75);
            dataGridView1.Location = new Point(1, 86);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1606, 759);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            // clm_Detalle
            // 
            clm_Detalle.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clm_Detalle.FillWeight = 22.4598885F;
            clm_Detalle.HeaderText = "Detalle";
            clm_Detalle.MinimumWidth = 6;
            clm_Detalle.Name = "clm_Detalle";
            clm_Detalle.ReadOnly = true;
            clm_Detalle.Resizable = DataGridViewTriState.True;
            clm_Detalle.SortMode = DataGridViewColumnSortMode.Automatic;
            clm_Detalle.Text = "Ver";
            clm_Detalle.UseColumnTextForButtonValue = true;
            // 
            // clm_anular
            // 
            clm_anular.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clm_anular.FillWeight = 22.4F;
            clm_anular.HeaderText = "Anular Venta";
            clm_anular.MinimumWidth = 6;
            clm_anular.Name = "clm_anular";
            clm_anular.ReadOnly = true;
            clm_anular.Resizable = DataGridViewTriState.True;
            clm_anular.SortMode = DataGridViewColumnSortMode.Automatic;
            clm_anular.Text = "Anular";
            clm_anular.UseColumnTextForButtonValue = true;
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
            label1.Location = new Point(28, 26);
            label1.Name = "label1";
            label1.Size = new Size(475, 57);
            label1.TabIndex = 8;
            label1.Text = "VENTAS REALIZADAS";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(678, 37);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Buscar por Cliente";
            textBox1.Size = new Size(254, 27);
            textBox1.TabIndex = 9;
            textBox1.TextChanged += textchanged_buscador;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(1057, 39);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(134, 27);
            dateTimePicker1.TabIndex = 10;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(1211, 39);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(134, 27);
            dateTimePicker2.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(1057, 16);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 12;
            label2.Text = "Desde";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(1211, 16);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 13;
            label3.Text = "Hasta";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(1362, 36);
            button1.Name = "button1";
            button1.Size = new Size(121, 30);
            button1.TabIndex = 14;
            button1.Text = "Filtrar Fecha";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FormVerVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 19, 23);
            ClientSize = new Size(1608, 846);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(btnVolver);
            Name = "FormVerVentas";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Ver Ventas";
            Load += FormVerVentas_Load;
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
        private DataGridViewTextBoxColumn clm_cliente;
        private DataGridViewTextBoxColumn clm_Tipopago;
        private DataGridViewTextBoxColumn clm_Fecha;
        private DataGridViewTextBoxColumn clm_Total;
        private DataGridViewTextBoxColumn clm_Estado;
        private DataGridViewButtonColumn clm_Detalle;
        private DataGridViewButtonColumn clm_anular;
        private DataGridViewTextBoxColumn clm_id;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label2;
        private Label label3;
        private Button button1;
    }


}