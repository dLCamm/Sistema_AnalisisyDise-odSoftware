using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.Entities.DTOs.Ventas
{
    public class DetalleVentaDTO
    {
        public int ProductoId { get; set; }

        public string Producto { get; set; } = string.Empty;

        public int Cantidad { get; set; }

        public decimal PrecioUnitario { get; set; }

        public decimal Subtotal { get; set; }
    }
}
