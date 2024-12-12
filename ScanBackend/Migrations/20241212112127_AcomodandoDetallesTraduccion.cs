using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScanBackend.Migrations
{
    /// <inheritdoc />
    public partial class AcomodandoDetallesTraduccion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ManwhasId",
                table: "DetallesTraducciones");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ManwhasId",
                table: "DetallesTraducciones",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Donaciones",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 12, 11, 11, 13, 23, 251, DateTimeKind.Local).AddTicks(1783));

            migrationBuilder.UpdateData(
                table: "Donaciones",
                keyColumn: "Id",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2024, 12, 11, 11, 13, 23, 251, DateTimeKind.Local).AddTicks(1803));

            migrationBuilder.UpdateData(
                table: "Donaciones",
                keyColumn: "Id",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2024, 12, 11, 11, 13, 23, 251, DateTimeKind.Local).AddTicks(1805));
        }
    }
}
