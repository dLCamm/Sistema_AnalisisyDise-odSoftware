using Sistema.DAL.Data;
using Sistema.DAL.Repositories.Interfaces;
using Sistema.Entities.Proveedores;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.BLL.Services
{
    public class ProveedorService : IDisposable
    {
        private readonly SistemaDbContext _context;
        private readonly IProveedorRepository _repo;

        public ProveedorService(
            SistemaDbContext context,
            IProveedorRepository repo)
        {
            _context = context;
            _repo = repo;
        }

        // REGISTRAR
        public void RegistrarProveedor(
            string nombre,
            string telefono,
            string direccion,
            string dpi,
            string email)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new Exception("El nombre es obligatorio");

            var proveedor = new Proveedor
            {
                Nombre = nombre,
                Telefono = telefono,
                Direccion = direccion,
                Email = email,
                DPI = dpi,
                Estado = EstadoProveedor.Activo
            };

            _repo.Insertar(proveedor);

            _context.SaveChanges();
        }

        // ACTUALIZAR
        public void ActualizarProveedor(
            int id,
            string nombre,
            string telefono,
            string direccion,
            string email,
            string dpi,
            EstadoProveedor estado)
        {
            var proveedor = _repo.ObtenerPorId(id);

            if (proveedor == null)
                throw new Exception("Proveedor no encontrado");

            proveedor.Nombre = nombre;
            proveedor.Telefono = telefono;
            proveedor.Direccion = direccion;
            proveedor.Email = email;
            proveedor.Estado = estado;
            proveedor.DPI = dpi;

            _repo.Actualizar(proveedor);

            _context.SaveChanges();
        }

        // ANULAR
        public void AnularProveedor(int id)
        {
            var proveedor = _repo.ObtenerPorId(id);

            if (proveedor == null)
                throw new Exception("Proveedor no encontrado");

            proveedor.Estado = EstadoProveedor.Inactivo;

            _repo.Actualizar(proveedor);

            _context.SaveChanges();
        }

        // OBTENER POR ID
        public Proveedor ObtenerProveedor(int id)
        {
            var proveedor = _repo.ObtenerPorId(id);

            if (proveedor == null)
                throw new Exception("Proveedor no encontrado");

            return proveedor;
        }

        // LISTAR TODOS
        public List<Proveedor> ListarProveedores()
        {
            return _repo.ObtenerTodos();
        }

        // LISTAR ACTIVOS
        public List<Proveedor> ListarActivos()
        {
            return _repo.ObtenerPorEstado(EstadoProveedor.Activo);
        }

        // LISTAR INACTIVOS
        public List<Proveedor> ListarInactivos()
        {
            return _repo.ObtenerPorEstado(EstadoProveedor.Inactivo);
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
