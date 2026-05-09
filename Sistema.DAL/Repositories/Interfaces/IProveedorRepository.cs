using Sistema.Entities.Proveedores;

namespace Sistema.DAL.Repositories.Interfaces
{
    public interface IProveedorRepository
    {
        Proveedor? ObtenerPorId(int id);

        List<Proveedor> ObtenerTodos();

        void Insertar(Proveedor proveedor);

        void Actualizar(Proveedor proveedor);

        List<Proveedor> ObtenerPorEstado(EstadoProveedor estado);
    }
}
