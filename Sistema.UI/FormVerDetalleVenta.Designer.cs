namespace Sistema.UI
{
    partial class FormVerDetalleVenta
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
            clm_Producto = new DataGridViewTextBoxColumn();
            clm_Cantidad = new DataGridViewTextBoxColumn();
            clm_PrecioUnitario = new DataGridViewTextBoxColumn();
            clm_Subtotal = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(15, 19, 23);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(15, 19, 23);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(15, 19, 23);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { clm_Producto, clm_Cantidad, clm_PrecioUnitario, clm_Subtotal });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(15, 19, 23);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(30, 30, 35);
            dataGridView1.Location = new Point(62, 80);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(658, 312);
            dataGridView1.TabIndex = 0;
            // 
            // clm_Producto
            // 
            clm_Producto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clm_Producto.HeaderText = "Producto";
            clm_Producto.MinimumWidth = 6;
            clm_Producto.Name = "clm_Producto";
            clm_Producto.ReadOnly = true;
            // 
            // clm_Cantidad
            // 
            clm_Cantidad.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clm_Cantidad.HeaderText = "Cantidad";
            clm_Cantidad.MinimumWidth = 6;
            clm_Cantidad.Name = "clm_Cantidad";
            clm_Cantidad.ReadOnly = true;
            // 
            // clm_PrecioUnitario
            // 
            clm_PrecioUnitario.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clm_PrecioUnitario.HeaderText = "Precio Unitario";
            clm_PrecioUnitario.MinimumWidth = 6;
            clm_PrecioUnitario.Name = "clm_PrecioUnitario";
            clm_PrecioUnitario.ReadOnly = true;
            // 
            // clm_Subtotal
            // 
            clm_Subtotal.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clm_Subtotal.HeaderText = "Subtotal";
            clm_Subtotal.MinimumWidth = 6;
            clm_Subtotal.Name = "clm_Subtotal";
            clm_Subtotal.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(62, 15);
            label1.Name = "label1";
            label1.Size = new Size(80, 31);
            label1.TabIndex = 2;
            label1.Text = "Fecha:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(553, 46);
            label2.Name = "label2";
            label2.Size = new Size(71, 31);
            label2.TabIndex = 3;
            label2.Text = "Total:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(62, 46);
            label3.Name = "label3";
            label3.Size = new Size(91, 31);
            label3.TabIndex = 4;
            label3.Text = "Cliente:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(534, 15);
            label4.Name = "label4";
            label4.Size = new Size(90, 31);
            label4.TabIndex = 5;
            label4.Text = "Estado:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(148, 15);
            label5.Name = "label5";
            label5.Size = new Size(14, 31);
            label5.TabIndex = 6;
            label5.Text = "\r\n";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(172, 46);
            label6.Name = "label6";
            label6.Size = new Size(14, 31);
            label6.TabIndex = 7;
            label6.Text = "\r\n";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(620, 15);
            label7.Name = "label7";
            label7.Size = new Size(14, 31);
            label7.TabIndex = 8;
            label7.Text = "\r\n";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(620, 46);
            label8.Name = "label8";
            label8.Size = new Size(14, 31);
            label8.TabIndex = 9;
            label8.Text = "\r\n";
            // 
            // FormVerDetalleVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 19, 23);
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "FormVerDetalleVenta";
            Text = "FormVerDetalleVenta";
            Load += FormVerDetalleVenta_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn clm_Producto;
        private DataGridViewTextBoxColumn clm_Cantidad;
        private DataGridViewTextBoxColumn clm_PrecioUnitario;
        private DataGridViewTextBoxColumn clm_Subtotal;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}