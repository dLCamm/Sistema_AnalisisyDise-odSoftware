using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.Entities
{
    public class Producto
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public decimal PrecioCompra { get; set; }

        public decimal PrecioVenta { get; set; }

        public int Stock { get; set; }

        public int StockMinimo { get; set; }

        public DateTime FechaCreacion { get; set; } = DateTime.Now;

        public string Estado { get; set; }
    }
}