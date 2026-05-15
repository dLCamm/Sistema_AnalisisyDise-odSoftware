using System.Text;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace Sistema.BLL.Services
{
    public class ExportService
    {
        // =========================
        // EXPORTAR CSV GENÉRICO
        // =========================

        public void ExportarCsv<T>(
            List<T> datos,
            string rutaArchivo)
        {
            if (datos == null || !datos.Any())
                throw new Exception(
                    "No hay datos para exportar");

            var propiedades = typeof(T).GetProperties();

            var sb = new StringBuilder();

            // CABECERAS
            sb.AppendLine(
                string.Join(",",
                propiedades.Select(p => p.Name)));

            // FILAS
            foreach (var item in datos)
            {
                var valores = propiedades
                    .Select(p =>
                    {
                        var valor = p.GetValue(item);

                        if (valor == null)
                            return "";

                        // evitar romper csv
                        return valor.ToString()!
                            .Replace(",", " ");
                    });

                sb.AppendLine(
                    string.Join(",", valores));
            }

            File.WriteAllText(
                rutaArchivo,
                sb.ToString(),
                Encoding.UTF8);
        }

        // =========================================
        // EXPORTAR PDF
        // =========================================

        public void ExportarPdf<T>(
            List<T> datos,
            string titulo,
            string rutaArchivo)
        {
            if (datos == null || !datos.Any())
                throw new Exception(
                    "No hay datos para exportar");

            var propiedades =
                typeof(T).GetProperties();

            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Margin(30);

                    // HEADER
                    page.Header()
                        .Column(col =>
                        {
                            col.Item()
                                .Text("Sistema de Gestión")
                                .FontSize(20)
                                .Bold();

                            col.Item()
                                .Text(titulo)
                                .FontSize(16);

                            col.Item()
                                .Text(
                                    $"Fecha generación: {DateTime.Now}");

                            col.Item()
                                .PaddingTop(10);
                        });

                    // CONTENT
                    page.Content()
                        .Table(table =>
                        {
                            // COLUMNAS
                            table.ColumnsDefinition(columns =>
                            {
                                foreach (var prop in propiedades)
                                {
                                    columns.RelativeColumn();
                                }
                            });

                            // HEADER TABLA
                            table.Header(header =>
                            {
                                foreach (var prop in propiedades)
                                {
                                    header.Cell()
                                        .Border(1)
                                        .Padding(5)
                                        .Text(prop.Name)
                                        .Bold();
                                }
                            });

                            // DATOS
                            foreach (var item in datos)
                            {
                                foreach (var prop in propiedades)
                                {
                                    var valor =
                                        prop.GetValue(item)?
                                        .ToString() ?? "";

                                    table.Cell()
                                        .Border(1)
                                        .Padding(5)
                                        .Text(valor);
                                }
                            }
                        });

                    // FOOTER
                    page.Footer()
                        .AlignCenter()
                        .Text(x =>
                        {
                            x.Span("Generado por el sistema");
                        });
                });
            })

            .GeneratePdf(rutaArchivo);
        }
    }
}
