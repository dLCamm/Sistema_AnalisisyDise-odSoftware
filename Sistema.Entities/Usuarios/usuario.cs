using Sistema.Entities.Clientes;
using System;

namespace Sistema.Entities.Usuarios
{
    public class Usuario
    {
        public int Id{ get; set; }

        public string Username { get; set; }
        public string Password { get; set; }
        public string Rol { get; set; }
        public EstadoCliente Estado { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
