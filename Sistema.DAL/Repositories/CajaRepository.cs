using Sistema.DAL.Data;
using Sistema.DAL.Repositories.Interfaces;
using Sistema.Entities.Caja;

namespace Sistema.DAL.Repositories
{
    public class CajaRepository : ICajaRepository
    {
        private readonly SistemaDbContext _context;

        public CajaRepository(SistemaDbContext context)
        {
            _context = context;
        }

        public void Insertar(MovimientoCaja movimiento)
        {
            _context.Caja.Add(movimiento);
        }

        public MovimientoCaja? ObtenerPorId(int id)
        {
            return _context.Caja
                .FirstOrDefault(c => c.Id == id);
        }

        public List<MovimientoCaja> ObtenerTodos()
        {
            return _context.Caja
                .OrderByDescending(c => c.Fecha)
                .ToList();
        }

        public List<MovimientoCaja> ObtenerPorTipo(TipoMovimientoCaja tipo)
        {
            return _context.Caja
                .Where(c => c.Tipo == tipo)
                .OrderByDescending(c => c.Fecha)
                .ToList();
        }

        public List<MovimientoCaja> FiltrarPorFecha(
            DateTime fechaInicio,
            DateTime fechaFin)
        {
            return _context.Caja
                .Where(c =>
                    c.Fecha >= fechaInicio &&
                    c.Fecha <= fechaFin)
                .OrderByDescending(c => c.Fecha)
                .ToList();
        }

        public void Actualizar(MovimientoCaja movimiento)
        {
            _context.Caja.Update(movimiento);
        }

        public List<MovimientoCaja> ObtenerPorEstado(EstadoMovimientoCaja estado)
        {
            return _context.Caja
                .Where(c => c.Estado == estado)
                .OrderByDescending(c => c.Fecha)
                .ToList();
        }

        public List<MovimientoCaja> ObtenerPorOrigen(OrigenMovimientoCaja origen)
        {
            return _context.Caja
                .Where(c => c.Origen == origen)
                .OrderByDescending(c => c.Fecha)
                .ToList();
        }
        public decimal ObtenerTotalIngresosActivos()
        {
            return _context.Caja
                .Where(c =>
                    c.Estado == EstadoMovimientoCaja.Activo &&
                    c.Tipo == TipoMovimientoCaja.Ingreso)
                .Sum(c => c.Monto);
        }

        public decimal ObtenerTotalEgresosActivos()
        {
            return _context.Caja
                .Where(c =>
                    c.Estado == EstadoMovimientoCaja.Activo &&
                    c.Tipo == TipoMovimientoCaja.Egreso)
                .Sum(c => c.Monto);
        }

        public MovimientoCaja? ObtenerPorReferencia(
            OrigenMovimientoCaja origen,
            int referenciaId)
        {
            return _context.Caja
                .FirstOrDefault(c =>
                    c.Origen == origen &&
                    c.ReferenciaId == referenciaId);
        }
    }
}
