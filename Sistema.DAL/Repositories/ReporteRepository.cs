using Microsoft.EntityFrameworkCore;
using Sistema.DAL.Data;
using Sistema.DAL.Repositories.Interfaces;
using Sistema.Entities.Caja;
using Sistema.Entities.Creditos;
using Sistema.Entities.DTOs.Caja;
using Sistema.Entities.DTOs.Compras;
using Sistema.Entities.DTOs.Creditos;
using Sistema.Entities.DTOs.Dashboard;
using Sistema.Entities.DTOs.Inventario;
using Sistema.Entities.DTOs.Ventas;

namespace Sistema.DAL.Repositories
{
    public class ReporteRepository : IReporteRepository
    {
        private readonly SistemaDbContext _context;

        public ReporteRepository(SistemaDbContext context)
        {
            _context = context;
        }
        // =========================
        // COMPRAS POR FECHA
        // =========================
        public List<CompraReporteDTO>
            ObtenerComprasPorFecha(
            DateTime fechaInicio,
            DateTime fechaFin)
        {
            return _context.Compras
                .Include(c => c.Proveedor)

                .Where(c =>
                    c.Fecha >= fechaInicio &&
                    c.Fecha <= fechaFin)

                .Select(c => new CompraReporteDTO
                {
                    CompraId = c.Id,

                    Proveedor = c.Proveedor.Nombre,

                    Total = c.Total,

                    Estado = c.Estado.ToString(),

                    Fecha = c.Fecha
                })

                .OrderByDescending(c => c.Fecha)

                .ToList();
        }

        // =========================
        // COMPRAS POR PROVEEDOR
        // =========================
        public List<CompraReporteDTO>
            ObtenerComprasProveedor(
            int proveedorId)
        {
            return _context.Compras
                .Include(c => c.Proveedor)

                .Where(c =>
                    c.ProveedorId == proveedorId)

                .Select(c => new CompraReporteDTO
                {
                    CompraId = c.Id,

                    Proveedor = c.Proveedor.Nombre,

                    Total = c.Total,

                    Estado = c.Estado.ToString(),

                    Fecha = c.Fecha
                })

                .OrderByDescending(c => c.Fecha)

                .ToList();
        }

        // =========================
        // TOTAL COMPRAS
        // =========================
        public decimal ObtenerTotalCompras(
            DateTime fechaInicio,
            DateTime fechaFin)
        {
            return _context.Compras
                .Where(c =>
                    c.Fecha >= fechaInicio &&
                    c.Fecha <= fechaFin)

                .Sum(c => (decimal?)c.Total) ?? 0;
        }

        // =========================
        // COMPRAS POR DÍA
        // =========================
        public List<CompraPorDiaDTO>
            ObtenerComprasPorDia(
            DateTime fechaInicio,
            DateTime fechaFin)
        {
            return _context.Compras
                .Where(c =>
                    c.Fecha >= fechaInicio &&
                    c.Fecha <= fechaFin)

                .GroupBy(c => c.Fecha.Date)

                .Select(g => new CompraPorDiaDTO
                {
                    Fecha = g.Key,

                    TotalCompras = g.Sum(x => x.Total)
                })

                .OrderBy(x => x.Fecha)

                .ToList();
        }

        // =========================
        // PRODUCTOS MÁS VENDIDOS
        // =========================
        public List<ProductoMasVendidoDTO>
            ObtenerProductosMasVendidos(
            DateTime fechaInicio,
            DateTime fechaFin)
        {
            return _context.DetalleVentas
                .Where(d =>
                    d.Venta.Fecha >= fechaInicio &&
                    d.Venta.Fecha <= fechaFin)

                .GroupBy(d => new
                {
                    d.ProductoId,
                    d.Producto.Nombre
                })

                .Select(g => new ProductoMasVendidoDTO
                {
                    ProductoId = g.Key.ProductoId,

                    NombreProducto = g.Key.Nombre,

                    CantidadVendida = g.Sum(x => x.Cantidad),

                    TotalGenerado = g.Sum(x => x.Subtotal)
                })

                .OrderByDescending(x => x.CantidadVendida)

                .ToList();
        }

        // =========================
        // VENTAS POR DÍA
        // =========================
        public List<VentaPorDiaDTO>
            ObtenerVentasPorDia(
            DateTime fechaInicio,
            DateTime fechaFin)
        {
            return _context.Ventas
                .Where(v =>
                    v.Fecha >= fechaInicio &&
                    v.Fecha <= fechaFin)

                .GroupBy(v => v.Fecha.Date)

                .Select(g => new VentaPorDiaDTO
                {
                    Fecha = g.Key,

                    TotalVentas = g.Sum(x => x.Total)
                })

                .OrderBy(x => x.Fecha)

                .ToList();
        }

        // =========================
        // BALANCE CAJA
        // =========================
        public decimal ObtenerBalanceCaja(
            DateTime fechaInicio,
            DateTime fechaFin)
        {
            var movimientos = _context.Caja
                .Where(c =>
                    c.Estado ==
                        EstadoMovimientoCaja.Activo &&

                    c.Fecha >= fechaInicio &&
                    c.Fecha <= fechaFin);

            decimal ingresos = movimientos
                .Where(c =>
                    c.Tipo ==
                    TipoMovimientoCaja.Ingreso)

                .Sum(c => c.Monto);

            decimal egresos = movimientos
                .Where(c =>
                    c.Tipo ==
                    TipoMovimientoCaja.Egreso)

                .Sum(c => c.Monto);

            return ingresos - egresos;
        }

        // =========================
        // CAJA POR DÍA
        // =========================
        public List<CajaPorDiaDTO>
            ObtenerCajaPorDia(
            DateTime fechaInicio,
            DateTime fechaFin)
        {
            return _context.Caja
                .Where(c =>
                    c.Estado ==
                        EstadoMovimientoCaja.Activo &&

                    c.Fecha >= fechaInicio &&
                    c.Fecha <= fechaFin)

                .GroupBy(c => c.Fecha.Date)

                .Select(g => new CajaPorDiaDTO
                {
                    Fecha = g.Key,

                    Ingresos = g
                        .Where(x =>
                            x.Tipo ==
                            TipoMovimientoCaja.Ingreso)

                        .Sum(x => x.Monto),

                    Egresos = g
                        .Where(x =>
                            x.Tipo ==
                            TipoMovimientoCaja.Egreso)

                        .Sum(x => x.Monto)
                })

                .OrderBy(x => x.Fecha)

                .ToList();
        }

        // =========================
        // CRÉDITOS VENCIDOS
        // =========================
        public List<CreditoDTO>
            ObtenerCreditosVencidos()
        {
            return _context.Creditos
                .Include(c => c.Cliente)

                .Where(c =>
                    c.Estado ==
                        EstadoCredito.Pendiente &&

                    c.FechaVencimiento <
                        DateTime.Now)

                .Select(c => new CreditoDTO
                {
                    CreditoId = c.Id,

                    Cliente = c.Cliente.Nombre,

                    TotalCredito = c.TotalCredito,

                    SaldoPendiente = c.SaldoPendiente,

                    Estado = c.Estado.ToString(),

                    FechaInicio = c.FechaInicio,

                    FechaVencimiento =
                        c.FechaVencimiento
                })

                .ToList();
        }

        // =========================
        // CLIENTES CON DEUDA
        // =========================
        public List<CreditoDTO>
            ObtenerClientesConDeuda()
        {
            return _context.Creditos
                .Include(c => c.Cliente)

                .Where(c =>
                    c.Estado ==
                    EstadoCredito.Pendiente)

                .Select(c => new CreditoDTO
                {
                    CreditoId = c.Id,

                    Cliente = c.Cliente.Nombre,

                    TotalCredito = c.TotalCredito,

                    SaldoPendiente = c.SaldoPendiente,

                    Estado = c.Estado.ToString(),

                    FechaInicio = c.FechaInicio,

                    FechaVencimiento =
                        c.FechaVencimiento
                })

                .OrderByDescending(c =>
                    c.SaldoPendiente)

                .ToList();
        }

        // =========================
        // PRODUCTOS BAJO STOCK
        // =========================
        public List<ProductoInventarioDTO>
            ObtenerProductosBajoStock(
            int stockMinimo)
        {
            return _context.Productos
                .Where(p =>
                    p.Stock <= stockMinimo)

                .Select(p => new ProductoInventarioDTO
                {
                    ProductoId = p.Id,

                    Producto = p.Nombre,

                    Stock = p.Stock,

                    PrecioCompra = p.PrecioCompra,

                    PrecioVenta = p.PrecioVenta,

                    BajoStock = true
                })

                .OrderBy(p => p.Stock)

                .ToList();
        }

        // =========================
        // DASHBOARD
        // =========================
        public DashboardDTO ObtenerDashboard()
        {
            DateTime hoy = DateTime.Today;

            decimal ventasHoy = _context.Ventas
                .Where(v =>
                    v.Fecha.Date == hoy)

                .Sum(v => (decimal?)v.Total) ?? 0;

            decimal ingresosHoy = _context.Caja
                .Where(c =>
                    c.Tipo ==
                        TipoMovimientoCaja.Ingreso &&

                    c.Estado ==
                        EstadoMovimientoCaja.Activo &&

                    c.Fecha.Date == hoy)

                .Sum(c => (decimal?)c.Monto) ?? 0;

            decimal egresosHoy = _context.Caja
                .Where(c =>
                    c.Tipo ==
                        TipoMovimientoCaja.Egreso &&

                    c.Estado ==
                        EstadoMovimientoCaja.Activo &&

                    c.Fecha.Date == hoy)

                .Sum(c => (decimal?)c.Monto) ?? 0;

            decimal cajaActual = ingresosHoy - egresosHoy;

            decimal creditosPendientes = _context.Creditos
                .Where(c =>
                    c.Estado ==
                        EstadoCredito.Pendiente)

                .Sum(c => (decimal?)c.SaldoPendiente) ?? 0;

            int productosBajoStock = _context.Productos
                .Count(p => p.Stock <= 5);

            return new DashboardDTO
            {
                VentasHoy = ventasHoy,

                CajaActual = cajaActual,

                CreditosPendientes = creditosPendientes,

                ProductosBajoStock = productosBajoStock,

                IngresosHoy = ingresosHoy,

                EgresosHoy = egresosHoy
            };
        }
    }
}
