using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ScanBackend.Migrations
{
    /// <inheritdoc />
    public partial class arreglosDonaciones : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Donaciones_Empleados_EmpleadoId",
                table: "Donaciones");

            migrationBuilder.DropTable(
                name: "DetallesDonaciones");

            migrationBuilder.DropIndex(
                name: "IX_Donaciones_EmpleadoId",
                table: "Donaciones");

            migrationBuilder.DropColumn(
                name: "Descuento",
                table: "Donaciones");

            migrationBuilder.DropColumn(
                name: "EmpleadoId",
                table: "Donaciones");

            migrationBuilder.DropColumn(
                name: "Cantidad",
                table: "DetallesTraducciones");

            migrationBuilder.AddColumn<decimal>(
                name: "CapituloTraducido",
                table: "DetallesTraducciones",
                type: "decimal(65,30)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<DateTime>(
                name: "Fecha",
                table: "DetallesTraducciones",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Donaciones",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 12, 1, 13, 11, 23, 204, DateTimeKind.Local).AddTicks(8771));

            migrationBuilder.UpdateData(
                table: "Donaciones",
                keyColumn: "Id",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2024, 12, 1, 13, 11, 23, 204, DateTimeKind.Local).AddTicks(8788));

            migrationBuilder.UpdateData(
                table: "Donaciones",
                keyColumn: "Id",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2024, 12, 1, 13, 11, 23, 204, DateTimeKind.Local).AddTicks(8790));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CapituloTraducido",
                table: "DetallesTraducciones");

            migrationBuilder.DropColumn(
                name: "Fecha",
                table: "DetallesTraducciones");

            migrationBuilder.AddColumn<decimal>(
                name: "Descuento",
                table: "Donaciones",
                type: "decimal(65,30)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "EmpleadoId",
                table: "Donaciones",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Cantidad",
                table: "DetallesTraducciones",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "DetallesDonaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DonacionId = table.Column<int>(type: "int", nullable: false),
                    Eliminado = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    MensajeDonador = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetallesDonaciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetallesDonaciones_Donaciones_DonacionId",
                        column: x => x.DonacionId,
                        principalTable: "Donaciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "DetallesDonaciones",
                columns: new[] { "Id", "DonacionId", "Eliminado", "MensajeDonador" },
                values: new object[,]
                {
                    { 1, 1, false, "Muchas gracias por traducir mis manwhas preferidos" },
                    { 2, 2, false, "Espero que les sirva para seguir con su trabajo" },
                    { 3, 3, false, "Gracias por todo lo que hacen" }
                });

            migrationBuilder.UpdateData(
                table: "Donaciones",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Descuento", "EmpleadoId", "Fecha" },
                values: new object[] { 5m, 1, new DateTime(2024, 12, 1, 2, 18, 31, 316, DateTimeKind.Local).AddTicks(747) });

            migrationBuilder.UpdateData(
                table: "Donaciones",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Descuento", "EmpleadoId", "Fecha" },
                values: new object[] { 10m, 1, new DateTime(2024, 12, 1, 2, 18, 31, 316, DateTimeKind.Local).AddTicks(775) });

            migrationBuilder.UpdateData(
                table: "Donaciones",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Descuento", "EmpleadoId", "Fecha" },
                values: new object[] { 21m, 1, new DateTime(2024, 12, 1, 2, 18, 31, 316, DateTimeKind.Local).AddTicks(778) });

            migrationBuilder.CreateIndex(
                name: "IX_Donaciones_EmpleadoId",
                table: "Donaciones",
                column: "EmpleadoId");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesDonaciones_DonacionId",
                table: "DetallesDonaciones",
                column: "DonacionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Donaciones_Empleados_EmpleadoId",
                table: "Donaciones",
                column: "EmpleadoId",
                principalTable: "Empleados",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
