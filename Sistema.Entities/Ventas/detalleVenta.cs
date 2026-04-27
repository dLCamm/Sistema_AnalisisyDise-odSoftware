using System;
using Sistema.Entities.Productos;

namespace Sistema.Entities.Ventas
{
    public class DetalleVenta
    {
        public int Id { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
       
        public decimal Subtotal => PrecioUnitario * Cantidad;

        // FK
        public int VentaId { get; set; }
        public int ProductoId { get; set; }

        // Navegación
        public Venta Venta { get; set; } = null!;
        public Producto Producto { get; set; } = null!;
    }
}
