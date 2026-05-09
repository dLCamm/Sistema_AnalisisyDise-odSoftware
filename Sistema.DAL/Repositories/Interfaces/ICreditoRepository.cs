using Sistema.Entities.Creditos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.DAL.Repositories.Interfaces
{
    public interface ICreditoRepository
    {
        void Insertar(Credito credito);

        void InsertarAbono(Abono abono);

        Credito? ObtenerPorId(int id);

        List<Credito> ObtenerTodos();

        List<Credito> ObtenerPorEstado(EstadoCredito estado);

        void Actualizar(Credito credito);

        Abono? ObtenerAbonoPorId(int id);
    }
}
