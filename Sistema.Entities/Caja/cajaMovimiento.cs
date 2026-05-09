namespace Sistema.Entities.Caja
{
    public class MovimientoCaja
    {
        public int Id { get; set; }

        public TipoMovimientoCaja Tipo { get; set; }

        public decimal Monto { get; set; }

        public OrigenMovimientoCaja Origen { get; set; }

        public string Descripcion { get; set; } = string.Empty;

        public DateTime Fecha { get; private set; } = DateTime.Now;

        public EstadoMovimientoCaja Estado { get; set; }

        // Usuario que realizo el movimiento
        public int? UsuarioId { get; set; }
    }
}