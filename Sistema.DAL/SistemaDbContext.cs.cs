using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.EntityFrameworkCore;
using Sistema.Entities;

namespace Sistema.DAL
{
    public class SistemaDbContext : DbContext
    {
        public DbSet<Producto> Productos { get; set; }

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