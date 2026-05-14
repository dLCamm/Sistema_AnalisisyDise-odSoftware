using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.BLL.DTOs.Creditos
{
    public class CreditoDTO
    {
        public int CreditoId { get; set; }

        public string Cliente { get; set; } = string.Empty;

        public decimal TotalCredito { get; set; }

        public decimal SaldoPendiente { get; set; }

        public string Estado { get; set; } = string.Empty;

        public DateTime FechaInicio { get; set; }

        public DateTime FechaVencimiento { get; set; }
    }
}
