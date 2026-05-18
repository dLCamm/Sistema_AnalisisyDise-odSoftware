using Sistema.Entities.DTOs.Caja;
using Sistema.Entities.DTOs.Compras;
using Sistema.Entities.DTOs.Creditos;
using Sistema.Entities.DTOs.Dashboard;
using Sistema.Entities.DTOs.Inventario;
using Sistema.Entities.DTOs.Ventas;


namespace Sistema.DAL.Repositories.Interfaces
{
    public interface IReporteRepository
    {
        // =========================
        // COMPRAS
        // =========================
        List<CompraReporteDTO>
            ObtenerComprasPorFecha(
            DateTime fechaInicio,
            DateTime fechaFin);

        decimal ObtenerTotalCompras(
            DateTime fechaInicio,
            DateTime fechaFin);

        List<CompraPorDiaDTO>
            ObtenerComprasPorDia(
            DateTime fechaInicio,
            DateTime fechaFin);

        // =========================
        // VENTAS
        // =========================
        List<ProductoMasVendidoDTO> ObtenerProductosMasVendidos(
            DateTime fechaInicio,
            DateTime fechaFin);

        List<VentaPorDiaDTO> ObtenerVentasPorDia(
            DateTime fechaInicio,
            DateTime fechaFin);

        // =========================
        // CAJA
        // =========================

        decimal ObtenerBalanceCaja(
            DateTime fechaInicio,
            DateTime fechaFin);

        List<CajaPorDiaDTO> ObtenerCajaPorDia(
            DateTime fechaInicio,
            DateTime fechaFin);

        // =========================
        // CRÉDITOS
        // =========================

        List<CreditoDTO> ObtenerCreditosVencidos();

        List<CreditoDTO> ObtenerClientesConDeuda();

        // =========================
        // INVENTARIO
        // =========================

        List<ProductoInventarioDTO> ObtenerProductosBajoStock(
            int stockMinimo);

        // =========================
        // DASHBOARD
        // =========================

        DashboardDTO ObtenerDashboard();
    }
}
