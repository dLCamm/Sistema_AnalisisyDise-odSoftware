namespace Sistema.UI
{
    partial class FormVerDetalleCompra
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            clm_producto = new DataGridViewTextBoxColumn();
            clm_cantidad = new DataGridViewTextBoxColumn();
            clm_preciocompra = new DataGridViewTextBoxColumn();
            clm_subtotal = new DataGridViewTextBoxColumn();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(15, 19, 23);
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(15, 19, 23);
            dataGridViewCellStyle7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(15, 19, 23);
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { clm_producto, clm_cantidad, clm_preciocompra, clm_subtotal });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(15, 19, 23);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(51, 104);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(15, 19, 23);
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle9.ForeColor = Color.White;
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(706, 270);
            dataGridView1.TabIndex = 0;
            // 
            // clm_producto
            // 
            clm_producto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clm_producto.HeaderText = "Producto";
            clm_producto.MinimumWidth = 6;
            clm_producto.Name = "clm_producto";
            // 
            // clm_cantidad
            // 
            clm_cantidad.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clm_cantidad.HeaderText = "Cantidad";
            clm_cantidad.MinimumWidth = 6;
            clm_cantidad.Name = "clm_cantidad";
            // 
            // clm_preciocompra
            // 
            clm_preciocompra.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clm_preciocompra.HeaderText = "Precio de Compra";
            clm_preciocompra.MinimumWidth = 6;
            clm_preciocompra.Name = "clm_preciocompra";
            // 
            // clm_subtotal
            // 
            clm_subtotal.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clm_subtotal.HeaderText = "Subtotal";
            clm_subtotal.MinimumWidth = 6;
            clm_subtotal.Name = "clm_subtotal";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(608, 56);
            label8.Name = "label8";
            label8.Size = new Size(14, 31);
            label8.TabIndex = 17;
            label8.Text = "\r\n";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(608, 25);
            label7.Name = "label7";
            label7.Size = new Size(14, 31);
            label7.TabIndex = 16;
            label7.Text = "\r\n";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(182, 56);
            label6.Name = "label6";
            label6.Size = new Size(14, 31);
            label6.TabIndex = 15;
            label6.Text = "\r\n";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(136, 25);
            label5.Name = "label5";
            label5.Size = new Size(14, 31);
            label5.TabIndex = 14;
            label5.Text = "\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(522, 25);
            label4.Name = "label4";
            label4.Size = new Size(90, 31);
            label4.TabIndex = 13;
            label4.Text = "Estado:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(50, 56);
            label3.Name = "label3";
            label3.Size = new Size(136, 31);
            label3.TabIndex = 12;
            label3.Text = "Proveedor: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(541, 56);
            label2.Name = "label2";
            label2.Size = new Size(71, 31);
            label2.TabIndex = 11;
            label2.Text = "Total:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(50, 25);
            label1.Name = "label1";
            label1.Size = new Size(80, 31);
            label1.TabIndex = 10;
            label1.Text = "Fecha:";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 192);
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(615, 380);
            button1.Name = "button1";
            button1.Size = new Size(142, 35);
            button1.TabIndex = 18;
            button1.Text = "Anular Compra";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FormVerDetalleCompra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 19, 23);
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "FormVerDetalleCompra";
            Text = "FormVerDetalleCompra";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn clm_producto;
        private DataGridViewTextBoxColumn clm_cantidad;
        private DataGridViewTextBoxColumn clm_preciocompra;
        private DataGridViewTextBoxColumn clm_subtotal;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
    }
}