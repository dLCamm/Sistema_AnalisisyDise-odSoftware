using Sistema.Entities.Proveedores;

namespace Sistema.Entities.Compras
{
    public class Compra
    {
        public int Id { get; set; }

        public decimal Total { get; set; }

        public DateTime Fecha { get; private set; } = DateTime.Now;

        public EstadoCompra Estado { get; set; }

        public ICollection<DetalleCompra> Detalles { get; set; } = new List<DetalleCompra>();
    }
}
