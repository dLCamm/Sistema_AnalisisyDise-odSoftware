using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices; // Para que funcione el DllImport

namespace Sistema.UI
{
    public partial class frmCréditos : Form
    {
        // DEFINICIÓN DE LA API PARA MENSAJE EN TEXTBOX BÚSQUEDA
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        private const int EM_SETCUEBANNER = 0x1501;

        public frmCréditos()
        {
            InitializeComponent();
            ConfigurarPlaceholders(); 
        }

        // --- 2. EL MÉTODO QUE APLICA EL MENSAJE FANTASMA
        private void ConfigurarPlaceholders()
        {
           
            SendMessage(txtBuscarCredito.Handle, EM_SETCUEBANNER, 0, "Buscar por cliente o DPI");
        }

        private void btnNuevoCredito_Click(object sender, EventArgs e)
        {
            frmDetalleCredito ventanaModal = new frmDetalleCredito();
            ventanaModal.ShowDialog();
        }

        private void txtBuscarCredito_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}