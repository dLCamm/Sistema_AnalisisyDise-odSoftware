using Sistema.Entities.Productos;

namespace Sistema.Entities.Compras
{
    public class DetalleCompra
    {
        public int Id { get; set; }

        public int Cantidad { get; set; }

        public decimal PrecioCompra { get; set; }

        public decimal Subtotal { get; set; }

        // FK
        public int CompraId { get; set; }

        public int ProductoId { get; set; }

        // Navegación
        public Compra Compra { get; set; } = null!;

        public Producto Producto { get; set; } = null!;
    }
}
