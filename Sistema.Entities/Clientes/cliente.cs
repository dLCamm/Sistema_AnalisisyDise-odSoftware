using Sistema.Entities.Creditos;
using System;

namespace Sistema.Entities.Clientes
{
    public class Cliente
    {
        public int Id { get; set; }
        public string DPI { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public string Direccion { get; set; } = string.Empty;
        public DateTime FechaRegistro { get; private set; } = DateTime.Now;
        public string Email { get; set; }
        public EstadoCliente Estado { get; set; }

        public ICollection<Credito> Creditos { get; set; } = new List<Credito>();
    }
  
}
