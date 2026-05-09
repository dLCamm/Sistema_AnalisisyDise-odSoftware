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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { clm_producto, clm_cantidad, clm_preciocompra, clm_subtotal });
            dataGridView1.Location = new Point(51, 104);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(706, 319);
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
            label6.Location = new Point(160, 56);
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
            // FormVerDetalleCompra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
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
    }
}