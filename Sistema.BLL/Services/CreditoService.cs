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
            DateTime fechaVencimiento)
        {
            var venta = _repoVenta.ObtenerPorId(ventaId);

            if (venta == null)
                throw new Exception("Venta no encontrada");

            if (venta.TipoPago != TipoPago.Credito)
                throw new Exception("La venta no es a crédito");

            var credito = new Credito
            {
                VentaId = venta.Id,
                ClienteId = venta.ClienteId,
                TotalCredito = venta.Total,
                SaldoPendiente = venta.Total,
                FechaVencimiento = fechaVencimiento,
                Estado = EstadoCredito.Pendiente
            };

            _repoCredito.Insertar(credito);

            _context.SaveChanges();
        }

        // REGISTRAR ABONO
        public void RegistrarAbono(
            int creditoId,
            decimal monto)
        {
            using var transaction = _context.Database.BeginTransaction();

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
                    Monto = monto
                };

                credito.SaldoPendiente -= monto;

                // cambiar estado automáticamente
                if (credito.SaldoPendiente == 0)
                {
                    credito.Estado = EstadoCredito.Pagado;
                }

                _repoCredito.InsertarAbono(abono);

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

        // CANCELAR
        public void CancelarCredito(int id)
        {
            var credito = _repoCredito.ObtenerPorId(id);

            if (credito == null)
                throw new Exception("Crédito no encontrado");

            credito.Estado = EstadoCredito.Cancelado;

            // cancelar abonos
            foreach (var abono in credito.Abonos)
            {
                abono.Estado = EstadoAbono.Anulado;
            }

            _repoCredito.Actualizar(credito);

            _context.SaveChanges();

            _repoCredito.Actualizar(credito);

            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
