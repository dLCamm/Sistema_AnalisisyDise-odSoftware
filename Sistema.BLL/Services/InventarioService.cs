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

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
