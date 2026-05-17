using Sistema.Entities.Compras;
using Sistema.Entities.Productos;

namespace Sistema.Entities.Proveedores
{
    public class Proveedor
    {
        public int Id { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public string DPI { get; set; } = string.Empty;

        public string Telefono { get; set; } = string.Empty;

        public string Direccion { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public EstadoProveedor Estado { get; set; }

        // Navegación
        public ICollection<Compra> Compras { get; set; } = new List<Compra>();
        public ICollection<Producto> Productos { get; set; } = new List<Producto>();
    }
}
