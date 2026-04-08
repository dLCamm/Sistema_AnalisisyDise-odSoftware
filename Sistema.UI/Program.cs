using Microsoft.EntityFrameworkCore;
using Sistema.DAL.Data;

namespace Sistema.UI
{
    internal static class Program
    {

        public static SistemaDbContext? Context;

        [STAThread]
        static void Main()
        {
            // Configurar EF + SQLite
            var options = new DbContextOptionsBuilder<SistemaDbContext>()
                .UseSqlite("Data Source=sistema.db")
                .Options;

            Context = new SistemaDbContext(options);

            // Crear base de datos
            Context.Database.Migrate();

            // Iniciar WinForms
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}