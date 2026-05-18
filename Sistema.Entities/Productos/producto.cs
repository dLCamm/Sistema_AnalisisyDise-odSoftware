using Sistema.Entities.Proveedores;

namespace Sistema.Entities.Productos
{
    public class Producto
    {
        public int Id { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public string Descripcion { get; set; } = string.Empty;

        public decimal PrecioCompra { get; set; }

        public decimal PrecioVenta { get; set; }

        public int Stock { get; set; }

        public int StockMinimo { get; set; }

        public DateTime FechaCreacion { get; private set; }
            = DateTime.Now;

        public EstadoProducto Estado { get; set; }

        // FK
        public int? ProveedorId { get; set; }

        // NAVEGACIÓN

        public Proveedor? Proveedor { get; set; }
    }
}