using Microsoft.EntityFrameworkCore;
using Sistema.BLL.Services;
using Sistema.DAL.Data;
using Sistema.DAL.Repositories;


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

            return new InventarioService(
                context, 
                repo);
        }
        public static VentaService CrearVentaService()
        {
            var context = new SistemaDbContext(_options);
            var repoVenta = new VentaRepository(context);
            var repoProducto = new ProductoRepository(context);
            var repoClientes = new ClienteRepository(context);

            return new VentaService(
                context, 
                repoVenta, 
                repoProducto, 
                repoClientes);
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
            var repoProveedor = new ProveedorRepository(context);
            var cajaService = CrearCajaService();

            return new CompraService(
                context,
                repoCompra,
                repoProducto,
                repoProveedor,
                cajaService);
        }

        public static CreditoService CrearCreditoService()
        {
            var context = new SistemaDbContext(_options);

            var repoCredito = new CreditoRepository(context);
            var repoVenta = new VentaRepository(context);

            return new CreditoService(
                context,
                repoCredito,
                repoVenta);
        }

        public static CajaService CrearCajaService()
        {
            var context = new SistemaDbContext(_options);
            var repo = new CajaRepository(context);

            return new CajaService(
                context, 
                repo);
        }
    }
}
