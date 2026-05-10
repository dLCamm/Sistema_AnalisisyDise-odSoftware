using Sistema.Entities.Usuarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.DAL.Repositories.Interfaces
{
    public interface IUsuarioRepository
    {
        void Insertar(Usuario usuario);

        void Actualizar(Usuario usuario);

        Usuario? ObtenerPorId(int id);

        Usuario? ObtenerPorUsername(string username);

        List<Usuario> ObtenerTodos();

        List<Usuario> ObtenerPorEstado(
            EstadoUsuario estado);
    }
}
