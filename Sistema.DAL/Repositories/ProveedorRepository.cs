using Sistema.DAL.Data;
using Sistema.DAL.Repositories.Interfaces;
using Sistema.Entities.Proveedores;
using Microsoft.EntityFrameworkCore;


namespace Sistema.DAL.Repositories
{
    public class ProveedorRepository : IProveedorRepository
    {
        private readonly SistemaDbContext _context;

        public ProveedorRepository(SistemaDbContext context)
        {
            _context = context;
        }

        // OBTENER POR ID
        public Proveedor? ObtenerPorId(int id)
        {
            return _context.Proveedores
                .FirstOrDefault(p => p.Id == id);
        }

        // LISTAR TODOS
        public List<Proveedor> ObtenerTodos()
        {
            return _context.Proveedores.ToList();
        }

        // INSERTAR
        public void Insertar(Proveedor proveedor)
        {
            _context.Proveedores.Add(proveedor);
        }

        // ACTUALIZAR
        public void Actualizar(Proveedor proveedor)
        {
            _context.Proveedores.Update(proveedor);
        }
    }
}
