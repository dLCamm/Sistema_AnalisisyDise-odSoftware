using Sistema.DAL.Data;
using Sistema.DAL.Repositories.Interfaces;
using Sistema.Entities.Productos;

namespace Sistema.BLL.Services
{
    public class InventarioService : IDisposable
    {
        private readonly SistemaDbContext _context;
        private readonly IProductoRepository _repo;
        private readonly IProveedorRepository _repoProveedor;

        public InventarioService(SistemaDbContext context, IProductoRepository repo, IProveedorRepository repoProveedor)
        {
            _context = context;
            _repo = repo;
            _repoProveedor = repoProveedor;

        }

        // Busqueda de datos
        public List<Producto> ListarProductos()
        {
            return _repo.ObtenerTodos();
        }
         
        public Producto ObtenerProducto(int id)
        {
            var producto = _repo.ObtenerPorId(id);

            if (producto == null)
                throw new Exception("Producto no encontrado");

            return producto;
        }

        public bool VerificarStock(int productoId, int cantidad)
        {
            var producto = _repo.ObtenerPorId(productoId);

            if (producto == null)
                throw new Exception("Producto no encontrado");

            return producto.Stock >= cantidad;
        }

        public List<Producto> ObtenerProductosBajoStock()
        {
            var productos = _repo.ObtenerTodos();

            return productos
                .Where(p => p.Stock < p.StockMinimo && p.Estado == EstadoProducto.Activo)
                .ToList();
        }

        public List<Producto> ObtenerProductosActivos()
        {
            var productos = _repo.ObtenerTodos();

            return productos
                .Where(p => p.Estado == EstadoProducto.Activo)
                .ToList();
        }

        // Insercion de datos
        public void RegistrarProducto(Producto producto)
        {
            if (string.IsNullOrWhiteSpace(producto.Nombre))
                throw new Exception("El nombre es obligatorio");

            if (producto.PrecioVenta < producto.PrecioCompra)
                throw new Exception("El precio de venta no puede ser menor al de compra");

            if (producto.Stock < 0)
                throw new Exception("El stock no puede ser negativo");
            
            if (producto.ProveedorId.HasValue)
            {
                var proveedor = _repoProveedor.ObtenerPorId(producto.ProveedorId.Value);

                if (proveedor == null)
                    throw new Exception("Proveedor no encontrado");
            }
            producto.Estado = EstadoProducto.Activo;

            _repo.Insertar(producto);
        }


        // Actualizar datos
        public void ActualizarProducto(int id, Producto datos)
        {
            var producto = _repo.ObtenerPorId(id);

            if (producto == null)
                throw new Exception("Producto no encontrado");

            // validaciones
            if (string.IsNullOrWhiteSpace(datos.Nombre))
                throw new Exception("El nombre es obligatorio");

            if (datos.PrecioCompra < 0)
                throw new Exception("El precio de compra no puede ser negativo");

            if (datos.PrecioVenta < 0)
                throw new Exception("El precio de venta no puede ser negativo");

            if (datos.Stock < 0)
                throw new Exception("El stock no puede ser negativo");

            if (datos.StockMinimo < 0)
                throw new Exception("El stock mínimo no puede ser negativo");

            // actualizamos el producto
            producto.Nombre = datos.Nombre;
            producto.Descripcion = datos.Descripcion;
            producto.PrecioCompra = datos.PrecioCompra;
            producto.PrecioVenta = datos.PrecioVenta;
            producto.Stock = datos.Stock;
            producto.StockMinimo = datos.StockMinimo;
            producto.Estado = datos.Estado;

            _repo.Actualizar(producto);

            _context.SaveChanges();
        }

        public void ActualizarStock(int productoId, int cantidad)
        {
            var producto = _repo.ObtenerPorId(productoId);

            if (producto == null)
                throw new Exception("Producto no encontrado");

            if (cantidad < 0)
                throw new Exception("El stock no puede ser negativo");

            if (producto.Stock == cantidad)
                return;
            else
                producto.Stock = cantidad;
                _repo.Actualizar(producto);
        }

        public void IncrementarStock(int productoId, int cantidad)
        {
            var producto = _repo.ObtenerPorId(productoId);

            if (producto == null)
                throw new Exception("Producto no encontrado");

            if (cantidad <= 0)
                throw new Exception("Cantidad inválida");

            producto.Stock += cantidad;

            _repo.Actualizar(producto);
        }

        public void DisminuirStock(int productoId, int cantidad)
        {
            var producto = _repo.ObtenerPorId(productoId);

            if (producto == null)
                throw new Exception("Producto no encontrado");

            if (cantidad <= 0)
                throw new Exception("Cantidad inválida");

            if (producto.Stock < cantidad)
                throw new Exception("Stock insuficiente");

            producto.Stock -= cantidad;

            _repo.Actualizar(producto);
        }

        public void DesactivarProducto(int id)
        {
            var producto = _repo.ObtenerPorId(id);

            if (producto == null)
                throw new Exception("Producto no encontrado");

            if (producto.Estado == EstadoProducto.Inactivo)
                return;

            producto.Estado = EstadoProducto.Inactivo;

            _repo.Actualizar(producto);
        }

        public void ActivarProducto(int id)
        {
            var producto = _repo.ObtenerPorId(id);

            if (producto == null)
                throw new Exception("Producto no encontrado");

            if (producto.Estado == EstadoProducto.Activo)
                return;

            producto.Estado = EstadoProducto.Activo;

            _repo.Actualizar(producto);
        }
        public List<Producto> ObtenerProductosPorProveedor(int proveedorId)
        {
            if (proveedorId <= 0)
                throw new Exception("Proveedor inválido");

            var proveedor = _repoProveedor.ObtenerPorId(proveedorId);

            if (proveedor == null)
                throw new Exception("Proveedor no encontrado");

            return _repo.ObtenerPorProveedor(proveedorId);
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
