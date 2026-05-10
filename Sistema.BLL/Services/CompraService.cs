using Sistema.DAL.Data;
using Sistema.DAL.Repositories.Interfaces;
using Sistema.Entities.Caja;
using Sistema.Entities.Compras;
using Sistema.Entities.Proveedores;

namespace Sistema.BLL.Services
{
    public class CompraService : IDisposable
    {
        private readonly SistemaDbContext _context;

        private readonly ICompraRepository _repoCompra;
        private readonly IProductoRepository _repoProducto;
        private readonly IProveedorRepository _repoProveedor;
        private readonly CajaService _cajaService;

        public CompraService(
            SistemaDbContext context,
            ICompraRepository repoCompra,
            IProductoRepository repoProducto,
            IProveedorRepository repoProveedor,
            CajaService cajaService)
        {
            _context = context;
            _repoCompra = repoCompra;
            _repoProducto = repoProducto;
            _repoProveedor = repoProveedor;
            _cajaService = cajaService;
        }

        // REGISTRAR COMPRA
        public void RegistrarCompra(
            int proveedorId,
            List<DetalleCompra> detalles)
        {
            if (detalles == null || !detalles.Any())
                throw new Exception("La compra debe tener productos");

            using var transaction = _context.Database.BeginTransaction();

            try
            {
                // Validar proveedor
                var proveedor = _repoProveedor.ObtenerPorId(proveedorId);

                if (proveedor == null)
                    throw new Exception("Proveedor no encontrado");

                if (proveedor.Estado == EstadoProveedor.Inactivo)
                    throw new Exception("Proveedor inactivo");

                decimal total = 0;

                // validar productos
                var productoIds = detalles
                    .Select(d => d.ProductoId)
                    .ToList();

                var productosLista = _repoProducto
                    .ObtenerPorIds(productoIds);

                var productos = productosLista
                    .ToDictionary(p => p.Id);

                foreach (var detalle in detalles)
                {
                    if (!productos.TryGetValue(detalle.ProductoId, out var producto))
                        throw new Exception($"Producto {detalle.ProductoId} no existe");

                    // calcular subtotal
                    detalle.Subtotal = detalle.Cantidad * detalle.PrecioCompra;

                    total += detalle.Subtotal;

                    // aumentar stock
                    producto.Stock += detalle.Cantidad;

                    // actualizar precio compra
                    producto.PrecioCompra = detalle.PrecioCompra;
                }

                // crear compra
                var compra = new Compra
                {
                    ProveedorId = proveedorId,
                    Total = total,
                    Estado = EstadoCompra.Activa,
                    Detalles = detalles
                };

                _repoCompra.InsertarCompra(compra);

                _context.SaveChanges();

                _cajaService.RegistrarEgreso(
                    total,
                    OrigenMovimientoCaja.Compra,
                    $"Compra #{compra.Id} al proveedor {proveedor.Nombre}",
                    compra.Id);

                _context.SaveChanges();

                transaction.Commit();

            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }

        // OBTENER POR ID
        public Compra ObtenerCompra(int id)
        {
            var compra = _repoCompra.ObtenerPorId(id);

            if (compra == null)
                throw new Exception("Compra no encontrada");

            return compra;
        }

        // LISTAR TODAS
        public List<Compra> ListarCompras()
        {
            return _repoCompra.ObtenerTodos();
        }

        // FILTRAR POR ESTADO
        public List<Compra> ListarComprasPorEstado(EstadoCompra estado)
        {
            return _repoCompra.ObtenerPorEstado(estado);
        }

        // ANULAR COMPRA
        public void AnularCompra(int id)
        {
            using var transaction = _context.Database.BeginTransaction();

            try
            {
                var compra = _repoCompra.ObtenerPorId(id);

                if (compra == null)
                    throw new Exception("Compra no encontrada");

                if (compra.Estado == EstadoCompra.Anulada)
                    return;

                if (!compra.Detalles.Any())
                    throw new Exception("La compra no tiene detalles");

                // ids únicos
                var productoIds = compra.Detalles
                    .Select(d => d.ProductoId)
                    .Distinct()
                    .ToList();

                // UNA consulta
                var productosLista = _repoProducto
                    .ObtenerPorIds(productoIds);

                // validar productos faltantes
                if (productosLista.Count != productoIds.Count)
                    throw new Exception("Algunos productos ya no existen");

                // diccionario
                var productos = productosLista
                    .ToDictionary(p => p.Id);

                // devolver stock
                foreach (var detalle in compra.Detalles)
                {
                    var producto = productos[detalle.ProductoId];

                    if (producto.Stock < detalle.Cantidad)
                    {
                        throw new Exception(
                            $"No se puede anular la compra porque el stock de {producto.Nombre} ya fue consumido");
                    }

                    producto.Stock -= detalle.Cantidad;
                }

                // anular compra    
                compra.Estado = EstadoCompra.Anulada;

                _repoCompra.Actualizar(compra);

                // anular movimiento de caja
                _cajaService.AnularPorOrigen(OrigenMovimientoCaja.Compra,compra.Id);

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
