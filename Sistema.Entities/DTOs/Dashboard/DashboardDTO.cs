using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.Entities.DTOs.Dashboard
{
    public class DashboardDTO
    {
        public decimal VentasHoy { get; set; }

        public decimal CajaActual { get; set; }

        public decimal CreditosPendientes { get; set; }

        public int ProductosBajoStock { get; set; }

        public decimal IngresosHoy { get; set; }

        public decimal EgresosHoy { get; set; }
    }
}
