using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sistema.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AgregarProveedores : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Compras_Proveedor_ProveedorId",
                table: "Compras");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Proveedor",
                table: "Proveedor");

            migrationBuilder.RenameTable(
                name: "Proveedor",
                newName: "Proveedores");

            migrationBuilder.AlterColumn<string>(
                name: "Estado",
                table: "Proveedores",
                type: "TEXT",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Proveedores",
                table: "Proveedores",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Compras_Proveedores_ProveedorId",
                table: "Compras",
                column: "ProveedorId",
                principalTable: "Proveedores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Compras_Proveedores_ProveedorId",
                table: "Compras");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Proveedores",
                table: "Proveedores");

            migrationBuilder.RenameTable(
                name: "Proveedores",
                newName: "Proveedor");

            migrationBuilder.AlterColumn<int>(
                name: "Estado",
                table: "Proveedor",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 20);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Proveedor",
                table: "Proveedor",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Compras_Proveedor_ProveedorId",
                table: "Compras",
                column: "ProveedorId",
                principalTable: "Proveedor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
