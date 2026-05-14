using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.BLL.DTOs.Ventas
{
    public class ProductoMasVendidoDTO
    {
        public int ProductoId { get; set; }

        public string NombreProducto { get; set; } = string.Empty;

        public int CantidadVendida { get; set; }

        public decimal TotalGenerado { get; set; }
    }
}
