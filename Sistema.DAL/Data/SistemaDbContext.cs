using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Sistema.Entities.Clientes;
using Sistema.Entities.Compras;
using Sistema.Entities.Creditos;
using Sistema.Entities.Productos;
using Sistema.Entities.Proveedores;
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
        public DbSet<Compra> Compras { get; set; }
        public DbSet<Credito> Creditos { get; set; }
        public DbSet<Abono> Abonos { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<DetalleCompra> DetalleCompras { get; set; }

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
                      .HasMaxLength(50)
                      .HasConversion<string>();


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

            // TABLA COMPRAS
            modelBuilder.Entity<Compra>(entity =>
            {
                entity.ToTable("Compras");

                entity.HasKey(c => c.Id);

                entity.Property(c => c.Total)
                    .HasColumnType("decimal(18,2)");

                entity.Property(c => c.Fecha)
                    .IsRequired();

                entity.Property(c => c.Estado)
                    .HasConversion<string>()
                    .IsRequired();

                entity.HasOne(c => c.Proveedor)
                    .WithMany(p => p.Compras)
                    .HasForeignKey(c => c.ProveedorId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasMany(c => c.Detalles)
                    .WithOne(d => d.Compra)
                    .HasForeignKey(d => d.CompraId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            // TABLA DETALLE COMPRA
            modelBuilder.Entity<DetalleCompra>(entity =>
            {
                entity.ToTable("Detalle_Compras");

                entity.HasKey(d => d.Id);

                entity.Property(d => d.Cantidad)
                    .IsRequired();

                entity.Property(d => d.PrecioCompra)
                    .HasColumnType("decimal(18,2)");

                entity.Property(d => d.Subtotal)
                    .HasColumnType("decimal(18,2)");

                entity.HasOne(d => d.Compra)
                    .WithMany(c => c.Detalles)
                    .HasForeignKey(d => d.CompraId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.Producto)
                    .WithMany()
                    .HasForeignKey(d => d.ProductoId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            // TABLA CREDITOS
            modelBuilder.Entity<Credito>(entity =>
            {
                entity.ToTable("Creditos");

                entity.HasKey(c => c.Id);

                entity.Property(c => c.TotalCredito)
                      .HasColumnType("decimal(18,2)")
                      .IsRequired();

                entity.Property(c => c.SaldoPendiente)
                      .HasColumnType("decimal(18,2)")
                      .IsRequired();

                entity.Property(c => c.FechaInicio)
                      .IsRequired();

                entity.Property(c => c.FechaVencimiento)
                      .IsRequired();

                entity.Property(c => c.Estado)
                      .HasConversion<string>()
                      .HasMaxLength(20)
                      .IsRequired();

                entity.HasOne(c => c.Cliente)
                      .WithMany(c => c.Creditos)
                      .HasForeignKey(c => c.ClienteId)
                      .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(c => c.Venta)
                      .WithOne(v => v.Credito)
                      .HasForeignKey<Credito>(c => c.VentaId)
                      .OnDelete(DeleteBehavior.Restrict);

                entity.HasMany(c => c.Abonos)
                      .WithOne(a => a.Credito)
                      .HasForeignKey(a => a.CreditoId)
                      .OnDelete(DeleteBehavior.Cascade);
            });

            // TABLA ABONOS
            modelBuilder.Entity<Abono>(entity =>
            {
                entity.ToTable("Abonos");

                entity.HasKey(a => a.Id);

                entity.Property(a => a.Monto)
                      .HasColumnType("decimal(18,2)")
                      .IsRequired();

                entity.Property(a => a.Fecha)
                      .IsRequired();

                entity.Property(a => a.Estado)
                      .HasConversion<string>()
                      .HasMaxLength(20)
                      .IsRequired();

                entity.HasOne(a => a.Credito)
                      .WithMany(c => c.Abonos)
                      .HasForeignKey(a => a.CreditoId)
                      .OnDelete(DeleteBehavior.Cascade);
            });

            // TABLA PROVEEDORES
            modelBuilder.Entity<Proveedor>(entity =>
            {
                entity.ToTable("Proveedores");

                entity.HasKey(p => p.Id);

                entity.Property(p => p.Nombre)
                      .HasMaxLength(100)
                      .IsRequired();

                entity.Property(p => p.Telefono)
                      .HasMaxLength(20)
                      .IsRequired();

                entity.Property(p => p.Direccion)
                      .HasMaxLength(200)
                      .IsRequired();

                entity.Property(p => p.Email)
                      .HasMaxLength(100)
                      .IsRequired();

                entity.Property(p => p.Estado)
                      .HasConversion<string>()
                      .HasMaxLength(20)
                      .IsRequired();

                entity.HasMany(p => p.Compras)
                      .WithOne(c => c.Proveedor)
                      .HasForeignKey(c => c.ProveedorId)
                      .OnDelete(DeleteBehavior.Restrict);
            });
        }
    }
}