using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sistema.DAL.Migrations
{
    /// <inheritdoc />
    public partial class EditarClienteagregardpi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DPI",
                table: "Clientes",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DPI",
                table: "Clientes");
        }
    }
}
