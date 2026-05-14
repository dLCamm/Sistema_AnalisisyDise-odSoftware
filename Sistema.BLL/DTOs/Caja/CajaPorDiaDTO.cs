using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.BLL.DTOs.Caja
{
    public class CajaPorDiaDTO
    {
        public DateTime Fecha { get; set; }
        public decimal Ingresos { get; set; }
        public decimal Egresos { get; set; }
    }
}
