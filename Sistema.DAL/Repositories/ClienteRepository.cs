using Sistema.DAL.Data;
using Sistema.DAL.Repositories.Interfaces;
using Sistema.Entities.Clientes;
using Sistema.Entities.Productos;

namespace Sistema.DAL.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly SistemaDbContext _context;

        public ClienteRepository(SistemaDbContext context)
        {
            _context = context;
        }

        public void Insertar(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
        }

        public void Actualizar(Cliente cliente)
        {
            _context.Clientes.Update(cliente);
            _context.SaveChanges();
        }

        public Cliente? ObtenerPorId(int id)
        {
            return _context.Clientes
                .FirstOrDefault(c => c.Id == id);
        }

        public List<Cliente> ObtenerTodos()
        {
            return _context.Clientes.ToList();
        }

        public List<Cliente> ObtenerPorEstado(EstadoCliente estado)
        {
            return _context.Clientes
                .Where(c => c.Estado == estado)
                .ToList();
        }
    }
}
