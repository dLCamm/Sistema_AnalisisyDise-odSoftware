using Sistema.DAL.Data;
using Sistema.DAL.Repositories.Interfaces;
using Sistema.Entities.Creditos;
using Microsoft.EntityFrameworkCore;

namespace Sistema.DAL.Repositories
{
    public class CreditoRepository : ICreditoRepository
    {
        private readonly SistemaDbContext _context;

        public CreditoRepository(SistemaDbContext context)
        {
            _context = context;
        }

        public void Insertar(Credito credito)
        {
            _context.Creditos.Add(credito);
        }

        public void InsertarAbono(Abono abono)
        {
            _context.Abonos.Add(abono);
        }

        public Credito? ObtenerPorId(int id)
        {
            return _context.Creditos
                .Include(c => c.Cliente)
                .Include(c => c.Venta)
                .Include(c => c.Abonos)
                .FirstOrDefault(c => c.Id == id);
        }

        public List<Credito> ObtenerTodos()
        {
            return _context.Creditos
                .Include(c => c.Cliente)
                .Include(c => c.Venta)
                .ToList();
        }

        public List<Credito> ObtenerPorEstado(EstadoCredito estado)
        {
            return _context.Creditos
                .Where(c => c.Estado == estado)
                .ToList();
        }

        public void Actualizar(Credito credito)
        {
            _context.Creditos.Update(credito);
        }

        public Abono? ObtenerAbonoPorId(int id)
        {
            return _context.Abonos
                .Include(a => a.Credito)
                .FirstOrDefault(a => a.Id == id);
        }
    }
}
