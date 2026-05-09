using Sistema.Entities.Compras;

namespace Sistema.DAL.Repositories.Interfaces
{
    public interface ICompraRepository
    {
        void InsertarCompra(Compra compra);

        Compra? ObtenerPorId(int id);

        List<Compra> ObtenerTodos();

        List<Compra> ObtenerPorEstado(EstadoCompra estado);

        void Actualizar(Compra compra);
    }
}
