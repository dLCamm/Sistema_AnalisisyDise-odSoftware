using Sistema.DAL.Data;
using Sistema.DAL.Repositories.Interfaces;
using Sistema.Entities.Productos;

namespace Sistema.BLL.Services
{
    public class InventarioService : IDisposable
    {
        private readonly SistemaDbContext _context;
        private readonly IProductoRepository _repo;

        public InventarioService(SistemaDbContext context, IProductoRepository repo)
        {
            _context = context;
            _repo = repo;
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
                .Where(p => p.Stock < p.StockMinimo && p.Estado == "Activo")
                .ToList();
        }

        public List<Producto> ObtenerProductosActivos()
        {
            var productos = _repo.ObtenerTodos();

            return productos
                .Where(p => p.Stock < p.StockMinimo && p.Estado == "Activo")
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

            producto.Estado = "Activo";
            producto.FechaCreacion = DateTime.Now;

            _repo.Insertar(producto);
        }


        // Actualizar datos
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

            if (producto.Estado == "Inactivo")
                return;

            producto.Estado = "Inactivo";

            _repo.Actualizar(producto);
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
