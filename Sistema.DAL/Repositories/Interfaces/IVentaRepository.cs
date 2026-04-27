using Sistema.Entities.Ventas;

namespace Sistema.DAL.Repositories.Interfaces
{
    public interface IVentaRepository
    {
        void InsertarVenta(Venta venta);
        void InsertarDetalles(List<DetalleVenta> detalles);

        Venta? ObtenerPorId(int id);
        List<Venta> ObtenerTodos();
        List<Venta> ObtenerPorEstado(EstadoVenta estado);

        void Actualizar(Venta venta);
    }
}
