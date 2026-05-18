using Sistema.Entities.Productos;


namespace Sistema.DAL.Repositories.Interfaces
{
    public interface IProductoRepository
    {
        // Funcion para listar productos
        List<Producto> ObtenerTodos();

        // Funcion para insertar productos
        void Insertar(Producto producto);

        // Funcion para buscar un producto por id
        Producto? ObtenerPorId(int id);

        // Funcion para actualizar un producto
        void Actualizar(Producto producto);

        // Funcion para buscar una lista de productos por una lista de ids
        List<Producto> ObtenerPorIds(List<int> ids);

        // Buscar por proveedor
        List<Producto> ObtenerPorProveedor(int proveedorId);
    }
}
