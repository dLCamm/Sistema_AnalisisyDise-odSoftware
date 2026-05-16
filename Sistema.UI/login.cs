using Sistema.BLL.Factories;
using Sistema.Entities.Usuarios;
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var service = ServiceFactory.CrearUsuarioService())
                {
                    string Usuario = textBox1.Text;
                    string Password = textBox2.Text;

                    Usuario user = service.ValidarLogin(Usuario, Password);
                    if (user != null)
                    {

                        Form1 formularioPrincipal = new Form1();


                        formularioPrincipal.Show();


                        this.Hide();
                    }
                    else {MessageBox.Show("Usuario o contraseña incorrectos.", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar sesión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
