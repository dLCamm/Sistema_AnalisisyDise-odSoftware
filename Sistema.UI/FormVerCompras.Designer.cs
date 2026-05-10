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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            button1 = new Button();
            clm_proveedor = new DataGridViewTextBoxColumn();
            clm_Estado = new DataGridViewTextBoxColumn();
            clm_fecha = new DataGridViewTextBoxColumn();
            clm_total = new DataGridViewTextBoxColumn();
            clm_detalle = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { clm_proveedor, clm_Estado, clm_fecha, clm_total, clm_detalle });
            dataGridView1.Location = new Point(32, 107);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1631, 794);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 25F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(32, 44);
            label1.Name = "label1";
            label1.Size = new Size(518, 57);
            label1.TabIndex = 9;
            label1.Text = "COMPRAS REALIZADAS";
            // 
            // button1
            // 
            button1.Location = new Point(565, 58);
            button1.Name = "button1";
            button1.Size = new Size(146, 43);
            button1.TabIndex = 10;
            button1.Text = "Volver a Compras";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // clm_proveedor
            // 
            clm_proveedor.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clm_proveedor.HeaderText = "Proveedor";
            clm_proveedor.MinimumWidth = 6;
            clm_proveedor.Name = "clm_proveedor";
            // 
            // clm_Estado
            // 
            clm_Estado.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clm_Estado.HeaderText = "Estado";
            clm_Estado.MinimumWidth = 6;
            clm_Estado.Name = "clm_Estado";
            // 
            // clm_fecha
            // 
            clm_fecha.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clm_fecha.HeaderText = "Fecha";
            clm_fecha.MinimumWidth = 6;
            clm_fecha.Name = "clm_fecha";
            // 
            // clm_total
            // 
            clm_total.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clm_total.HeaderText = "Total ";
            clm_total.MinimumWidth = 6;
            clm_total.Name = "clm_total";
            // 
            // clm_detalle
            // 
            clm_detalle.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clm_detalle.HeaderText = "Detalle";
            clm_detalle.MinimumWidth = 6;
            clm_detalle.Name = "clm_detalle";
            // 
            // FormVerCompras
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1685, 940);
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
        private DataGridViewTextBoxColumn clm_proveedor;
        private DataGridViewTextBoxColumn clm_Estado;
        private DataGridViewTextBoxColumn clm_fecha;
        private DataGridViewTextBoxColumn clm_total;
        private DataGridViewButtonColumn clm_detalle;
    }
}