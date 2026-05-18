using System;
using System.Collections.Generic;

namespace Sistema.UI
{
    public interface IReporteForm
    {
        // Método que devolverá la lista con los filtros aplicados en ese instante
        object ObtenerDatosFiltrados();

        string ObtenerTituloReporte();
    }
}