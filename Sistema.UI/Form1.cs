namespace Sistema.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Ahora público para que formularios embebidos puedan pedir abrir otros forms en el panel
        public void AbrirFormEnPanel(object formHijo)
        {
            if (formHijo == null)
                return;

            if (formHijo is not Form fh)
                throw new Exception("Error al cargar formulario");

            // Si ya hay un Form dentro del panel y es del mismo tipo, traerlo al frente
            var existingForm = this.pnlContenedor.Controls.OfType<Form>().FirstOrDefault();
            if (existingForm != null)
            {
                if (existingForm.GetType() == fh.GetType())
                {
                    existingForm.BringToFront();
                    return;
                }

                // Limpiar y disponer controles anteriores
                foreach (Control c in this.pnlContenedor.Controls)
                {
                    c.Dispose();
                }
                this.pnlContenedor.Controls.Clear();
            }

            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            fh.WindowState = FormWindowState.Normal;
            this.pnlContenedor.Controls.Add(fh);
            this.pnlContenedor.Tag = fh;
            fh.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {

        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmInventario());
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {

        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD

=======
            // Al pulsar Ventas abrimos Form2 (si ya está abierto, el método lo traerá al frente)
            AbrirFormEnPanel(new Form2());
>>>>>>> Camilo
        }
    }
}
