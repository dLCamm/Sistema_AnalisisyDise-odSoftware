using Sistema.DAL.Data;
using Sistema.DAL.Repositories.Interfaces;
using Sistema.Entities.Caja;
using Sistema.Entities.Ventas;

namespace Sistema.BLL.Services
{
    public class VentaService : IDisposable
    {
        private readonly SistemaDbContext _context;
        private readonly IVentaRepository _repo;
        private readonly IProductoRepository _repoProducto;
        private readonly IClienteRepository _repoCliente;
        private readonly IUsuarioRepository _repoUsuario;
        private readonly CreditoService _creditoService;
        private readonly CajaService _cajaService;


        public VentaService(SistemaDbContext context, IVentaRepository repo, IProductoRepository repoProducto, IClienteRepository repoCliente, IUsuarioRepository repoUsuario,CreditoService creditoService, CajaService cajaService)
        {
            _context = context;
            _repo = repo;
            _repoProducto = repoProducto;
            _repoCliente = repoCliente;
            _repoUsuario = repoUsuario;
            _creditoService = creditoService;
            _cajaService = cajaService;
        }

        public void RegistrarVenta(
            int clienteId,
            int usuarioId,
            List<DetalleVenta> detalles,
            TipoPago tipoPago,
            DateTime? fechaVencimiento = null,
            decimal abonoInicial = 0)
        {
            if (detalles == null || !detalles.Any())
                throw new Exception("La venta debe tener al menos un producto");

            using var transaction = _context.Database.BeginTransaction();

            try
            {
                decimal total = 0;

                // VALIDAR CLIENTE
                var clienteExiste = _repoCliente.ObtenerPorId(clienteId);

                if (clienteExiste == null)
                    throw new Exception("Cliente no existe");

                // VALIDAR USUARIO
                var usuarioExiste = _repoUsuario.ObtenerPorId(usuarioId);

                if (usuarioExiste == null)
                    throw new Exception("Usuario no existe");

                // VALIDACIONES CRÉDITO
                if (tipoPago == TipoPago.Credito)
                {
                    if (fechaVencimiento == null)
                        throw new Exception(
                            "Debe ingresar fecha de vencimiento");

                    if (abonoInicial < 0)
                        throw new Exception(
                            "Abono inicial inválido");
                }

                // VALIDAR PRODUCTOS
                var productoIds = detalles
                    .Select(d => d.ProductoId)
                    .Distinct()
                    .ToList();

                var productosLista = _repoProducto
                    .ObtenerPorIds(productoIds);

                var productos = productosLista
                    .ToDictionary(p => p.Id);

                foreach (var detalle in detalles)
                {
                    if (!productos.TryGetValue(
                        detalle.ProductoId,
                        out var producto))
                    {
                        throw new Exception(
                            $"Producto {detalle.ProductoId} no existe");
                    }

                    if (producto.Stock < detalle.Cantidad)
                    {
                        throw new Exception(
                            $"Stock insuficiente para {producto.Nombre}");
                    }

                    detalle.PrecioUnitario =
                        producto.PrecioVenta;

                    detalle.Subtotal =
                        detalle.Cantidad *
                        detalle.PrecioUnitario;

                    total += detalle.Subtotal;

                    // DESCONTAR STOCK
                    producto.Stock -= detalle.Cantidad;
                }

                // VALIDAR ABONO
                if (abonoInicial > total)
                {
                    throw new Exception(
                        "El abono inicial excede el total");
                }

                // CREAR VENTA
                var venta = new Venta
                {
                    ClienteId = clienteId,
                    UsuarioId = usuarioId,
                    TipoPago = tipoPago,
                    Total = total,

                    Estado = tipoPago == TipoPago.Contado
                        ? EstadoVenta.Pagada
                        : EstadoVenta.Pendiente,

                    Detalles = detalles
                };
                // NECESITAMOS venta.Id
                _repo.InsertarVenta(venta);
                _context.SaveChanges();

                // CREAR MOVIMIENTO CAJA SI ES AL CONTADO
                if (tipoPago == TipoPago.Contado)
                {
                    _cajaService.RegistrarIngreso(
                        total,
                        OrigenMovimientoCaja.Venta,
                        $"Ingreso por venta #{venta.Id}",
                        venta.Id,
                        usuarioId,
                        false);
                }


                // CREAR CRÉDITO
                else if (tipoPago == TipoPago.Credito)
                {
                    _creditoService.CrearCredito(
                        venta.Id,
                        fechaVencimiento!.Value,
                        abonoInicial,
                        false);
                }

                _context.SaveChanges();

                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }

        // Obtener una venta
        public Venta ObtenerVenta(int id)
        {
            var venta = _repo.ObtenerPorId(id);

            if (venta == null)
                throw new Exception("Venta no encontrada");

            return venta;
        }

        // Listar todas
        public List<Venta> ListarVentas()
        {
            return _repo.ObtenerTodos();
        }

        // Filtrar por estado
        public List<Venta> ListarVentasPorPendientes()
        {
            return _repo.ObtenerPorEstado(EstadoVenta.Pendiente);
        }
        public List<Venta> ListarVentasPorPagada()
        {
            return _repo.ObtenerPorEstado(EstadoVenta.Pagada);
        }
        public List<Venta> ListarVentasPorAnulado()
        {
            return _repo.ObtenerPorEstado(EstadoVenta.Anulado);
        }

        // Anular venta
        public void AnularVenta(int id)
        {
            using var transaction =
                _context.Database.BeginTransaction();

            try
            {
                var venta = _repo.ObtenerPorId(id);

                if (venta == null)
                    throw new Exception("Venta no encontrada");

                if (venta.Estado == EstadoVenta.Anulado)
                    return;

                // DEVOLVER STOCK
                foreach (var detalle in venta.Detalles)
                {
                    var producto =
                        _repoProducto.ObtenerPorId(
                            detalle.ProductoId);

                    if (producto != null)
                    {
                        producto.Stock += detalle.Cantidad;
                    }
                }

                // CANCELAR CRÉDITO SI EXISTE
                if (venta.TipoPago == TipoPago.Credito)
                {
                    _creditoService.CancelarCreditoPorVenta(
                        venta.Id,
                        false);
                }

                // ANULAR MOVIMIENTO CAJA SI ES AL CONTADO
                else if(venta.TipoPago == TipoPago.Contado)
                {
                    _cajaService.AnularMovimientoPorReferencia(OrigenMovimientoCaja.Venta, venta.Id, false);
                }

                // ANULAR VENTA
                venta.Estado = EstadoVenta.Anulado;

                _repo.Actualizar(venta);

                _context.SaveChanges();

                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
