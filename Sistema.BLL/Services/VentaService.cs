using Sistema.DAL.Data;
using Sistema.DAL.Repositories.Interfaces;
using Sistema.Entities.Ventas;

namespace Sistema.BLL.Services
{
    public class VentaService : IDisposable
    {
        private readonly SistemaDbContext _context;
        private readonly IVentaRepository _repo;
        private readonly IProductoRepository _repoProducto;
        private readonly IClienteRepository _repoCliente;
        private readonly CreditoService _creditoService;


        public VentaService(SistemaDbContext context, IVentaRepository repo, IProductoRepository repoProducto, IClienteRepository repoCliente, CreditoService creditoService)
        {
            _context = context;
            _repo = repo;
            _repoProducto = repoProducto;
            _repoCliente = repoCliente;
            _creditoService = creditoService;
        }

        public void RegistrarVenta(int clienteId, int usuarioId, List<DetalleVenta> detalles, TipoPago tipoPago)
        {
            if (detalles == null || !detalles.Any())
                throw new Exception("La venta debe tener al menos un producto");

            using var transaction = _context.Database.BeginTransaction();

            try
            {
                decimal total = 0;

                // Validar cliente
                var clienteExiste = _repoCliente.ObtenerPorId(clienteId);
                if (clienteExiste == null)
                    throw new Exception("Cliente no existe");

                // FALTA VALIDAR USUARIO
                // FALTA VALIDACION VENTAS AL CREDITO

                // Validar productos y calcular subtotales
                var productoIds = detalles.Select(d => d.ProductoId).ToList();

                var productosLista = _repoProducto.ObtenerPorIds(productoIds);

                var productos = productosLista.ToDictionary(p => p.Id);

                foreach (var detalle in detalles)
                {
                    if (!productos.TryGetValue(detalle.ProductoId, out var producto))
                        throw new Exception($"Producto {detalle.ProductoId} no existe");

                    if (producto.Stock < detalle.Cantidad)
                        throw new Exception($"Stock insuficiente para {producto.Nombre}");

                    detalle.PrecioUnitario = producto.PrecioVenta;
                    detalle.Subtotal = detalle.Cantidad * detalle.PrecioUnitario;

                    total += detalle.Subtotal;

                    producto.Stock -= detalle.Cantidad;
                }

                // Crear venta
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

                _repo.InsertarVenta(venta);

                _context.SaveChanges();

                transaction.Commit();

            }
            catch
            {
                transaction.Rollback();
                throw new Exception("Error en la transaccion");
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
            using var transaction = _context.Database.BeginTransaction();

            try
            {
                var venta = _repo.ObtenerPorId(id);

                if (venta == null)
                    throw new Exception("Venta no encontrada");

                if (venta.Estado == EstadoVenta.Anulado)
                    return;

                // devolver stock
                foreach (var detalle in venta.Detalles)
                {
                    var producto = _repoProducto.ObtenerPorId(detalle.ProductoId);

                    if (producto != null)
                    {
                        producto.Stock += detalle.Cantidad;
                    }
                }

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
