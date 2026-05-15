using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.Entities.DTOs.Compras
{
    public class CompraDTO
    {
        public int CompraId { get; set; }

        public string Proveedor { get; set; } = string.Empty;

        public decimal Total { get; set; }

        public string Estado { get; set; } = string.Empty;

        public DateTime Fecha { get; set; }
    }
}
