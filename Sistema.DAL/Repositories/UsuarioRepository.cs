using Sistema.DAL.Data;
using Sistema.DAL.Repositories.Interfaces;
using Sistema.Entities.Usuarios;

namespace Sistema.DAL.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly SistemaDbContext _context;

        public UsuarioRepository(SistemaDbContext context)
        {
            _context = context;
        }

        // INSERTAR
        public void Insertar(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
        }

        // ACTUALIZAR
        public void Actualizar(Usuario usuario)
        {
            _context.Usuarios.Update(usuario);
        }

        // OBTENER POR ID
        public Usuario? ObtenerPorId(int id)
        {
            return _context.Usuarios
                .FirstOrDefault(u => u.Id == id);
        }

        // OBTENER POR USERNAME
        public Usuario? ObtenerPorUsername(string username)
        {
            return _context.Usuarios
                .FirstOrDefault(u =>
                    u.Username == username);
        }

        // OBTENER TODOS
        public List<Usuario> ObtenerTodos()
        {
            return _context.Usuarios
                .OrderBy(u => u.Nombre)
                .ToList();
        }

        // OBTENER POR ESTADO
        public List<Usuario> ObtenerPorEstado(
            EstadoUsuario estado)
        {
            return _context.Usuarios
                .Where(u => u.Estado == estado)
                .OrderBy(u => u.Nombre)
                .ToList();
        }
    }
}
