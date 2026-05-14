using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.BLL.DTOs.Creditos
{
    public class AbonoDTO
    {
        public int AbonoId { get; set; }

        public int CreditoId { get; set; }

        public string Cliente { get; set; } = string.Empty;

        public decimal Monto { get; set; }

        public string Estado { get; set; } = string.Empty;

        public DateTime Fecha { get; set; }
    }
}
