using Microsoft.EntityFrameworkCore;
using Sistema.BLL.Services;
using Sistema.DAL.Data;
using Sistema.DAL.Repositories;
using Sistema.DAL.Repositories.Interfaces;


namespace Sistema.BLL.Factories
{
    public static class ServiceFactory
    {
        private static DbContextOptions<SistemaDbContext> _options =
            new DbContextOptionsBuilder<SistemaDbContext>()
                .UseSqlite("Data Source=sistema.db")
                .Options;

        public static InventarioService CrearInventarioService()
        {
            var context = new SistemaDbContext(_options);
            var repo = new ProductoRepository(context);
            var repoProveedor = new ProveedorRepository(context);

            return new InventarioService(
                context, 
                repo,
                repoProveedor);
        }
        public static VentaService CrearVentaService()
        {
            var context = new SistemaDbContext(_options);

            var repoVenta = new VentaRepository(context);
            var repoProducto = new ProductoRepository(context);
            var repoClientes = new ClienteRepository(context);
            var repoUsuario = new UsuarioRepository(context);

            // CAJA MANUAL
            var repoCaja = new CajaRepository(context);

            var servicioCaja = new CajaService(
                context,
                repoCaja);

            // CRÉDITO MANUAL
            var repoCredito = new CreditoRepository(context);

            var servicioCredito = new CreditoService(
                context,
                repoCredito,
                repoVenta,
                servicioCaja);

            return new VentaService(
                context,
                repoVenta,
                repoProducto,
                repoClientes,
                repoUsuario,
                servicioCredito,
                servicioCaja);
        }

        public static ClienteService CrearClienteService()
        {
            var context = new SistemaDbContext(_options);
            var repo = new ClienteRepository(context);

            return new ClienteService(
                context, 
                repo);
        }

        public static ProveedorService CrearProveedorService()
        {
            var context = new SistemaDbContext(_options);
            var repo = new ProveedorRepository(context);

            return new ProveedorService(
                context, 
                repo);
        }

        public static CompraService CrearCompraService()
        {
            var context = new SistemaDbContext(_options);

            var repoCompra = new CompraRepository(context);
            var repoProducto = new ProductoRepository(context);

            var repoCaja = new CajaRepository(context);

            var cajaService = new CajaService(
                context,
                repoCaja);

            return new CompraService(
                context,
                repoCompra,
                repoProducto,
                cajaService);
        }

        public static CreditoService CrearCreditoService()
        {
            var context = new SistemaDbContext(_options);

            var repoCredito = new CreditoRepository(context);
            var repoVenta = new VentaRepository(context);

            var repoCaja = new CajaRepository(context);

            var cajaService = new CajaService(
                context,
                repoCaja);

            return new CreditoService(
                context,
                repoCredito,
                repoVenta,
                cajaService);
        }

        public static CajaService CrearCajaService()
        {
            var context = new SistemaDbContext(_options);
            var repo = new CajaRepository(context);

            return new CajaService(
                context, 
                repo);
        }

        public static UsuarioService CrearUsuarioService()
        {
            var context = new SistemaDbContext(_options);

            var repo = new UsuarioRepository(context);

            return new UsuarioService(
                context,
                repo);
        }

        public static ExportService CrearExportService()
        {
            return new ExportService();
        }

        public static ReporteService CrearReporteService()
        {
            var context = new SistemaDbContext(_options);

            IReporteRepository repo = new ReporteRepository(context);

            return new ReporteService(repo);
        }
    }
}
