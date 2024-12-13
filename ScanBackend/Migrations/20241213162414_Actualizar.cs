using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScanBackend.Migrations
{
    /// <inheritdoc />
    public partial class Actualizar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmpleadoId",
                table: "Donaciones",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Donaciones",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EmpleadoId", "Fecha" },
                values: new object[] { 0, new DateTime(2024, 12, 13, 13, 24, 13, 803, DateTimeKind.Local).AddTicks(4994) });

            migrationBuilder.UpdateData(
                table: "Donaciones",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EmpleadoId", "Fecha" },
                values: new object[] { 0, new DateTime(2024, 12, 13, 13, 24, 13, 803, DateTimeKind.Local).AddTicks(5013) });

            migrationBuilder.UpdateData(
                table: "Donaciones",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EmpleadoId", "Fecha" },
                values: new object[] { 0, new DateTime(2024, 12, 13, 13, 24, 13, 803, DateTimeKind.Local).AddTicks(5015) });

            migrationBuilder.CreateIndex(
                name: "IX_Donaciones_EmpleadoId",
                table: "Donaciones",
                column: "EmpleadoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Donaciones_Empleados_EmpleadoId",
                table: "Donaciones",
                column: "EmpleadoId",
                principalTable: "Empleados",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Donaciones_Empleados_EmpleadoId",
                table: "Donaciones");

            migrationBuilder.DropIndex(
                name: "IX_Donaciones_EmpleadoId",
                table: "Donaciones");

            migrationBuilder.DropColumn(
                name: "EmpleadoId",
                table: "Donaciones");

            migrationBuilder.UpdateData(
                table: "Donaciones",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 12, 12, 8, 21, 25, 746, DateTimeKind.Local).AddTicks(8719));

            migrationBuilder.UpdateData(
                table: "Donaciones",
                keyColumn: "Id",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2024, 12, 12, 8, 21, 25, 746, DateTimeKind.Local).AddTicks(8735));

            migrationBuilder.UpdateData(
                table: "Donaciones",
                keyColumn: "Id",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2024, 12, 12, 8, 21, 25, 746, DateTimeKind.Local).AddTicks(8736));
        }
    }
}
