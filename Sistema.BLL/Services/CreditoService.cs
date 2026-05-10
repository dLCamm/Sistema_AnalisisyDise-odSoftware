using Sistema.DAL.Data;
using Sistema.DAL.Repositories.Interfaces;
using Sistema.Entities.Creditos;
using Sistema.Entities.Ventas;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.BLL.Services
{
    public class CreditoService : IDisposable
    {
        private readonly SistemaDbContext _context;

        private readonly ICreditoRepository _repoCredito;
        private readonly IVentaRepository _repoVenta;

        public CreditoService(
            SistemaDbContext context,
            ICreditoRepository repoCredito,
            IVentaRepository repoVenta)
        {
            _context = context;
            _repoCredito = repoCredito;
            _repoVenta = repoVenta;
        }

        // CREAR CRÉDITO
        public void CrearCredito(
            int ventaId,
            DateTime fechaVencimiento,
            decimal abonoInicial = 0,
            bool guardarCambios = true)
        {
            var venta = _repoVenta.ObtenerPorId(ventaId);

            if (venta == null)
                throw new Exception("Venta no encontrada");

            if (venta.TipoPago != TipoPago.Credito)
                throw new Exception("La venta no es a crédito");

            if (abonoInicial < 0)
                throw new Exception("Abono inválido");

            if (abonoInicial > venta.Total)
                throw new Exception("El abono excede el total");

            var credito = new Credito
            {
                VentaId = venta.Id,
                ClienteId = venta.ClienteId,
                TotalCredito = venta.Total,
                SaldoPendiente = venta.Total - abonoInicial,
                FechaVencimiento = fechaVencimiento,
                Estado = abonoInicial == venta.Total
                    ? EstadoCredito.Pagado
                    : EstadoCredito.Pendiente
            };

            // crear abono inicial
            if (abonoInicial > 0)
            {
                credito.Abonos.Add(new Abono
                {
                    Monto = abonoInicial,
                    Estado = EstadoAbono.Activo
                });
            }

            _repoCredito.Insertar(credito);

            if (guardarCambios)
            {
                _context.SaveChanges();
            }
        }

        // REGISTRAR ABONO
        public void RegistrarAbono(
            int creditoId,
            decimal monto,
            bool guardarCambios = true)
        {
            using var transaction = guardarCambios
                ? _context.Database.BeginTransaction()
                : null;

            try
            {
                if (monto <= 0)
                    throw new Exception("Monto inválido");

                var credito = _repoCredito.ObtenerPorId(creditoId);

                if (credito == null)
                    throw new Exception("Crédito no encontrado");

                if (credito.Estado == EstadoCredito.Cancelado)
                    throw new Exception("El crédito está cancelado");

                if (credito.Estado == EstadoCredito.Pagado)
                    throw new Exception("El crédito ya fue pagado");

                if (monto > credito.SaldoPendiente)
                    throw new Exception("El monto excede el saldo pendiente");

                var abono = new Abono
                {
                    CreditoId = creditoId,
                    Monto = monto,
                    Estado = EstadoAbono.Activo
                };

                credito.SaldoPendiente -= monto;

                // cambiar estado automáticamente
                if (credito.SaldoPendiente == 0)
                {
                    credito.Estado = EstadoCredito.Pagado;
                }

                _repoCredito.InsertarAbono(abono);

                _repoCredito.Actualizar(credito);

                if (guardarCambios)
                {
                    _context.SaveChanges();

                    transaction?.Commit();
                }
            }
            catch
            {
                transaction?.Rollback();
                throw;
            }
        }

        // OBTENER
        public Credito ObtenerCredito(int id)
        {
            var credito = _repoCredito.ObtenerPorId(id);

            if (credito == null)
                throw new Exception("Crédito no encontrado");

            return credito;
        }

        // LISTAR
        public List<Credito> ListarCreditos()
        {
            return _repoCredito.ObtenerTodos();
        }

        // FILTRAR
        public List<Credito> ListarPorEstado(EstadoCredito estado)
        {
            return _repoCredito.ObtenerPorEstado(estado);
        }

        // HISTORIAL
        public List<Abono> ObtenerHistorialPagos(int creditoId)
        {
            var credito = _repoCredito.ObtenerPorId(creditoId);

            if (credito == null)
                throw new Exception("Crédito no encontrado");

            return credito.Abonos.ToList();
        }

        // CANCELAR CRÉDITO
        public void CancelarCredito(
            int id,
            bool guardarCambios = true)
        {
            var credito = _repoCredito.ObtenerPorId(id);

            if (credito == null)
                throw new Exception("Crédito no encontrado");

            if (credito.Estado == EstadoCredito.Cancelado)
                return;

            if (credito.Estado == EstadoCredito.Pagado)
            {
                throw new Exception(
                    "No se puede cancelar un crédito pagado");
            }

            credito.Estado = EstadoCredito.Cancelado;

            // cancelar abonos
            foreach (var abono in credito.Abonos)
            {
                abono.Estado = EstadoAbono.Anulado;
            }

            _repoCredito.Actualizar(credito);

            if (guardarCambios)
            {
                _context.SaveChanges();
            }
        }

        public void CancelarCreditoPorVenta(
            int ventaId,
            bool guardarCambios = true)
        {
            var credito =
                _repoCredito.ObtenerPorVentaId(ventaId);

            if (credito == null)
                return;

            CancelarCredito(
                credito.Id,
                guardarCambios);
        }

        // ANULAR ABONO
        public void AnularAbono(int abonoId)
        {
            using var transaction = _context.Database.BeginTransaction();

            try
            {
                var abono = _repoCredito.ObtenerAbonoPorId(abonoId);

                if (abono == null)
                    throw new Exception("Abono no encontrado");

                if (abono.Estado == EstadoAbono.Anulado)
                    return;

                var credito = abono.Credito;

                // devolver saldo
                credito.SaldoPendiente += abono.Monto;

                // evitar exceder total
                if (credito.SaldoPendiente > credito.TotalCredito)
                {
                    credito.SaldoPendiente = credito.TotalCredito;
                }

                // volver a pendiente
                credito.Estado = EstadoCredito.Pendiente;

                // anular abono
                abono.Estado = EstadoAbono.Anulado;

                _repoCredito.Actualizar(credito);

                _context.SaveChanges();

                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
