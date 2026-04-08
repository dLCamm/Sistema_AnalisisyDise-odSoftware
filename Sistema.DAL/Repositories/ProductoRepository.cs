using Microsoft.EntityFrameworkCore;
using Sistema.DAL.Data;
using Sistema.DAL.Repositories.Interfaces;
using Sistema.Entities.Productos;

namespace Sistema.DAL.Repositories
{
    public class ProductoRepository : IProductoRepository
    {
        private readonly SistemaDbContext _context;

        public ProductoRepository(SistemaDbContext context)
        {
            _context = context;
        }

        public List<Producto> ObtenerTodos()
        {
            return _context.Productos.ToList();
        }

        public void Insertar(Producto producto)
        {
            _context.Productos.Add(producto);
            _context.SaveChanges();
        }
    }
}
