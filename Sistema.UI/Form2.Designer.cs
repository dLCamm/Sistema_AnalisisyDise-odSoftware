namespace Sistema.UI
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panelMain = new Panel();
            dataGridView1 = new DataGridView();
            txtBuscar = new TextBox();
            listProductos = new ListBox();
            panelPago = new Panel();
            lblTotal = new Label();
            lblTipoPago = new Label();
            rbCredito = new RadioButton();
            rbFisico = new RadioButton();
            lblCliente = new Label();
            cmbCliente = new ComboBox();
            btnAgregarCliente = new Button();
            btnRealizarVenta = new Button();
            Col_Producto = new DataGridViewTextBoxColumn();
            Col_Cantidad = new DataGridViewTextBoxColumn();
            Col_Subtotal = new DataGridViewTextBoxColumn();
            panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelPago.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = SystemColors.ActiveCaption;
            panelMain.Controls.Add(dataGridView1);
            panelMain.Controls.Add(txtBuscar);
            panelMain.Controls.Add(listProductos);
            panelMain.Controls.Add(panelPago);
            panelMain.Controls.Add(btnRealizarVenta);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1806, 948);
            panelMain.TabIndex = 0;
            panelMain.Paint += panelMain_Paint;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.LightSteelBlue;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.LightSteelBlue;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.GridColor = Color.DarkBlue;
            dataGridView1.Location = new Point(831, 80);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(686, 360);
            dataGridView1.TabIndex = 5;
            // 
            // txtBuscar
            // 
            txtBuscar.ForeColor = Color.Gray;
            txtBuscar.Location = new Point(161, 80);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(250, 27);
            txtBuscar.TabIndex = 0;
            txtBuscar.Text = "Añadir Producto";
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // listProductos
            // 
            listProductos.BackColor = SystemColors.GradientActiveCaption;
            listProductos.ForeColor = Color.Black;
            listProductos.Location = new Point(152, 132);
            listProductos.Name = "listProductos";
            listProductos.RightToLeft = RightToLeft.No;
            listProductos.Size = new Size(507, 544);
            listProductos.TabIndex = 1;
            listProductos.SelectedIndexChanged += listProductos_SelectedIndexChanged;
            // 
            // panelPago
            // 
            panelPago.BackColor = SystemColors.GradientActiveCaption;
            panelPago.BorderStyle = BorderStyle.FixedSingle;
            panelPago.Controls.Add(lblTotal);
            panelPago.Controls.Add(lblTipoPago);
            panelPago.Controls.Add(rbCredito);
            panelPago.Controls.Add(rbFisico);
            panelPago.Controls.Add(lblCliente);
            panelPago.Controls.Add(cmbCliente);
            panelPago.Controls.Add(btnAgregarCliente);
            panelPago.Location = new Point(831, 446);
            panelPago.Name = "panelPago";
            panelPago.Size = new Size(686, 212);
            panelPago.TabIndex = 3;
            panelPago.Paint += panelPago_Paint;
            // 
            // lblTotal
            // 
            lblTotal.Location = new Point(10, 10);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(200, 20);
            lblTotal.TabIndex = 0;
            lblTotal.Text = "Total: Q0";
            // 
            // lblTipoPago
            // 
            lblTipoPago.Location = new Point(10, 40);
            lblTipoPago.Name = "lblTipoPago";
            lblTipoPago.Size = new Size(120, 20);
            lblTipoPago.TabIndex = 1;
            lblTipoPago.Text = "Tipo de Pago";
            // 
            // rbCredito
            // 
            rbCredito.Location = new Point(10, 60);
            rbCredito.Name = "rbCredito";
            rbCredito.Size = new Size(120, 20);
            rbCredito.TabIndex = 2;
            rbCredito.Text = "Crédito Cliente";
            // 
            // rbFisico
            // 
            rbFisico.Location = new Point(150, 60);
            rbFisico.Name = "rbFisico";
            rbFisico.Size = new Size(80, 20);
            rbFisico.TabIndex = 3;
            rbFisico.Text = "Físico";
            // 
            // lblCliente
            // 
            lblCliente.Location = new Point(10, 90);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(80, 20);
            lblCliente.TabIndex = 4;
            lblCliente.Text = "Cliente";
            // 
            // cmbCliente
            // 
            cmbCliente.Location = new Point(10, 110);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(200, 28);
            cmbCliente.TabIndex = 5;
            // 
            // btnAgregarCliente
            // 
            btnAgregarCliente.Location = new Point(220, 110);
            btnAgregarCliente.Name = "btnAgregarCliente";
            btnAgregarCliente.Size = new Size(80, 25);
            btnAgregarCliente.TabIndex = 6;
            btnAgregarCliente.Text = "Agregar";
            // 
            // btnRealizarVenta
            // 
            btnRealizarVenta.BackColor = Color.RoyalBlue;
            btnRealizarVenta.FlatStyle = FlatStyle.Flat;
            btnRealizarVenta.ForeColor = Color.White;
            btnRealizarVenta.Location = new Point(928, 664);
            btnRealizarVenta.Name = "btnRealizarVenta";
            btnRealizarVenta.Size = new Size(300, 40);
            btnRealizarVenta.TabIndex = 4;
            btnRealizarVenta.Text = "Realizar Venta";
            btnRealizarVenta.UseVisualStyleBackColor = false;
            btnRealizarVenta.Click += btnRealizarVenta_Click_1;
            // 
            // Col_Producto
            // 
            Col_Producto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Col_Producto.HeaderText = "Producto";
            Col_Producto.MinimumWidth = 6;
            Col_Producto.Name = "Col_Producto";
            // 
            // Col_Cantidad
            // 
            Col_Cantidad.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Col_Cantidad.HeaderText = "Cantidad";
            Col_Cantidad.MinimumWidth = 6;
            Col_Cantidad.Name = "Col_Cantidad";
            // 
            // Col_Subtotal
            // 
            Col_Subtotal.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Col_Subtotal.HeaderText = "Subtotal";
            Col_Subtotal.MinimumWidth = 6;
            Col_Subtotal.Name = "Col_Subtotal";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            ClientSize = new Size(1806, 948);
            Controls.Add(panelMain);
            Name = "Form2";
            Text = "Ventas";
            WindowState = FormWindowState.Maximized;
            Load += Form2_Load;
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelPago.ResumeLayout(false);
            ResumeLayout(false);
        }



        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ListBox listProductos;
        private System.Windows.Forms.Panel panelPago;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTipoPago;
        private System.Windows.Forms.RadioButton rbCredito;
        private System.Windows.Forms.RadioButton rbFisico;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Button btnAgregarCliente;
        // panelCantidad and its controls removed
        private System.Windows.Forms.Button btnRealizarVenta;
        // unused list view headers removed
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Col_Producto;
        private DataGridViewTextBoxColumn Col_Cantidad;
        private DataGridViewTextBoxColumn Col_Subtotal;
    }
}