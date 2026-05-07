using Sistema.Entities.Clientes;
using Sistema.Entities.Ventas;
namespace Sistema.Entities.Creditos
{
    public class Credito
    {
        public int Id { get; set; }

        public decimal TotalCredito { get; set; }

        public decimal SaldoPendiente { get; set; }

        public DateTime FechaInicio { get; private set; } = DateTime.Now;

        public EstadoCredito Estado { get; set; }

        // FK
        public int VentaId { get; set; }

        public int ClienteId { get; set; }

        // Navegación
        public Venta Venta { get; set; } = null!;

        public Cliente Cliente { get; set; } = null!;

        public ICollection<Abono> Abonos { get; set; } = new List<Abono>();
    }
}
