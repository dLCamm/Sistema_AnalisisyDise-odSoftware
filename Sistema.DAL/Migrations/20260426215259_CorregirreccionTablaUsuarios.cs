using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sistema.DAL.Migrations
{
    /// <inheritdoc />
    public partial class CorregirreccionTablaUsuarios : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdUsuario",
                table: "Usuarios",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Usuarios",
                newName: "IdUsuario");
        }
    }
}
