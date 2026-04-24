namespace Sistema.UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnSalir = new Button();
            btnReportes = new Button();
            btnProveedores = new Button();
            btnClientes = new Button();
            btnVentas = new Button();
            btnInicio = new Button();
            btnInventario = new Button();
            pnlContenedor = new Panel();
            panel3 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(7, 2, 108);
            panel1.Controls.Add(btnSalir);
            panel1.Controls.Add(btnReportes);
            panel1.Controls.Add(btnProveedores);
            panel1.Controls.Add(btnClientes);
            panel1.Controls.Add(btnVentas);
            panel1.Controls.Add(btnInicio);
            panel1.Controls.Add(btnInventario);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 67);
            panel1.Name = "panel1";
            panel1.Size = new Size(229, 886);
            panel1.TabIndex = 0;
            // 
            // btnSalir
            // 
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatAppearance.MouseOverBackColor = Color.FromArgb(19, 34, 57);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 15F);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(-3, 816);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(229, 70);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "\u23fb Salir";
            btnSalir.TextAlign = ContentAlignment.MiddleLeft;
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnReportes
            // 
            btnReportes.FlatAppearance.BorderSize = 0;
            btnReportes.FlatAppearance.MouseOverBackColor = Color.FromArgb(19, 34, 57);
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.Font = new Font("Segoe UI", 15F);
            btnReportes.ForeColor = Color.White;
            btnReportes.Location = new Point(0, 414);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(229, 69);
            btnReportes.TabIndex = 5;
            btnReportes.Text = "📑 Reportes";
            btnReportes.UseVisualStyleBackColor = true;
            // 
            // btnProveedores
            // 
            btnProveedores.FlatAppearance.BorderSize = 0;
            btnProveedores.FlatAppearance.MouseOverBackColor = Color.FromArgb(19, 34, 57);
            btnProveedores.FlatStyle = FlatStyle.Flat;
            btnProveedores.Font = new Font("Segoe UI", 15F);
            btnProveedores.ForeColor = Color.White;
            btnProveedores.Location = new Point(0, 338);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Size = new Size(229, 70);
            btnProveedores.TabIndex = 4;
            btnProveedores.Text = "🚚 Proveedores";
            btnProveedores.UseVisualStyleBackColor = true;
            btnProveedores.Click += btnProveedores_Click;
            // 
            // btnClientes
            // 
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatAppearance.MouseOverBackColor = Color.FromArgb(19, 34, 57);
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Segoe UI", 15F);
            btnClientes.ForeColor = Color.White;
            btnClientes.Location = new Point(0, 253);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(229, 79);
            btnClientes.TabIndex = 3;
            btnClientes.Text = "👥 Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            // 
            // btnVentas
            // 
            btnVentas.FlatAppearance.BorderSize = 0;
            btnVentas.FlatAppearance.MouseOverBackColor = Color.FromArgb(19, 34, 57);
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.Font = new Font("Segoe UI", 15F);
            btnVentas.ForeColor = Color.White;
            btnVentas.Location = new Point(0, 176);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(229, 71);
            btnVentas.TabIndex = 2;
            btnVentas.Text = "\U0001f6d2 Ventas";
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnInicio
            // 
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatAppearance.MouseOverBackColor = Color.FromArgb(19, 34, 57);
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Segoe UI", 15F);
            btnInicio.ForeColor = Color.White;
            btnInicio.Location = new Point(0, 19);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(229, 71);
            btnInicio.TabIndex = 1;
            btnInicio.Text = "🏡 Inicio";
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click;
            // 
            // btnInventario
            // 
            btnInventario.FlatAppearance.BorderSize = 0;
            btnInventario.FlatAppearance.MouseOverBackColor = Color.FromArgb(19, 34, 57);
            btnInventario.FlatStyle = FlatStyle.Flat;
            btnInventario.Font = new Font("Segoe UI", 15F);
            btnInventario.ForeColor = Color.White;
            btnInventario.Location = new Point(0, 96);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(229, 74);
            btnInventario.TabIndex = 0;
            btnInventario.Text = "🛠️ Inventario";
            btnInventario.UseVisualStyleBackColor = true;
            btnInventario.Click += btnInventario_Click;
            // 
            // pnlContenedor
            // 
            pnlContenedor.BackColor = Color.FromArgb(15, 19, 23);
            pnlContenedor.Dock = DockStyle.Fill;
            pnlContenedor.Location = new Point(229, 67);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(1053, 886);
            pnlContenedor.TabIndex = 1;
            pnlContenedor.Paint += pnlContenedor_Paint;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 1, 53);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1282, 67);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 953);
            Controls.Add(pnlContenedor);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel pnlContenedor;
        private Panel panel3;
        private Button btnInventario;
        private Button btnInicio;
        private Button btnVentas;
        private Button btnReportes;
        private Button btnProveedores;
        private Button btnClientes;
        private Button btnSalir;
    }
}
