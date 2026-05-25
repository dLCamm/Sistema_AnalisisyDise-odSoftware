using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Sistema.BLL.Factories;
using Sistema.Entities.Creditos;

namespace Sistema.UI
{
    public partial class frmDetalleCredito : Form
    {
        private int _idCredito;
        private Credito _creditoActual;

        public frmDetalleCredito(int idCredito)
        {
            InitializeComponent();
            this._idCredito = idCredito;

            // Configurar grillas al iniciar
            ConfigurarColumnasAbonos();
            ConfigurarColumnasTotales();
        }

        private void frmDetalleCredito_Load(object sender, EventArgs e)
        {
            RefrescarTodo();
        }

        private void ConfigurarColumnasAbonos()
        {
            dgvDetalleAbonos.Columns.Clear();
            dgvDetalleAbonos.Columns.Add("colId", "ID");
            dgvDetalleAbonos.Columns["colId"].Visible = false;

            dgvDetalleAbonos.Columns.Add("colMonto", "Abono");
            dgvDetalleAbonos.Columns.Add("colFecha", "Fecha");

            dgvDetalleAbonos.Columns["colMonto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvDetalleAbonos.Columns["colFecha"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvDetalleAbonos.Columns["colMonto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvDetalleAbonos.ReadOnly = true;
            dgvDetalleAbonos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalleAbonos.MultiSelect = false;
        }

        private void ConfigurarColumnasTotales()
        {
            dgvTotales.Columns.Clear();
            dgvTotales.Columns.Add("colTotal", "Total Crédito");
            dgvTotales.Columns.Add("colAbonado", "Total Abonado");
            dgvTotales.Columns.Add("colSaldo", "Saldo Pendiente");

            dgvTotales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTotales.AllowUserToAddRows = false;
            dgvTotales.ReadOnly = true;

            foreach (DataGridViewColumn col in dgvTotales.Columns)
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void RefrescarTodo()
        {
            try
            {
                using (var service = ServiceFactory.CrearCreditoService())
                {
                    _creditoActual = service.ObtenerCredito(_idCredito);
                    if (_creditoActual == null) return;

                    // 1. Datos del Cliente 
                    txtDetalleCliente.Text = _creditoActual.Venta?.Cliente?.Nombre ?? "N/A";
                    txtDetalleDpi.Text = _creditoActual.Venta?.Cliente?.DPI ?? "N/A";
                    txtDetalleTelefono.Text = _creditoActual.Venta?.Cliente?.Telefono ?? "N/A";
                    txtDetalleEmision.Text = _creditoActual.FechaInicio.ToShortDateString();
                    txtDetalleVencimiento.Text = _creditoActual.FechaVencimiento.ToShortDateString();

                    // 2. Llenar Historial de Abonos (Solo los que no están anulados)
                    dgvDetalleAbonos.Rows.Clear();
                    decimal totalAbonado = 0;

                    foreach (var abono in _creditoActual.Abonos.Where(a => a.Estado != EstadoAbono.Anulado))
                    {
                        dgvDetalleAbonos.Rows.Add(
                            abono.Id,
                            string.Format("Q{0:N2}", abono.Monto),
                            abono.Fecha.ToShortDateString()
                        );
                        totalAbonado += abono.Monto;
                    }

                    // 3. Llenar Tabla de Totales
                    dgvTotales.Rows.Clear();
                    dgvTotales.Rows.Add(
                        string.Format("Q{0:N2}", _creditoActual.TotalCredito),
                        string.Format("Q{0:N2}", totalAbonado),
                        string.Format("Q{0:N2}", _creditoActual.SaldoPendiente)
                    );

                    // 4. Control de UI
                    pnlNuevoAbono.Visible = false;
                    txtCantidadAbono.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar detalle: " + ex.Message);
            }
        }

        private void btnGuardarAbono_Click(object sender, EventArgs e)
        {
            try
            {
                if (decimal.TryParse(txtCantidadAbono.Text, out decimal monto))
                {
                    using (var service = ServiceFactory.CrearCreditoService())
                    {
                        service.RegistrarAbono(_idCredito, monto);
                        MessageBox.Show("Abono registrado con éxito.");
                        RefrescarTodo();
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un monto válido.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAnularAbono_Click(object sender, EventArgs e)
        {
            if (dgvDetalleAbonos.CurrentRow == null) return;

            int idAbono = (int)dgvDetalleAbonos.CurrentRow.Cells["colId"].Value;

            var result = MessageBox.Show("¿Está seguro de anular este abono?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (var service = ServiceFactory.CrearCreditoService())
                    {
                        service.AnularAbono(idAbono);
                        RefrescarTodo();
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void btnCancelarCredito_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Desea cancelar el crédito completo? Esto anulará todos los abonos realizados.", "¡Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (var service = ServiceFactory.CrearCreditoService())
                    {
                        service.CancelarCredito(_idCredito);
                        this.Close();
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void btnAgregarAbono_Click(object sender, EventArgs e)
        {
            pnlNuevoAbono.Visible = !pnlNuevoAbono.Visible;
            if (pnlNuevoAbono.Visible) txtCantidadAbono.Focus();
        }

        private void btnCancelarAb_Click(object sender, EventArgs e)
        {
            pnlNuevoAbono.Visible = false;
            txtCantidadAbono.Clear();
        }

        private void pnlDetallecredito_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtDetalleCliente_TextChanged(object sender, EventArgs e)
        {

        }
    }
}