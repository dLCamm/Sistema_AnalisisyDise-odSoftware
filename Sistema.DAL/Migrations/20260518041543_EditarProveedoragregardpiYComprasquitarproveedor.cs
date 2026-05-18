using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sistema.DAL.Migrations
{
    /// <inheritdoc />
    public partial class EditarProveedoragregardpiYComprasquitarproveedor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Compras_Proveedores_ProveedorId",
                table: "Compras");

            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Proveedores_ProveedorId1",
                table: "Productos");

            migrationBuilder.DropIndex(
                name: "IX_Productos_ProveedorId1",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "ProveedorId1",
                table: "Productos");

            migrationBuilder.AlterColumn<int>(
                name: "ProveedorId",
                table: "Compras",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_Compras_Proveedores_ProveedorId",
                table: "Compras",
                column: "ProveedorId",
                principalTable: "Proveedores",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Compras_Proveedores_ProveedorId",
                table: "Compras");

            migrationBuilder.AddColumn<int>(
                name: "ProveedorId1",
                table: "Productos",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProveedorId",
                table: "Compras",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Productos_ProveedorId1",
                table: "Productos",
                column: "ProveedorId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Compras_Proveedores_ProveedorId",
                table: "Compras",
                column: "ProveedorId",
                principalTable: "Proveedores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Proveedores_ProveedorId1",
                table: "Productos",
                column: "ProveedorId1",
                principalTable: "Proveedores",
                principalColumn: "Id");
        }
    }
}
