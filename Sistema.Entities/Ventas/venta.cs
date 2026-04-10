namespace Sistema.Entities.Ventas
{
    public class Venta
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string TipoPago { get; set; } = string.Empty;
        public decimal Total { get; set; }
        public string Estado { get; set; } = string.Empty;

        // FK
        public int ClienteId { get; set; }
        public int UsuarioId { get; set; }

        // Navegación (crear entidad cliente y usuario)
        // public Cliente Cliente { get; set; } = null!;
        // public Usuario Usuario { get; set; } = null!;
        public ICollection<DetalleVenta> Detalles { get; set; } = new List<DetalleVenta>();
    }
}
