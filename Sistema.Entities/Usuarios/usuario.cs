using Sistema.Entities.Clientes;
using System;

namespace Sistema.Entities.Usuarios
{
    public class Usuario
    {
        public int Id{ get; set; }
        public string Nombre { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public RolUsuario Rol { get; set; }
        public EstadoUsuario Estado { get; set; }
        public DateTime FechaCreacion { get; private set; } = DateTime.Now;
    }
}
