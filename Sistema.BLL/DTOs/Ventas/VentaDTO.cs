using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.BLL.DTOs.Ventas
{
    public class VentaDTO
    {
        public int VentaId { get; set; }

        public string Cliente { get; set; } = string.Empty;

        public string Usuario { get; set; } = string.Empty;

        public decimal Total { get; set; }

        public string TipoPago { get; set; } = string.Empty;

        public string Estado { get; set; } = string.Empty;

        public DateTime Fecha { get; set; }
    }
}
