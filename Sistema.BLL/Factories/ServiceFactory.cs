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
    }
}
