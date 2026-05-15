using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.Entities.DTOs.Inventario
{
    public class ProductoInventarioDTO
    {
        public int ProductoId { get; set; }

        public string Producto { get; set; } = string.Empty;

        public string Categoria { get; set; } = string.Empty;

        public int Stock { get; set; }

        public decimal PrecioCompra { get; set; }

        public decimal PrecioVenta { get; set; }

        public bool BajoStock { get; set; }
    }
}
