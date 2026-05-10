using Sistema.DAL.Data;
using Sistema.DAL.Repositories.Interfaces;
using Sistema.Entities.Usuarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.DAL.Repositories
{
    public class UsuarioService : IDisposable
    {
        private readonly SistemaDbContext _context;

        private readonly IUsuarioRepository _repo;

        public UsuarioService(
            SistemaDbContext context,
            IUsuarioRepository repo)
        {
            _context = context;
            _repo = repo;
        }

        // CREAR
        public void CrearUsuario(
            string nombre,
            string username,
            string password,
            RolUsuario rol)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new Exception("Nombre inválido");

            if (string.IsNullOrWhiteSpace(username))
                throw new Exception("Username inválido");

            if (string.IsNullOrWhiteSpace(password))
                throw new Exception("Password inválida");

            var existe = _repo.ObtenerPorUsername(username);

            if (existe != null)
                throw new Exception("El username ya existe");

            var usuario = new Usuario
            {
                Nombre = nombre,
                Username = username,

                // luego usar hash
                Password = password,

                Rol = rol,
                Estado = EstadoUsuario.Activo
            };

            _repo.Insertar(usuario);

            _context.SaveChanges();
        }

        // ACTUALIZAR
        public void ActualizarUsuario(Usuario datos)
        {
            var usuario = _repo.ObtenerPorId(datos.Id);

            if (usuario == null)
                throw new Exception("Usuario no encontrado");

            usuario.Nombre = datos.Nombre;
            usuario.Username = datos.Username;
            usuario.Rol = datos.Rol;

            _repo.Actualizar(usuario);

            _context.SaveChanges();
        }

        // CAMBIAR PASSWORD
        public void CambiarPassword(
            int usuarioId,
            string nuevaPassword)
        {
            var usuario = _repo.ObtenerPorId(usuarioId);

            if (usuario == null)
                throw new Exception("Usuario no encontrado");

            usuario.Password = nuevaPassword;

            _repo.Actualizar(usuario);

            _context.SaveChanges();
        }

        // DESACTIVAR
        public void DesactivarUsuario(int id)
        {
            var usuario = _repo.ObtenerPorId(id);

            if (usuario == null)
                throw new Exception("Usuario no encontrado");

            usuario.Estado = EstadoUsuario.Inactivo;

            _repo.Actualizar(usuario);

            _context.SaveChanges();
        }

        // OBTENER
        public Usuario ObtenerUsuario(int id)
        {
            var usuario = _repo.ObtenerPorId(id);

            if (usuario == null)
                throw new Exception("Usuario no encontrado");

            return usuario;
        }

        // USERNAME
        public Usuario ObtenerPorUsername(string username)
        {
            var usuario = _repo.ObtenerPorUsername(username);

            if (usuario == null)
                throw new Exception("Usuario no encontrado");

            return usuario;
        }

        // LISTAR
        public List<Usuario> ListarUsuarios()
        {
            return _repo.ObtenerTodos();
        }

        public List<Usuario> ListarActivos()
        {
            return _repo.ObtenerPorEstado(
                EstadoUsuario.Activo);
        }

        public List<Usuario> ListarInactivos()
        {
            return _repo.ObtenerPorEstado(
                EstadoUsuario.Inactivo);
        }

        // LOGIN
        public Usuario ValidarLogin(
            string username,
            string password)
        {
            var usuario = _repo.ObtenerPorUsername(username);

            if (usuario == null)
                throw new Exception("Usuario inválido");

            if (usuario.Estado ==
                EstadoUsuario.Inactivo)
            {
                throw new Exception("Usuario inactivo");
            }

            // luego usar hash
            if (usuario.Password != password)
                throw new Exception("Password incorrecta");

            return usuario;
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
