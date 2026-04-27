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


        public VentaService(SistemaDbContext context, IVentaRepository repo, IProductoRepository repoProducto)
        {
            _context = context;
            _repo = repo;
            _repoProducto = repoProducto;
        }

        public void RegistrarVenta(int clienteId, int usuarioId, List<DetalleVenta> detalles, TipoPago tipoPago)
        {
            if (detalles == null || !detalles.Any())
                throw new Exception("La venta debe tener al menos un producto");

            using var transaction = _context.Database.BeginTransaction();

            try
            {
                decimal total = 0;

                // Validar productos y calcular subtotales
                foreach (var detalle in detalles)
                {
                    var producto = _repoProducto.ObtenerPorId(detalle.ProductoId);

                    if (producto == null)
                        throw new Exception($"Producto {detalle.ProductoId} no existe");

                    if (producto.Stock < detalle.Cantidad)
                        throw new Exception($"Stock insuficiente para {producto.Nombre}");

                    detalle.PrecioUnitario = producto.PrecioVenta;
                    detalle.Subtotal = detalle.Cantidad * detalle.PrecioUnitario;

                    total += detalle.Subtotal;

                    // Descontar stock
                    producto.Stock -= detalle.Cantidad;
                }

                // Crear venta
                var venta = new Venta
                {
                    ClienteId = clienteId,
                    UsuarioId = usuarioId,
                    Fecha = DateTime.Now,
                    TipoPago = tipoPago,
                    Total = total,
                    Estado = tipoPago == TipoPago.Contado
                        ? EstadoVenta.Pagada
                        : EstadoVenta.Pendiente
                };

                // Insertamos registro en db para obtener id
                _repo.InsertarVenta(venta);
                _context.SaveChanges();

                // Metemos id de la venta a los detalles y subimos
                foreach (var detalle in detalles)
                {
                    detalle.VentaId = venta.Id;
                }

                _repo.InsertarDetalles(detalles);
                _context.SaveChanges();

                // Terminamos la transaccion
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
        public List<Venta> ListarVentasPorEstado(EstadoVenta estado)
        {
            return _repo.ObtenerPorEstado(estado);
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
