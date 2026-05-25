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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            panelMain = new Panel();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            btnAgregarCliente = new Button();
            lblCliente = new Label();
            txtBuscar = new TextBox();
            cmbCliente = new ComboBox();
            listProductos = new DataGridView();
            panelPago = new Panel();
            lblTotal = new Label();
            lblTipoPago = new Label();
            rbCredito = new RadioButton();
            rbFisico = new RadioButton();
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
            panelMain.Controls.Add(btnAgregarCliente);
            panelMain.Controls.Add(lblCliente);
            panelMain.Controls.Add(txtBuscar);
            panelMain.Controls.Add(cmbCliente);
            panelMain.Controls.Add(listProductos);
            panelMain.Controls.Add(panelPago);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1684, 948);
            panelMain.TabIndex = 0;
            panelMain.Paint += panelMain_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(842, 115);
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
            label1.Location = new Point(21, 9);
            label1.Name = "label1";
            label1.Size = new Size(194, 57);
            label1.TabIndex = 7;
            label1.Text = "VENTAS";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Cursor = Cursors.AppStarting;
            button1.Location = new Point(1433, 861);
            button1.Name = "button1";
            button1.Size = new Size(231, 38);
            button1.TabIndex = 6;
            button1.Text = "Ver Ventas";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.FromArgb(15, 19, 23);
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(15, 19, 23);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(15, 19, 23);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(15, 19, 23);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.Padding = new Padding(5, 2, 5, 2);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(30, 30, 35);
            dataGridView1.Location = new Point(842, 157);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(822, 507);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnAgregarCliente
            // 
            btnAgregarCliente.BackColor = SystemColors.ActiveCaption;
            btnAgregarCliente.ForeColor = Color.Black;
            btnAgregarCliente.Location = new Point(1476, 100);
            btnAgregarCliente.Name = "btnAgregarCliente";
            btnAgregarCliente.Size = new Size(188, 43);
            btnAgregarCliente.TabIndex = 6;
            btnAgregarCliente.Text = "Agregar Nuevo Cliente";
            btnAgregarCliente.UseVisualStyleBackColor = false;
            btnAgregarCliente.Click += btnAgregarCliente_Click;
            // 
            // lblCliente
            // 
            lblCliente.Font = new Font("Segoe UI", 10F);
            lblCliente.ForeColor = Color.White;
            lblCliente.Location = new Point(1112, 92);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(80, 20);
            lblCliente.TabIndex = 4;
            lblCliente.Text = "Cliente";
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Segoe UI", 10F);
            txtBuscar.ForeColor = Color.Gray;
            txtBuscar.Location = new Point(21, 113);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(412, 30);
            txtBuscar.TabIndex = 0;
            txtBuscar.Text = "Añadir Producto";
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // cmbCliente
            // 
            cmbCliente.Location = new Point(1112, 115);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(348, 28);
            cmbCliente.TabIndex = 5;
            // 
            // listProductos
            // 
            listProductos.AllowUserToAddRows = false;
            listProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            listProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            listProductos.BackgroundColor = Color.FromArgb(15, 19, 23);
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(15, 19, 23);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(15, 19, 23);
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            listProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            listProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(15, 19, 23);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.Padding = new Padding(5, 3, 5, 3);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            listProductos.DefaultCellStyle = dataGridViewCellStyle8;
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
            panelPago.Controls.Add(btnRealizarVenta);
            panelPago.ForeColor = Color.White;
            panelPago.Location = new Point(842, 670);
            panelPago.Name = "panelPago";
            panelPago.Size = new Size(822, 173);
            panelPago.TabIndex = 3;
            panelPago.Paint += panelPago_Paint;
            // 
            // lblTotal
            // 
            lblTotal.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            lblTotal.Location = new Point(559, 15);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(233, 30);
            lblTotal.TabIndex = 0;
            lblTotal.Text = "Total: Q0";
            // 
            // lblTipoPago
            // 
            lblTipoPago.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTipoPago.Location = new Point(15, 15);
            lblTipoPago.Name = "lblTipoPago";
            lblTipoPago.Size = new Size(146, 37);
            lblTipoPago.TabIndex = 1;
            lblTipoPago.Text = "Tipo de Pago:";
            // 
            // rbCredito
            // 
            rbCredito.Font = new Font("Segoe UI", 12F);
            rbCredito.Location = new Point(167, 15);
            rbCredito.Name = "rbCredito";
            rbCredito.Size = new Size(104, 39);
            rbCredito.TabIndex = 2;
            rbCredito.Text = "Crédito Cliente";
            rbCredito.CheckedChanged += rbCredito_CheckedChanged;
            // 
            // rbFisico
            // 
            rbFisico.Font = new Font("Segoe UI", 12F);
            rbFisico.Location = new Point(277, 15);
            rbFisico.Name = "rbFisico";
            rbFisico.Size = new Size(119, 39);
            rbFisico.TabIndex = 3;
            rbFisico.Text = "Físico";
            rbFisico.CheckedChanged += rbFisico_CheckedChanged;
            // 
            // btnRealizarVenta
            // 
            btnRealizarVenta.BackColor = SystemColors.ActiveCaption;
            btnRealizarVenta.ForeColor = Color.Black;
            btnRealizarVenta.Location = new Point(230, 93);
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
            ClientSize = new Size(1684, 948);
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