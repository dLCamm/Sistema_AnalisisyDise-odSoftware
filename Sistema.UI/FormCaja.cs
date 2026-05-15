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
                    // 1. Agregamos la fila normalmente
                    int rowIndex = dataGridView1.Rows.Add(
                        m.Id,
                        m.Tipo,
                        m.Monto,
                        m.Origen,
                        m.Descripcion,
                        m.Fecha,
                        m.Estado.ToString(),
                        "X" 
                    );

         
                    dataGridView1.Rows[rowIndex].Tag = m;

               
                    var cellBoton = (DataGridViewButtonCell)dataGridView1.Rows[rowIndex].Cells["clm_anular"];

                    cellBoton.Style.BackColor = Color.Red;   
                    cellBoton.Style.ForeColor = Color.White;
                    cellBoton.Style.SelectionBackColor = Color.DarkRed; 
                }
                using (var service = ServiceFactory.CrearCajaService())
                {
                    label8.Text = service.ObtenerSaldo().ToString("C");
                    label3.Text = service.ObtenerIngresosActivo().ToString("C");
                    label7.Text = service.ObtenerEgresosActivo().ToString("C");
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 1. Validar que no sea el encabezado (índice -1)
            if (e.RowIndex < 0) return;

            // 2. Verificar si es la columna del botón "Anular"
            if (dataGridView1.Columns[e.ColumnIndex].Name == "clm_anular")
            {
                var movimiento = dataGridView1.Rows[e.RowIndex].Tag as MovimientoCaja;

                if (movimiento != null)
                {
                    var confirmResult = MessageBox.Show(
                        $"¿Está seguro de que desea anular el movimiento por {movimiento.Monto:C}? \nEsta acción no se puede deshacer.",
                        "Confirmar Anulación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (confirmResult == DialogResult.Yes)
                    {
                        try { 

                            Cursor.Current = Cursors.WaitCursor;

                            using (var service = ServiceFactory.CrearCajaService())
                            {
                                service.AnularMovimiento(movimiento.Id);
                            }

                            Ver_Toda_Caja(); 
                            MessageBox.Show("Movimiento anulado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("No se pudo anular: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            Cursor.Current = Cursors.Default;
                        }
                    }
                }
            }
        }
    }
}
