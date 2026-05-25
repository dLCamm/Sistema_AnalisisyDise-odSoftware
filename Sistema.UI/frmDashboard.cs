using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Sistema.BLL.Services;
using Sistema.BLL.Factories;

// Componentes clave para LiveCharts v2 y SkiaSharp
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using SkiaSharp;

namespace Sistema.UI
{
    public partial class frmDashboard : Form
    {
        private readonly ReporteService _reporteService;

        public frmDashboard()
        {
            InitializeComponent();
            _reporteService = ServiceFactory.CrearReporteService();

            // Asignar los eventos de Clic de forma manual para asegurar el comportamiento
            AsignarEventosClics();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            CargarDatosDashboard();
            CargarGraficasDashboard(); // <-- Agregamos la invocación de las gráficas
        }

        private void AsignarEventosClics()
        {
            // --- PANEL 5: SIN EXISTENCIAS (STOCK BAJO) ---
            panel5.Click += PanelSinExistencias_Click;
            lblStockBajo.Click += PanelSinExistencias_Click;

            // --- PANEL 4: CRÉDITOS ---
            panel4.Click += PanelCreditos_Click;
            lblCreditosPendientes.Click += PanelCreditos_Click;
        }

        public void CargarDatosDashboard()
        {
            try
            {
                var datos = _reporteService.ObtenerDashboard();

                // 1. Mostrar Ventas de Hoy
                lblVentasHoy.Text = "Q " + datos.VentasHoy.ToString("N2");

                // 2. Mostrar Caja Actual
                lblCajaActual.Text = "Q " + datos.CajaActual.ToString("N2");

                // 3. Mostrar Créditos Pendientes y Vencidos
                lblCreditosPendientes.Text = "Q " + datos.CreditosPendientes.ToString("N2");

                // 4. Mostrar Productos en Stock Bajo / Sin Existencias
                lblStockBajo.Text = datos.ProductosBajoStock.ToString();

                // Lógica visual para las alertas del inventario
                if (datos.ProductosBajoStock > 0)
                {
                    lblStockBajo.ForeColor = Color.Red;
                }
                else
                {
                    lblStockBajo.ForeColor = Color.White;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los indicadores del Dashboard: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void CargarGraficasDashboard()
        {
            try
            {
                // Rango de fechas con tiempo exacto para capturar pruebas de hoy por la tarde
                DateTime fechaFin = DateTime.Now;
                DateTime fechaInicio = fechaFin.AddDays(-30);

                var formatoTextoBlanco = new SolidColorPaint(SKColors.White);

                // ====================================================================
                // 1. GRÁFICA LINEAL: VENTAS POR DÍA (Últimos 6 días móviles)
                // ====================================================================
                var todasLasVentas = _reporteService.ObtenerVentasPorDia(fechaInicio, fechaFin);
                var ventasFiltradas = todasLasVentas.OrderBy(x => x.Fecha).TakeLast(6).ToList();

                cartesianChart1.Series = new ISeries[]
                {
            new LineSeries<decimal>
            {
                Name = "Ventas (Q)",
                Values = ventasFiltradas.Select(x => x.TotalVentas).ToArray(),
                GeometrySize = 8,
                Stroke = new SolidColorPaint(SKColors.DeepSkyBlue) { StrokeThickness = 4 },
                Fill = null
            }
                };

                cartesianChart1.XAxes = new Axis[]
                {
            new Axis
            {
                Labels = ventasFiltradas.Select(x => x.Fecha.ToString("dd/MM")).ToArray(),
                LabelsPaint = formatoTextoBlanco
            }
                };

                // ====================================================================
                // 2. BARRAS HORIZONTALES: TOP 5 PRODUCTOS MÁS VENDIDOS
                // ====================================================================
                var todosLosProductos = _reporteService.ObtenerProductosMasVendidos(fechaInicio, fechaFin);
                var topProductos = todosLosProductos.OrderByDescending(x => x.CantidadVendida).Take(5).Reverse().ToList();

                // Guardamos los nombres completos en una lista limpia en memoria
                var nombresCompletos = topProductos.Select(x => x.NombreProducto).ToList();

                cartesianChart2.Series = new ISeries[]
                {
            new RowSeries<int>
            {
                Name = "Unidades",
                Values = topProductos.Select(x => x.CantidadVendida).ToArray(),
                Fill = new SolidColorPaint(SKColors.MediumSeaGreen),
                DataLabelsFormatter = point => $"{point.Coordinate.PrimaryValue} u."
            }
                };

                cartesianChart2.YAxes = new Axis[]
                {
            new Axis
            {
                // El eje izquierdo se queda recortado a 15 caracteres para no descuadrar tu UI
                Labels = topProductos.Select(x => x.NombreProducto.Length > 15
                    ? x.NombreProducto.Substring(0, 15) + "..."
                    : x.NombreProducto).ToArray(),
                LabelsPaint = formatoTextoBlanco
            }
                };

                // SUSCRIPCIÓN AL EVENTO: Desvinculamos cualquier evento previo para evitar ejecuciones dobles
                cartesianChart2.ChartPointPointerDown -= CartesianChart2_ChartPointPointerDown;
                cartesianChart2.ChartPointPointerDown += CartesianChart2_ChartPointPointerDown;

                // ====================================================================
                // 3. BARRAS EN PARES: INGRESOS VS EGRESOS (Últimos 6 días móviles)
                // ====================================================================
                var todaLaCaja = _reporteService.ObtenerCajaPorDia(fechaInicio, fechaFin);
                var cajaFiltrada = todaLaCaja.OrderBy(x => x.Fecha).TakeLast(6).ToList();

                cartesianChart3.Series = new ISeries[]
                {
            new ColumnSeries<decimal>
            {
                Name = "Ingresos",
                Values = cajaFiltrada.Select(x => x.Ingresos).ToArray(),
                Fill = new SolidColorPaint(SKColors.LimeGreen)
            },
            new ColumnSeries<decimal>
            {
                Name = "Egresos",
                Values = cajaFiltrada.Select(x => x.Egresos).ToArray(),
                Fill = new SolidColorPaint(SKColors.Crimson)
            }
                };

                cartesianChart3.XAxes = new Axis[]
                {
            new Axis
            {
                Labels = cajaFiltrada.Select(x => x.Fecha.ToString("dd/MM")).ToArray(),
                LabelsPaint = formatoTextoBlanco
            }
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar gráficos: " + ex.Message, "Error Gráficos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ---- MANEJO DEL CLIC EN EL PANEL 5 (SIN EXISTENCIAS) ----
        private void PanelSinExistencias_Click(object sender, EventArgs e)
        {
            var host = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            frmInventario ventanaInventario = new frmInventario("Alertas");

            if (host != null)
            {
                host.AbrirFormEnPanel(ventanaInventario);
            }
            else
            {
                ventanaInventario.ShowDialog();
            }
        }

        // ---- MANEJO DEL CLIC EN EL PANEL 4 (CRÉDITOS PENDIENTES / VENCIDOS) ----
        private void PanelCreditos_Click(object sender, EventArgs e)
        {
            var host = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            frmCréditos ventanaCreditos = new frmCréditos("PorCobrar");

            if (host != null)
            {
                host.AbrirFormEnPanel(ventanaCreditos);
            }
            else
            {
                ventanaCreditos.ShowDialog();
            }
        }

        // Métodos requeridos por el diseñador
        private void panel5_Paint(object sender, PaintEventArgs e) { }


        private void CartesianChart2_ChartPointPointerDown(
    LiveChartsCore.Kernel.Sketches.IChartView chart,
    LiveChartsCore.Kernel.ChartPoint point)
        {
            try
            {
                // Obtenemos el índice exacto de la barra horizontal seleccionada (Eje Y)
                int index = (int)point.Coordinate.SecondaryValue;

                // Recuperamos la lista de los top productos calculados en ese momento
                DateTime fechaFin = DateTime.Now;
                DateTime fechaInicio = fechaFin.AddDays(-30);
                var topProductos = _reporteService.ObtenerProductosMasVendidos(fechaInicio, fechaFin)
                                    .OrderByDescending(x => x.CantidadVendida)
                                    .Take(5)
                                    .Reverse()
                                    .ToList();

                if (index >= 0 && index < topProductos.Count)
                {
                    var productoSeleccionado = topProductos[index];

                    // Desplegamos un cuadro de diálogo informativo estético
                    MessageBox.Show($"📦 Producto: {productoSeleccionado.NombreProducto}\n📊 Cantidad Vendida: {productoSeleccionado.CantidadVendida} unidades",
                                    "Detalle del Producto",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al detectar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }


}
