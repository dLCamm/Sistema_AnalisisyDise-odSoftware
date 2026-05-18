using Sistema.DAL.Repositories.Interfaces;
using Sistema.Entities.DTOs.Caja;
using Sistema.Entities.DTOs.Compras;
using Sistema.Entities.DTOs.Creditos;
using Sistema.Entities.DTOs.Dashboard;
using Sistema.Entities.DTOs.Inventario;
using Sistema.Entities.DTOs.Ventas;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.BLL.Services
{
    public class ReporteService
    {
        private readonly IReporteRepository _repo;

        public ReporteService(IReporteRepository repo)
        {
            _repo = repo;
        }
        // =========================
        // COMPRAS POR FECHA
        // =========================

        public List<CompraReporteDTO>
            ObtenerComprasPorFecha(
            DateTime fechaInicio,
            DateTime fechaFin)
        {
            ValidarFechas(fechaInicio, fechaFin);

            return _repo.ObtenerComprasPorFecha(
                fechaInicio,
                fechaFin);
        }

        // =========================
        // TOTAL COMPRAS
        // =========================

        public decimal ObtenerTotalCompras(
            DateTime fechaInicio,
            DateTime fechaFin)
        {
            ValidarFechas(fechaInicio, fechaFin);

            return _repo.ObtenerTotalCompras(
                fechaInicio,
                fechaFin);
        }

        // =========================
        // COMPRAS POR DÍA
        // =========================

        public List<CompraPorDiaDTO>
            ObtenerComprasPorDia(
            DateTime fechaInicio,
            DateTime fechaFin)
        {
            ValidarFechas(fechaInicio, fechaFin);

            return _repo.ObtenerComprasPorDia(
                fechaInicio,
                fechaFin);
        }

        // =========================
        // PRODUCTOS MÁS VENDIDOS
        // =========================

        public List<ProductoMasVendidoDTO>
            ObtenerProductosMasVendidos(
            DateTime fechaInicio,
            DateTime fechaFin)
        {
            ValidarFechas(fechaInicio, fechaFin);

            return _repo.ObtenerProductosMasVendidos(
                fechaInicio,
                fechaFin);
        }

        // =========================
        // VENTAS POR DÍA
        // =========================

        public List<VentaPorDiaDTO>
            ObtenerVentasPorDia(
            DateTime fechaInicio,
            DateTime fechaFin)
        {
            ValidarFechas(fechaInicio, fechaFin);

            return _repo.ObtenerVentasPorDia(
                fechaInicio,
                fechaFin);
        }

        // =========================
        // BALANCE DE CAJA
        // =========================

        public decimal ObtenerBalanceCaja(
            DateTime fechaInicio,
            DateTime fechaFin)
        {
            ValidarFechas(fechaInicio, fechaFin);

            return _repo.ObtenerBalanceCaja(
                fechaInicio,
                fechaFin);
        }

        // =========================
        // CAJA POR DÍA
        // =========================

        public List<CajaPorDiaDTO>
            ObtenerCajaPorDia(
            DateTime fechaInicio,
            DateTime fechaFin)
        {
            ValidarFechas(fechaInicio, fechaFin);

            return _repo.ObtenerCajaPorDia(
                fechaInicio,
                fechaFin);
        }

        // =========================
        // CRÉDITOS VENCIDOS
        // =========================

        public List<CreditoDTO>
            ObtenerCreditosVencidos()
        {
            return _repo.ObtenerCreditosVencidos();
        }

        // =========================
        // CLIENTES CON DEUDA
        // =========================

        public List<CreditoDTO>
            ObtenerClientesConDeuda()
        {
            return _repo.ObtenerClientesConDeuda();
        }

        // =========================
        // PRODUCTOS BAJO STOCK
        // =========================

        public List<ProductoInventarioDTO>
            ObtenerProductosBajoStock(
            int stockMinimo = 5)
        {
            if (stockMinimo < 0)
                throw new Exception(
                    "Stock mínimo inválido");

            return _repo.ObtenerProductosBajoStock(
                stockMinimo);
        }

        // =========================
        // DASHBOARD
        // =========================

        public DashboardDTO ObtenerDashboard()
        {
            return _repo.ObtenerDashboard();
        }

        // =========================
        // VALIDACIONES
        // =========================

        private void ValidarFechas(
            DateTime fechaInicio,
            DateTime fechaFin)
        {
            if (fechaInicio > fechaFin)
            {
                throw new Exception(
                    "La fecha inicio no puede ser mayor a la fecha fin");
            }
        }
    }
}
