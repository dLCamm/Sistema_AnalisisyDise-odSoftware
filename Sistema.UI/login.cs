using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistema.UI
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = !textBox2.UseSystemPasswordChar;

            // Opcional: Cambiar el texto del botón para mejorar la experiencia
            if (textBox2.UseSystemPasswordChar)
            {
                button2.Text = "Mostrar";
            }
            else
            {
                button2.Text = "Ocultar";
            }
        }
    }
}
