using Sistema.DAL.Data;
using Sistema.DAL.Repositories.Interfaces;
using Sistema.Entities.Compras;
using Microsoft.EntityFrameworkCore;

namespace Sistema.DAL.Repositories
{
    public class CompraRepository : ICompraRepository
    {
        private readonly SistemaDbContext _context;

        public CompraRepository(SistemaDbContext context)
        {
            _context = context;
        }

        // INSERTAR
        public void InsertarCompra(Compra compra)
        {
            _context.Compras.Add(compra);
        }

        // OBTENER POR ID
        public Compra? ObtenerPorId(int id)
        {
            return _context.Compras
                .Include(c => c.Proveedor)
                .Include(c => c.Detalles)
                    .ThenInclude(d => d.Producto)
                .FirstOrDefault(c => c.Id == id);
        }

        // LISTAR TODOS
        public List<Compra> ObtenerTodos()
        {
            return _context.Compras
                .Include(c => c.Proveedor)
                .Include(c => c.Detalles)
                .ToList();
        }

        // FILTRAR POR ESTADO
        public List<Compra> ObtenerPorEstado(EstadoCompra estado)
        {
            return _context.Compras
                .Include(c => c.Proveedor)
                .Include(c => c.Detalles)
                .Where(c => c.Estado == estado)
                .ToList();
        }

        // ACTUALIZAR
        public void Actualizar(Compra compra)
        {
            _context.Compras.Update(compra);
        }
    }
}
