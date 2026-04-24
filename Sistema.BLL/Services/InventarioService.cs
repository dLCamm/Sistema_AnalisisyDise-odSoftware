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

        public List<Producto> ListarProductos()
        {
            return _repo.ObtenerTodos();
        }

        public void RegistrarProducto(Producto producto)
        {
            // VALIDACIONES
            if (string.IsNullOrWhiteSpace(producto.Nombre))
                throw new Exception("El nombre es obligatorio");

            if (producto.PrecioVenta < producto.PrecioCompra)
                throw new Exception("El precio de venta no puede ser menor al de compra");

            if (producto.Stock < 0)
                throw new Exception("El stock no puede ser negativo");

            // Valores por defecto
            producto.Estado = "Activo";
            producto.FechaCreacion = DateTime.Now;

            // Guardar
            _repo.Insertar(producto);
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
