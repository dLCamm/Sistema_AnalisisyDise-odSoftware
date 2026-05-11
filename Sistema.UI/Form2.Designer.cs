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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panelMain = new Panel();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            txtBuscar = new TextBox();
            listProductos = new DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)listProductos).BeginInit();
            panelPago.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(15, 19, 23);
            panelMain.Controls.Add(label2);
            panelMain.Controls.Add(label1);
            panelMain.Controls.Add(button1);
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(831, 115);
            label2.Name = "label2";
            label2.Size = new Size(175, 28);
            label2.TabIndex = 8;
            label2.Text = "Carrito de Ventas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 25F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(21, 30);
            label1.Name = "label1";
            label1.Size = new Size(194, 57);
            label1.TabIndex = 7;
            label1.Text = "VENTAS";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Cursor = Cursors.AppStarting;
            button1.Location = new Point(1404, 113);
            button1.Name = "button1";
            button1.Size = new Size(231, 38);
            button1.TabIndex = 6;
            button1.Text = "Ver Ventas";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(15, 19, 23);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(15, 19, 23);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(15, 19, 23);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(15, 19, 23);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(30, 30, 35);
            dataGridView1.Location = new Point(831, 157);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(804, 507);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtBuscar
            // 
            txtBuscar.ForeColor = Color.Gray;
            txtBuscar.Location = new Point(21, 113);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(412, 27);
            txtBuscar.TabIndex = 0;
            txtBuscar.Text = "Añadir Producto";
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // listProductos
            // 
            listProductos.AllowUserToAddRows = false;
            listProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            listProductos.BackgroundColor = Color.FromArgb(15, 19, 23);
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(15, 19, 23);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(15, 19, 23);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            listProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            listProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(15, 19, 23);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            listProductos.DefaultCellStyle = dataGridViewCellStyle4;
            listProductos.EnableHeadersVisualStyles = false;
            listProductos.GridColor = Color.FromArgb(30, 30, 35);
            listProductos.Location = new Point(21, 157);
            listProductos.Name = "listProductos";
            listProductos.ReadOnly = true;
            listProductos.RowHeadersVisible = false;
            listProductos.RowHeadersWidth = 51;
            listProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            listProductos.Size = new Size(804, 686);
            listProductos.TabIndex = 1;
            // 
            // panelPago
            // 
            panelPago.BackColor = Color.FromArgb(15, 19, 23);
            panelPago.BorderStyle = BorderStyle.FixedSingle;
            panelPago.Controls.Add(lblTotal);
            panelPago.Controls.Add(lblTipoPago);
            panelPago.Controls.Add(rbCredito);
            panelPago.Controls.Add(rbFisico);
            panelPago.Controls.Add(lblCliente);
            panelPago.Controls.Add(cmbCliente);
            panelPago.Controls.Add(btnAgregarCliente);
            panelPago.ForeColor = Color.White;
            panelPago.Location = new Point(831, 670);
            panelPago.Name = "panelPago";
            panelPago.Size = new Size(804, 173);
            panelPago.TabIndex = 3;
            panelPago.Paint += panelPago_Paint;
            // 
            // lblTotal
            // 
            lblTotal.Location = new Point(10, 10);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(202, 30);
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
            rbCredito.CheckedChanged += rbCredito_CheckedChanged;
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
            cmbCliente.Size = new Size(348, 28);
            cmbCliente.TabIndex = 5;
            // 
            // btnAgregarCliente
            // 
            btnAgregarCliente.BackColor = SystemColors.ActiveCaption;
            btnAgregarCliente.ForeColor = Color.Black;
            btnAgregarCliente.Location = new Point(379, 102);
            btnAgregarCliente.Name = "btnAgregarCliente";
            btnAgregarCliente.Size = new Size(228, 43);
            btnAgregarCliente.TabIndex = 6;
            btnAgregarCliente.Text = "Agregar Nuevo Cliente";
            btnAgregarCliente.UseVisualStyleBackColor = false;
            btnAgregarCliente.Click += btnAgregarCliente_Click;
            // 
            // btnRealizarVenta
            // 
            btnRealizarVenta.BackColor = SystemColors.ActiveCaption;
            btnRealizarVenta.ForeColor = Color.Black;
            btnRealizarVenta.Location = new Point(1068, 873);
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
            ClientSize = new Size(1806, 948);
            Controls.Add(panelMain);
            Name = "Form2";
            Text = "Ventas";
            WindowState = FormWindowState.Maximized;
            Load += Form2_Load;
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)listProductos).EndInit();
            panelPago.ResumeLayout(false);
            ResumeLayout(false);
        }



        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView listProductos;
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
        private Button button1;
        private Label label1;
        private Label label2;
    }
}