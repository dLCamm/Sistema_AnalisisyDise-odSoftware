using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Sistema.Entities.Clientes;
using Sistema.Entities.Productos;
using Sistema.Entities.Usuarios;
using Sistema.Entities.Ventas;

namespace Sistema.DAL.Data
{
    public class SistemaDbContext : DbContext
    {
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<DetalleVenta> DetalleVentas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

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

            // TABLA PRODUCTO
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
                      .HasMaxLength(20)
                      .HasConversion<string>();
            });

            // TABLA VENTAS
            modelBuilder.Entity<Venta>(entity =>
            {
                entity.ToTable("Ventas");

                entity.HasKey(v => v.Id);

                entity.Property(v => v.TipoPago)
                      .HasMaxLength(50);

                entity.Property(v => v.Total)
                      .HasColumnType("decimal(10,2)");

                entity.Property(v => v.Estado)
                      .HasMaxLength(20)
                      .HasConversion<string>();

                entity.HasMany(v => v.Detalles)
                      .WithOne(d => d.Venta)
                      .HasForeignKey(d => d.VentaId);

                entity.HasOne(v => v.Usuario)
                      .WithMany()
                      .HasForeignKey(v => v.UsuarioId);

                entity.HasOne(v => v.Cliente)
                      .WithMany()
                      .HasForeignKey(v => v.ClienteId);

            });

            // TABLA DETALLE VENTAS
            modelBuilder.Entity<DetalleVenta>(entity =>
            {
                entity.ToTable("Detalle_Ventas");

                entity.HasKey(d => d.Id);

                entity.Property(d => d.PrecioUnitario)
                      .HasColumnType("decimal(10,2)");

                entity.Property(d => d.Subtotal)
                      .HasColumnType("decimal(10,2)");

                entity.HasOne(d => d.Producto)
                      .WithMany()
                      .HasForeignKey(d => d.ProductoId);

                entity.HasOne(d => d.Venta)
                      .WithMany(v => v.Detalles)
                      .HasForeignKey(d => d.VentaId);
            });

            //TABLA CLIENTES
            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.ToTable("Clientes");

                entity.HasKey(c => c.Id);

                entity.Property(c => c.Nombre)
                      .IsRequired()
                      .HasMaxLength(100);

                entity.Property(c => c.Telefono)
                      .HasMaxLength(20);

                entity.Property(c => c.Direccion)
                      .HasMaxLength(200);

                entity.Property(c => c.Email)
                      .HasMaxLength(100);

                entity.Property(c => c.Estado)
                      .HasMaxLength(20)
                      .HasConversion<string>();

                entity.Property(c => c.FechaRegistro);
            });

            //TABLA USUARIOS
            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.ToTable("Usuarios");

                entity.HasKey(u => u.Id);

                entity.Property(u => u.Username)
                      .IsRequired()
                      .HasMaxLength(50);

                entity.Property(u => u.Password)
                      .IsRequired()
                      .HasMaxLength(100);

                entity.Property(u => u.Rol)
                      .HasMaxLength(50);

                entity.Property(u => u.Estado)
                      .HasMaxLength(20)
                      .HasConversion<string>();

                entity.Property(u => u.FechaCreacion);
            });
        }
    }
}