        using Sistema.DAL.Data;
using Sistema.DAL.Repositories.Interfaces;
using Sistema.Entities.Caja;

namespace Sistema.BLL.Services
{
    public class CajaService : IDisposable
    {
        private readonly SistemaDbContext _context;

        private readonly ICajaRepository _repo;

        public CajaService(
            SistemaDbContext context,
            ICajaRepository repo)
        {
            _context = context;
            _repo = repo;
        }

        // INGRESO
        public void RegistrarIngreso(
            decimal monto,
            OrigenMovimientoCaja origen,
            string descripcion,
            int? usuarioId = null)
        {
            if (monto <= 0)
                throw new Exception("Monto inválido");

            var movimiento = new MovimientoCaja
            {
                Tipo = TipoMovimientoCaja.Ingreso,
                Monto = monto,
                Origen = origen,
                Descripcion = descripcion,
                Estado = EstadoMovimientoCaja.Activo,
                UsuarioId = usuarioId
            };

            _repo.Insertar(movimiento);

            _context.SaveChanges();
        }

        // EGRESO
        public void RegistrarEgreso(
            decimal monto,
            OrigenMovimientoCaja origen,
            string descripcion,
            int referenciaID,
            int? usuarioId = null)
        {
            if (monto <= 0)
                throw new Exception("Monto inválido");

            var movimiento = new MovimientoCaja
            {
                Tipo = TipoMovimientoCaja.Egreso,
                Monto = monto,
                Origen = origen,
                Descripcion = descripcion,
                ReferenciaId = referenciaID,
                Estado = EstadoMovimientoCaja.Activo,
                UsuarioId = usuarioId
            };

            _repo.Insertar(movimiento);

            // NO SE HACE SAVECHANGES TENERLO EN CUENTA
        }

        // OBTENER MOVIMIENTO
        public MovimientoCaja ObtenerMovimiento(int id)
        {
            var movimiento = _repo.ObtenerPorId(id);

            if (movimiento == null)
                throw new Exception("Movimiento no encontrado");

            return movimiento;
        }

        // LISTAR TODOS
        public List<MovimientoCaja> ListarMovimientos()
        {
            return _repo.ObtenerTodos();
        }

        // LISTAR INGRESOS
        public List<MovimientoCaja> ListarIngresos()
        {
            return _repo.ObtenerPorTipo(
                TipoMovimientoCaja.Ingreso);
        }

        // LISTAR EGRESOS
        public List<MovimientoCaja> ListarEgresos()
        {
            return _repo.ObtenerPorTipo(
                TipoMovimientoCaja.Egreso);
        }

        // FILTRAR FECHAS
        public List<MovimientoCaja> FiltrarPorFecha(
            DateTime fechaInicio,
            DateTime fechaFin)
        {
            return _repo.FiltrarPorFecha(
                fechaInicio,
                fechaFin);
        }

        // OBTENER SALDO
        public decimal ObtenerSaldo()
        {
            decimal ingresos =
                _repo.ObtenerTotalIngresosActivos();

            decimal egresos =
                _repo.ObtenerTotalEgresosActivos();

            return ingresos - egresos;
        }

        // ANULAR
        public void AnularMovimiento(int id)
        {
            var movimiento = _repo.ObtenerPorId(id);

            if (movimiento == null)
                throw new Exception("Movimiento no encontrado");

            if (movimiento.Estado ==
                EstadoMovimientoCaja.Anulado)
                return;

            movimiento.Estado =
                EstadoMovimientoCaja.Anulado;

            _repo.Actualizar(movimiento);

            _context.SaveChanges();
        }

        public void AnularPorOrigen(
            OrigenMovimientoCaja origen,
            int referenciaId)
        {
            var movimiento = _repo.ObtenerPorReferencia(
                origen,
                referenciaId);

            if (movimiento == null)
                return;

            if (movimiento.Estado ==
                EstadoMovimientoCaja.Anulado)
                return;

            movimiento.Estado =
                EstadoMovimientoCaja.Anulado;

            _repo.Actualizar(movimiento);
        }

        // FILTRAR POR ORIGEN
        public List<MovimientoCaja> FiltrarPorOrigen(OrigenMovimientoCaja origen)
        {
            return _repo.ObtenerPorOrigen(origen);
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
