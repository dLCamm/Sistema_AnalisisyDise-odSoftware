using Sistema.Entities.Productos;


namespace Sistema.DAL.Repositories.Interfaces
{
    public interface IProductoRepository
    {
        List<Producto> ObtenerTodos();
        void Insertar(Producto producto);
    }
}
