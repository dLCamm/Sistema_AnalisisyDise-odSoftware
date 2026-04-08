using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Sistema.Entities.Productos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.DAL.Data
{
    public class SistemaDbContext : DbContext
    {
        public DbSet<Producto> Productos { get; set; }

        public class SistemaDbContextFactory : IDesignTimeDbContextFactory<SistemaDbContext>
        {
            public SistemaDbContext CreateDbContext(string[] args)
            {
                var optionsBuilder = new DbContextOptionsBuilder<SistemaDbContext>();

                optionsBuilder.UseSqlite("Data Source=sistema.db");

                return new SistemaDbContext(optionsBuilder.Options);
            }
        }

        public SistemaDbContext(DbContextOptions<SistemaDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.ToTable("Productos");

                entity.HasKey(p => p.Id);

                entity.Property(p => p.Id)
                      .ValueGeneratedOnAdd();

                entity.Property(p => p.Nombre)
                      .IsRequired()
                      .HasMaxLength(100);

                entity.Property(p => p.Descripcion);

                entity.Property(p => p.PrecioCompra)
                      .HasColumnType("decimal(10,2)");

                entity.Property(p => p.PrecioVenta)
                      .HasColumnType("decimal(10,2)");

                entity.Property(p => p.Stock);

                entity.Property(p => p.StockMinimo);

                entity.Property(p => p.FechaCreacion);

                entity.Property(p => p.Estado)
                      .HasMaxLength(20);
            });
        }
    }
}