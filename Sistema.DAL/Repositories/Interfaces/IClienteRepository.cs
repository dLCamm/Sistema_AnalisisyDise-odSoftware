using Sistema.Entities.Clientes;
using Sistema.Entities.Productos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.DAL.Repositories.Interfaces
{
    public interface IClienteRepository
    {
        void Insertar(Cliente cliente);
        void Actualizar(Cliente cliente);
        Cliente? ObtenerPorId(int id);
        List<Cliente> ObtenerTodos();
        List<Cliente> ObtenerPorEstado(EstadoCliente estado);
    }
}
