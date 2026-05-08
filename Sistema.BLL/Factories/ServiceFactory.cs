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

            return new InventarioService(context, repo);
        }
        public static VentaService CrearVentaService()
        {
            var context = new SistemaDbContext(_options);
            var repoVenta = new VentaRepository(context);
            var repoProducto = new ProductoRepository(context);
            var repoClientes = new ClienteRepository(context);

            return new VentaService(context, repoVenta, repoProducto, repoClientes);
        }

        public static ClienteService CrearClienteService()
        {
            var context = new SistemaDbContext(_options);
            var repo = new ClienteRepository(context);

            return new ClienteService(context, repo);
        }

    }
}
