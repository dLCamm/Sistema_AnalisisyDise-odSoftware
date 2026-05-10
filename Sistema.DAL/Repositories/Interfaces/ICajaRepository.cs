using Sistema.Entities.Caja;

namespace Sistema.DAL.Repositories.Interfaces
{
    public interface ICajaRepository
    {
        void Insertar(MovimientoCaja movimiento);

        MovimientoCaja? ObtenerPorId(int id);

        List<MovimientoCaja> ObtenerTodos();

        List<MovimientoCaja> ObtenerPorTipo(TipoMovimientoCaja tipo);

        List<MovimientoCaja> FiltrarPorFecha(
            DateTime fechaInicio,
            DateTime fechaFin);

        void Actualizar(MovimientoCaja movimiento);

        List<MovimientoCaja> ObtenerPorEstado(EstadoMovimientoCaja estado);

        List<MovimientoCaja> ObtenerPorOrigen(OrigenMovimientoCaja origen);

        decimal ObtenerTotalIngresosActivos();

        decimal ObtenerTotalEgresosActivos();

        MovimientoCaja? ObtenerPorReferencia(
            OrigenMovimientoCaja origen,
            int referenciaId);
    }
}
