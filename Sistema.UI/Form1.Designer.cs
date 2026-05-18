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
            button1 = new Button();
            btnCréditos = new Button();
            btnSalir = new Button();
            btnReportes = new Button();
            btnProveedores = new Button();
            btnVentas = new Button();
            btnInicio = new Button();
            btnInventario = new Button();
            pnlContenedor = new Panel();
            button2 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(31, 41, 55);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnCréditos);
            panel1.Controls.Add(btnSalir);
            panel1.Controls.Add(btnReportes);
            panel1.Controls.Add(btnProveedores);
            panel1.Controls.Add(btnVentas);
            panel1.Controls.Add(btnInicio);
            panel1.Controls.Add(btnInventario);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(226, 953);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(19, 34, 57);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 15F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(0, 479);
            button1.Name = "button1";
            button1.Size = new Size(229, 69);
            button1.TabIndex = 8;
            button1.Text = "💰 Caja";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnCréditos
            // 
            btnCréditos.FlatAppearance.BorderSize = 0;
            btnCréditos.FlatAppearance.MouseOverBackColor = Color.FromArgb(19, 34, 57);
            btnCréditos.FlatStyle = FlatStyle.Flat;
            btnCréditos.Font = new Font("Segoe UI", 15F);
            btnCréditos.ForeColor = Color.White;
            btnCréditos.Location = new Point(0, 404);
            btnCréditos.Name = "btnCréditos";
            btnCréditos.Size = new Size(229, 69);
            btnCréditos.TabIndex = 7;
            btnCréditos.Text = "💵 Créditos";
            btnCréditos.UseVisualStyleBackColor = true;
            btnCréditos.Click += btnCréditos_Click;
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
            btnReportes.Location = new Point(0, 329);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(229, 69);
            btnReportes.TabIndex = 5;
            btnReportes.Text = "📑 Reportes";
            btnReportes.UseVisualStyleBackColor = true;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnProveedores
            // 
            btnProveedores.FlatAppearance.BorderSize = 0;
            btnProveedores.FlatAppearance.MouseOverBackColor = Color.FromArgb(19, 34, 57);
            btnProveedores.FlatStyle = FlatStyle.Flat;
            btnProveedores.Font = new Font("Segoe UI", 15F);
            btnProveedores.ForeColor = Color.White;
            btnProveedores.Location = new Point(-3, 253);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Size = new Size(229, 70);
            btnProveedores.TabIndex = 4;
            btnProveedores.Text = "🚚 Compras";
            btnProveedores.UseVisualStyleBackColor = true;
            btnProveedores.Click += btnProveedores_Click;
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
            pnlContenedor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlContenedor.BackColor = Color.FromArgb(31, 41, 55);
            pnlContenedor.Location = new Point(232, 0);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(1050, 953);
            pnlContenedor.TabIndex = 1;
            pnlContenedor.Paint += pnlContenedor_Paint;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(19, 34, 57);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 15F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(0, 554);
            button2.Name = "button2";
            button2.Size = new Size(229, 69);
            button2.TabIndex = 9;
            button2.Text = "👥Clientes";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 19, 23);
            ClientSize = new Size(1282, 953);
            Controls.Add(pnlContenedor);
            Controls.Add(panel1);
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
        private Button btnCréditos;
        private Button button1;
        private Button button2;
    }
}
