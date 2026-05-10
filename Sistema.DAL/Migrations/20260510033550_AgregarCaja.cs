using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sistema.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AgregarCaja : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Caja",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Tipo = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    Monto = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Origen = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    ReferenciaId = table.Column<int>(type: "INTEGER", nullable: false),
                    Descripcion = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Estado = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    UsuarioId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Caja", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Caja_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Caja_Estado",
                table: "Caja",
                column: "Estado");

            migrationBuilder.CreateIndex(
                name: "IX_Caja_Fecha",
                table: "Caja",
                column: "Fecha");

            migrationBuilder.CreateIndex(
                name: "IX_Caja_Origen",
                table: "Caja",
                column: "Origen");

            migrationBuilder.CreateIndex(
                name: "IX_Caja_Tipo",
                table: "Caja",
                column: "Tipo");

            migrationBuilder.CreateIndex(
                name: "IX_Caja_UsuarioId",
                table: "Caja",
                column: "UsuarioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Caja");
        }
    }
}
