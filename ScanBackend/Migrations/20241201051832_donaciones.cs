using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScanBackend.Migrations
{
    /// <inheritdoc />
    public partial class donaciones : Migration
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
                values: new object[] { 1, new DateTime(2024, 12, 1, 2, 18, 31, 316, DateTimeKind.Local).AddTicks(747) });

            migrationBuilder.UpdateData(
                table: "Donaciones",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EmpleadoId", "Fecha" },
                values: new object[] { 1, new DateTime(2024, 12, 1, 2, 18, 31, 316, DateTimeKind.Local).AddTicks(775) });

            migrationBuilder.UpdateData(
                table: "Donaciones",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EmpleadoId", "Fecha" },
                values: new object[] { 1, new DateTime(2024, 12, 1, 2, 18, 31, 316, DateTimeKind.Local).AddTicks(778) });

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
                value: new DateTime(2024, 11, 25, 18, 56, 55, 600, DateTimeKind.Local).AddTicks(3414));

            migrationBuilder.UpdateData(
                table: "Donaciones",
                keyColumn: "Id",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2024, 11, 25, 18, 56, 55, 600, DateTimeKind.Local).AddTicks(3438));

            migrationBuilder.UpdateData(
                table: "Donaciones",
                keyColumn: "Id",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2024, 11, 25, 18, 56, 55, 600, DateTimeKind.Local).AddTicks(3442));
        }
    }
}
