using Microsoft.EntityFrameworkCore;
using Sistema.DAL.Data;
using System;
using System.Windows.Forms;

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

            // Inicializar contexto compartido e realizar migraciones
            Context = new SistemaDbContext(options);
            try
            {
                Context.Database.Migrate();

                // Iniciar WinForms
                ApplicationConfiguration.Initialize();
                Application.Run(new Form1());
            }
            finally
            {
                Context.Dispose();
                Context = null;
            }
        }
    }
}