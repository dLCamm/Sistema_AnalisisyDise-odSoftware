namespace Sistema.UI
{
    partial class FormVerClientes
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            labelCreditos = new Label();
            dataGridView1 = new DataGridView();
            clm_id = new DataGridViewTextBoxColumn();
            clm_dpi = new DataGridViewTextBoxColumn();
            clm_nombre = new DataGridViewTextBoxColumn();
            clm_telefono = new DataGridViewTextBoxColumn();
            clm_direccion = new DataGridViewTextBoxColumn();
            clm_fecha = new DataGridViewTextBoxColumn();
            clm_correo = new DataGridViewTextBoxColumn();
            clm_estado = new DataGridViewTextBoxColumn();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(31, 41, 55);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(labelCreditos);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1705, 76);
            panel1.TabIndex = 1;
            // 
            // labelCreditos
            // 
            labelCreditos.AutoSize = true;
            labelCreditos.Font = new Font("Segoe UI Black", 25F, FontStyle.Bold);
            labelCreditos.ForeColor = Color.White;
            labelCreditos.Location = new Point(12, 9);
            labelCreditos.Name = "labelCreditos";
            labelCreditos.Size = new Size(220, 57);
            labelCreditos.TabIndex = 5;
            labelCreditos.Text = "CLIENTES";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.FromArgb(15, 19, 23);
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(15, 19, 23);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { clm_id, clm_dpi, clm_nombre, clm_telefono, clm_direccion, clm_fecha, clm_correo, clm_estado });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(15, 19, 23);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.Padding = new Padding(5, 10, 5, 10);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(34, 34, 34);
            dataGridView1.Location = new Point(0, 82);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1705, 865);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // clm_id
            // 
            clm_id.HeaderText = "ID";
            clm_id.MinimumWidth = 6;
            clm_id.Name = "clm_id";
            clm_id.ReadOnly = true;
            clm_id.Visible = false;
            // 
            // clm_dpi
            // 
            clm_dpi.HeaderText = "DPI";
            clm_dpi.MinimumWidth = 6;
            clm_dpi.Name = "clm_dpi";
            clm_dpi.ReadOnly = true;
            // 
            // clm_nombre
            // 
            clm_nombre.HeaderText = "Nombre";
            clm_nombre.MinimumWidth = 6;
            clm_nombre.Name = "clm_nombre";
            clm_nombre.ReadOnly = true;
            // 
            // clm_telefono
            // 
            clm_telefono.HeaderText = "Telefono";
            clm_telefono.MinimumWidth = 6;
            clm_telefono.Name = "clm_telefono";
            clm_telefono.ReadOnly = true;
            // 
            // clm_direccion
            // 
            clm_direccion.HeaderText = "Dirección";
            clm_direccion.MinimumWidth = 6;
            clm_direccion.Name = "clm_direccion";
            clm_direccion.ReadOnly = true;
            // 
            // clm_fecha
            // 
            clm_fecha.HeaderText = "Fecha de Registro";
            clm_fecha.MinimumWidth = 6;
            clm_fecha.Name = "clm_fecha";
            clm_fecha.ReadOnly = true;
            // 
            // clm_correo
            // 
            clm_correo.HeaderText = "Correo";
            clm_correo.MinimumWidth = 6;
            clm_correo.Name = "clm_correo";
            clm_correo.ReadOnly = true;
            // 
            // clm_estado
            // 
            clm_estado.HeaderText = "Estado";
            clm_estado.MinimumWidth = 6;
            clm_estado.Name = "clm_estado";
            clm_estado.ReadOnly = true;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(1476, 25);
            button1.Name = "button1";
            button1.Size = new Size(159, 41);
            button1.TabIndex = 6;
            button1.Text = "Agregar Cliente";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FormVerClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 19, 23);
            ClientSize = new Size(1705, 1003);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormVerClientes";
            Text = "FormVerClientes";
            Load += FormVerClientes_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label labelCreditos;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn clm_id;
        private DataGridViewTextBoxColumn clm_dpi;
        private DataGridViewTextBoxColumn clm_nombre;
        private DataGridViewTextBoxColumn clm_telefono;
        private DataGridViewTextBoxColumn clm_direccion;
        private DataGridViewTextBoxColumn clm_fecha;
        private DataGridViewTextBoxColumn clm_correo;
        private DataGridViewTextBoxColumn clm_estado;
        private Button button1;
    }
}