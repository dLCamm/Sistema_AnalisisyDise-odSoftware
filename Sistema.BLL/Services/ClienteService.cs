using Sistema.DAL.Data;
using Sistema.DAL.Repositories.Interfaces;
using Sistema.Entities.Clientes;
using Sistema.Entities.Productos;


namespace Sistema.BLL.Services
{
    public class ClienteService : IDisposable
    {
        private readonly SistemaDbContext _context;
        private readonly IClienteRepository _repo;

        public ClienteService(SistemaDbContext context, IClienteRepository repo)
        {
            _context = context;
            _repo = repo;
        }

        // Crear
        public void CrearCliente(Cliente nuevocliente)
        {
            if (string.IsNullOrWhiteSpace(nuevocliente.Nombre))
                throw new Exception("El nombre es obligatorio");

            var cliente = new Cliente
            {
                Nombre = nuevocliente.Nombre,
                Telefono = nuevocliente.Telefono,
                Direccion = nuevocliente.Direccion,
                Email = nuevocliente.Email,
                Estado = nuevocliente.Estado,
                FechaRegistro = DateTime.Now
            };

            _repo.Insertar(cliente);
        }

        // Actualizar
        public void ActualizarCliente(Cliente antiguocliente)
        {
            var cliente = _repo.ObtenerPorId(antiguocliente.Id);

            if (cliente == null)
                throw new Exception("Cliente no encontrado");

            cliente.Nombre = antiguocliente.Nombre;
            cliente.Telefono = antiguocliente.Telefono;
            cliente.Direccion = antiguocliente.Email;
            cliente.Email = antiguocliente.Email;

            _repo.Actualizar(cliente);
        }

        // Anular
        public void AnularCliente(int id)
        {
            var cliente = _repo.ObtenerPorId(id);

            if (cliente == null)
                throw new Exception("Cliente no encontrado");

            cliente.Estado = EstadoCliente.Inactivo;

            _repo.Actualizar(cliente);
        }

        // Listar
        public List<Cliente> ListarClientes()
        {
            return _repo.ObtenerTodos();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        // Listar por estado  
        public List<Cliente> ObtenerClientesActivos()
        {
            return _repo.ObtenerPorEstado(EstadoCliente.Activo);
        }

        public List<Cliente> ObtenerClientesInactivos()
        {
            return _repo.ObtenerPorEstado(EstadoCliente.Inactivo);
        }
    }
    }
}
