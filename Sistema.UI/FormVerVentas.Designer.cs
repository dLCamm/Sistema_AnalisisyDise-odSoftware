using System.Drawing;
using System.Windows.Forms;

namespace Sistema.UI
{
    partial class FormVerVentas
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
            btnVolver = new Button();
            dataGridView1 = new DataGridView();
            clm_cliente = new DataGridViewTextBoxColumn();
            clm_Tipopago = new DataGridViewTextBoxColumn();
            clm_Fecha = new DataGridViewTextBoxColumn();
            clm_Total = new DataGridViewTextBoxColumn();
            clm_Estado = new DataGridViewTextBoxColumn();
            clm_Detalle = new DataGridViewButtonColumn();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.BackColor = SystemColors.ActiveCaption;
            btnVolver.Location = new Point(102, 50);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(133, 39);
            btnVolver.TabIndex = 0;
            btnVolver.Text = "Volver a Ventas";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += BtnVolver_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { clm_cliente, clm_Tipopago, clm_Fecha, clm_Total, clm_Estado, clm_Detalle });
            dataGridView1.Location = new Point(102, 95);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1444, 729);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // clm_cliente
            // 
            clm_cliente.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clm_cliente.HeaderText = "Cliente";
            clm_cliente.MinimumWidth = 6;
            clm_cliente.Name = "clm_cliente";
            clm_cliente.ReadOnly = true;
            clm_cliente.ToolTipText = "Cliente";
            // 
            // clm_Tipopago
            // 
            clm_Tipopago.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clm_Tipopago.HeaderText = "Tipo de Pago";
            clm_Tipopago.MinimumWidth = 6;
            clm_Tipopago.Name = "clm_Tipopago";
            clm_Tipopago.ReadOnly = true;
            // 
            // clm_Fecha
            // 
            clm_Fecha.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clm_Fecha.HeaderText = "Fecha";
            clm_Fecha.MinimumWidth = 6;
            clm_Fecha.Name = "clm_Fecha";
            clm_Fecha.ReadOnly = true;
            // 
            // clm_Total
            // 
            clm_Total.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clm_Total.HeaderText = "Total";
            clm_Total.MinimumWidth = 6;
            clm_Total.Name = "clm_Total";
            clm_Total.ReadOnly = true;
            // 
            // clm_Estado
            // 
            clm_Estado.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clm_Estado.HeaderText = "Estado";
            clm_Estado.MinimumWidth = 6;
            clm_Estado.Name = "clm_Estado";
            clm_Estado.ReadOnly = true;
            // 
            // clm_Detalle
            // 
            clm_Detalle.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clm_Detalle.HeaderText = "Detalle";
            clm_Detalle.MinimumWidth = 6;
            clm_Detalle.Name = "clm_Detalle";
            clm_Detalle.ReadOnly = true;
            clm_Detalle.Resizable = DataGridViewTriState.True;
            clm_Detalle.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(699, 28);
            label4.Name = "label4";
            label4.Size = new Size(197, 31);
            label4.TabIndex = 6;
            label4.Text = "Ventas Realizadas";
            // 
            // FormVerVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 19, 23);
            ClientSize = new Size(1608, 846);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Controls.Add(btnVolver);
            Name = "FormVerVentas";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Ver Ventas";
            Resize += FormVerVentas_Resize;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        // Declaración del control para que el diseñador pueda resolverlo
        private System.Windows.Forms.Button btnVolver;

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn clm_cliente;
        private DataGridViewTextBoxColumn clm_Tipopago;
        private DataGridViewTextBoxColumn clm_Fecha;
        private DataGridViewTextBoxColumn clm_Total;
        private DataGridViewTextBoxColumn clm_Estado;
        private DataGridViewButtonColumn clm_Detalle;
        private Label label4;
    }
}