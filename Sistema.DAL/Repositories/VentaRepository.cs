using Microsoft.EntityFrameworkCore;
using Sistema.DAL.Data;
using Sistema.DAL.Repositories.Interfaces;
using Sistema.Entities.Ventas;

namespace Sistema.DAL.Repositories
{
    public class VentaRepository : IVentaRepository
    {
        private readonly SistemaDbContext _context;

        public VentaRepository(SistemaDbContext context)
        {
            _context = context;
        }

        // Insertar venta
        public void InsertarVenta(Venta venta)
        {
            _context.Ventas.Add(venta);
        }

        // Insertar detalles
        public void InsertarDetalles(List<DetalleVenta> detalles)
        {
            _context.DetalleVentas.AddRange(detalles);
        }

        // 🔍 Obtener por ID
        public Venta? ObtenerPorId(int id)
        {
            return _context.Ventas
                .Include(v => v.Detalles)
                .FirstOrDefault(v => v.Id == id);
        }

        // Listar todas
        public List<Venta> ObtenerTodos()
        {
            return _context.Ventas
                .Include(v => v.Detalles)
                .ToList();
        }

        // Filtrar por estado
        public List<Venta> ObtenerPorEstado(EstadoVenta estado)
        {
            return _context.Ventas
                .Include(v => v.Detalles)
                .Where(v => v.Estado == estado)
                .ToList();
        }

        // Actualizar
        public void Actualizar(Venta venta)
        {
            _context.Ventas.Update(venta);
        }
    }
}
