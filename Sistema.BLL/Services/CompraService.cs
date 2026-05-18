using Sistema.DAL.Data;
using Sistema.DAL.Repositories.Interfaces;
using Sistema.Entities.Caja;
using Sistema.Entities.Compras;
using Sistema.Entities.Proveedores;
using System.ComponentModel.DataAnnotations;

namespace Sistema.BLL.Services
{
    public class CompraService : IDisposable
    {
        private readonly SistemaDbContext _context;

        private readonly ICompraRepository _repoCompra;
        private readonly IProductoRepository _repoProducto;
        private readonly CajaService _cajaService;

        public CompraService(
            SistemaDbContext context,
            ICompraRepository repoCompra,
            IProductoRepository repoProducto,
            CajaService cajaService)
        {
            _context = context;
            _repoCompra = repoCompra;
            _repoProducto = repoProducto;
            _cajaService = cajaService;
        }

        // REGISTRAR COMPRA
        public void RegistrarCompra(List<DetalleCompra> detalles)
        {
            if (detalles == null || !detalles.Any())
                throw new Exception("La compra debe tener productos");

            using var transaction = _context.Database.BeginTransaction();

            try
            {
                decimal total = 0;
                int totalProductos = 0;
                int productosDiferentes = detalles.Count;

                // IDS ÚNICOS
                var productoIds = detalles
                    .Select(d => d.ProductoId)
                    .Distinct()
                    .ToList();

                // OBTENER PRODUCTOS
                var productosLista = _repoProducto.ObtenerPorIds(productoIds);

                var productos = productosLista
                    .ToDictionary(p => p.Id);

                // VALIDAR Y PROCESAR
                foreach (var detalle in detalles)
                {
                    if (!productos.TryGetValue(detalle.ProductoId, out var producto))
                        throw new Exception($"Producto {detalle.ProductoId} no existe");

                    if (detalle.Cantidad <= 0)
                        throw new Exception("Cantidad inválida");

                    if (detalle.PrecioCompra <= 0)
                        throw new Exception("Precio de compra inválido");

                    if (producto.ProveedorId == null)
                        throw new Exception(
                            $"El producto {producto.Nombre} no tiene proveedor asignado");

                    // CALCULAR SUBTOTAL
                    detalle.Subtotal = detalle.Cantidad * detalle.PrecioCompra;

                    total += detalle.Subtotal;

                    // CONTAR PRODUCTOS
                    totalProductos += detalle.Cantidad;

                    // ACTUALIZAR STOCK
                    producto.Stock += detalle.Cantidad;

                    // ACTUALIZAR PRECIO COMPRA
                    producto.PrecioCompra = detalle.PrecioCompra;
                }

                // CREAR COMPRA
                var compra = new Compra
                {
                    Total = total,
                    Estado = EstadoCompra.Activa,
                    Detalles = detalles
                };

                _repoCompra.InsertarCompra(compra);

                // NECESITAMOS EL ID
                _context.SaveChanges();

                // MOVIMIENTO DE CAJA
                _cajaService.RegistrarEgreso(
                    total,
                    OrigenMovimientoCaja.Compra,
                    $"Compra #{compra.Id} - {productosDiferentes} productos diferentes - {totalProductos} unidades",
                    compra.Id,
                    guardarCambios: false);

                // GUARDAR TODO
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
                _cajaService.AnularMovimientoPorReferencia(OrigenMovimientoCaja.Compra,compra.Id, false);

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
