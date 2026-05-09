    namespace Sistema.Entities.Creditos
    {
        public class Abono
        {
            public int Id { get; set; }

            public decimal Monto { get; set; }

            public DateTime Fecha { get; private set; } = DateTime.Now;

            public EstadoAbono Estado { get; set; }


        // FK
        public int CreditoId { get; set; }

            // Navegación
            public Credito Credito { get; set; } = null!;
        }
    }
