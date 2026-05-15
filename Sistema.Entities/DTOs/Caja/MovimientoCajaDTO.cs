using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.Entities.DTOs.Caja
{
    public class MovimientoCajaDTO
    {
        public int MovimientoId { get; set; }

        public string Tipo { get; set; } = string.Empty;

        public string Origen { get; set; } = string.Empty;

        public string Estado { get; set; } = string.Empty;

        public decimal Monto { get; set; }

        public string Descripcion { get; set; } = string.Empty;

        public DateTime Fecha { get; set; }

        public string Usuario { get; set; } = string.Empty;
    }
}
