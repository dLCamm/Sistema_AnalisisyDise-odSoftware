namespace Sistema.UI
{
    partial class FormRegistroManual
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
            label1 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            comboBox2 = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(274, 32);
            label1.Name = "label1";
            label1.Size = new Size(262, 35);
            label1.TabIndex = 0;
            label1.Text = "Registrar Movimiento";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(30, 30, 35);
            comboBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox1.ForeColor = Color.White;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Ingreso", "Egreso" });
            comboBox1.Location = new Point(334, 102);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(396, 36);
            comboBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(107, 102);
            label2.Name = "label2";
            label2.Size = new Size(215, 30);
            label2.TabIndex = 2;
            label2.Text = "Tipo de Movimiento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(107, 172);
            label3.Name = "label3";
            label3.Size = new Size(80, 30);
            label3.TabIndex = 3;
            label3.Text = "Monto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(107, 240);
            label4.Name = "label4";
            label4.Size = new Size(129, 30);
            label4.TabIndex = 4;
            label4.Text = "Descripción";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(107, 301);
            label5.Name = "label5";
            label5.Size = new Size(88, 30);
            label5.TabIndex = 5;
            label5.Text = "Usuario";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(30, 30, 35);
            textBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(334, 172);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(396, 34);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(30, 30, 35);
            textBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(334, 240);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(396, 34);
            textBox2.TabIndex = 7;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.ActiveCaption;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.Black;
            btnGuardar.Location = new Point(204, 392);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(172, 39);
            btnGuardar.TabIndex = 29;
            btnGuardar.Text = "Guardar Movimiento";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.LightCoral;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.Location = new Point(431, 392);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(105, 39);
            btnCancelar.TabIndex = 30;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.FromArgb(30, 30, 35);
            comboBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox2.ForeColor = Color.White;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(334, 301);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(396, 36);
            comboBox2.TabIndex = 31;
            // 
            // FormRegistroManual
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 41, 55);
            ClientSize = new Size(800, 473);
            Controls.Add(comboBox2);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Name = "FormRegistroManual";
            Text = "FormRegistroManual";
            Load += FormRegistroManual_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnGuardar;
        private Button btnCancelar;
        private ComboBox comboBox2;
    }
}