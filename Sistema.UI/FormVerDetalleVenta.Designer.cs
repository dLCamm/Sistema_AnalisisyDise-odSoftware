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
            dataGridView1 = new DataGridView();
            clm_Producto = new DataGridViewTextBoxColumn();
            clm_Cantidad = new DataGridViewTextBoxColumn();
            clm_PrecioUnitario = new DataGridViewTextBoxColumn();
            clm_Subtotal = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { clm_Producto, clm_Cantidad, clm_PrecioUnitario, clm_Subtotal });
            dataGridView1.Location = new Point(62, 80);
            dataGridView1.Name = "dataGridView1";
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
            // FormVerDetalleVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 19, 23);
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "FormVerDetalleVenta";
            Text = "FormVerDetalleVenta";
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
    }
}