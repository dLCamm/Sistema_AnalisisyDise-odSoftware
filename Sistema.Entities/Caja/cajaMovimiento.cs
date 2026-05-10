using Sistema.Entities.Usuarios;

namespace Sistema.Entities.Caja
{
    public class MovimientoCaja
    {
        public int Id { get; set; }

        public TipoMovimientoCaja Tipo { get; set; }

        public decimal Monto { get; set; }

        public OrigenMovimientoCaja Origen { get; set; }

        public int ReferenciaId { get; set; }

        public string Descripcion { get; set; } = string.Empty;

        public DateTime Fecha { get; private set; } = DateTime.Now;

        public EstadoMovimientoCaja Estado { get; set; }

        // FK
        public int? UsuarioId { get; set; }

        // Navegación
        public Usuario? Usuario { get; set; }
    }
}