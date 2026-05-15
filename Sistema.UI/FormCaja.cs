using Sistema.BLL.Factories;
using Sistema.Entities.Caja;
using Sistema.Entities.Compras;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sistema.UI
{
    public partial class FormCaja : Form
    {
        List<MovimientoCaja> movimientoss;
        List<MovimientoCaja> movimientosfiltrados;
        public FormCaja()
        {
            InitializeComponent();
            Ver_Toda_Caja();
            RecargarCombos(this, EventArgs.Empty);
        }

        public void RecargarCombos(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Ingreso");
            comboBox1.Items.Add("Egreso");
            comboBox2.Items.Clear();
            comboBox2.Items.Add("Venta");
            comboBox2.Items.Add("Compra");
            comboBox2.Items.Add("Abono");
            comboBox2.Items.Add("Ajuste");
            comboBox3.Items.Clear();
            comboBox3.Items.Add("Activo");
            comboBox3.Items.Add("Anulado");
        }



        public void Ver_Toda_Caja()
        {
            try
            {
                using (var services = ServiceFactory.CrearCajaService())
                {
                    var cja = services.ListarMovimientos();
                    movimientoss = cja;
                    movimientosfiltrados = cja;
                    refrescar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los movimientos de caja: " + ex.Message);
            }
        }

        public void refrescar()
        {
            try
            {
                dataGridView1.Rows.Clear();
                foreach (var m in movimientosfiltrados)
                {
                    dataGridView1.Rows.Add(m.Id, m.Tipo, m.Monto, m.Origen, m.Descripcion, m.Fecha, m.Estado.ToString());
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Tag = m;
                }
                using (var service = ServiceFactory.CrearCajaService())
                {
                    label8.Text = service.ObtenerSaldo().ToString("C");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al refrescar los movimientos de caja: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormRegistroManual frm = new FormRegistroManual();
            frm.ShowDialog();
            frm.Close();
            Ver_Toda_Caja();
        }

        private void AplicarFiltrosGlobales()
        {


            string estado = comboBox3.SelectedItem?.ToString() ?? string.Empty;
            DateTime fecha = dateTimePicker1.Checked ? dateTimePicker1.Value.Date : DateTime.MinValue;
            string origen = comboBox2.SelectedItem?.ToString() ?? string.Empty;
            string tipo = comboBox1.SelectedItem?.ToString() ?? string.Empty;

            // SIEMPRE empezamos desde la lista completa original
            var resultado = movimientoss.AsEnumerable();


            // Filtro por Fecha
            if (fecha != DateTime.MinValue)
            {
                resultado = resultado.Where(v => v.Fecha.Date == fecha);
            }


            // Filtro por Estado
            if (!string.IsNullOrEmpty(estado))
            {
                resultado = resultado.Where(v => v.Estado.ToString() == estado);
            }

            if (!string.IsNullOrEmpty(origen))
            {
                resultado = resultado.Where(v => v.Origen.ToString() == origen);
            }

            if (!string.IsNullOrEmpty(tipo))
            {
                resultado = resultado.Where(v => v.Tipo.ToString() == tipo);
            }


            movimientosfiltrados = resultado.ToList();
            refrescar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AplicarFiltrosGlobales();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker1.Checked = false;
            Ver_Toda_Caja();
        }
    }
}
