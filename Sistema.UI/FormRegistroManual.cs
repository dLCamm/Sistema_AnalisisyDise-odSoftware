using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sistema.BLL.Factories;

namespace Sistema.UI
{
    public partial class FormRegistroManual : Form
    {
        public FormRegistroManual()
        {
            InitializeComponent();
            cargarusuarios(this, EventArgs.Empty);
        }

        private void cargarusuarios(object sender, EventArgs e)
        {

            comboBox2.Items.Add("Usuario 1");

        }

        private void FormRegistroManual_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var services = ServiceFactory.CrearCajaService())
                {
                    if (comboBox1.Text == "Ingreso")
                    {

                        services.RegistrarIngreso(monto: decimal.Parse(textBox1.Text), descripcion: textBox2.Text, origen: Entities.Caja.OrigenMovimientoCaja.Ajuste, referenciaId: 0);
                    }
                    else if (comboBox1.Text == "Egreso")
                    {
                        services.RegistrarEgreso(monto: decimal.Parse(textBox1.Text), descripcion: textBox2.Text, origen: Entities.Caja.OrigenMovimientoCaja.Ajuste, referenciaId: 0);
                    }
                }
                MessageBox.Show(" Realizado con exito");
                this.Close();

            }
            catch
            {
                MessageBox.Show("Error al registrar el movimiento. Verifique los datos ingresados.");
            }
        }
    }
}
