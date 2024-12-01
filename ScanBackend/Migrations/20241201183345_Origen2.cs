using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScanBackend.Migrations
{
    /// <inheritdoc />
    public partial class Origen2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Donaciones",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 12, 1, 15, 33, 44, 110, DateTimeKind.Local).AddTicks(8050));

            migrationBuilder.UpdateData(
                table: "Donaciones",
                keyColumn: "Id",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2024, 12, 1, 15, 33, 44, 110, DateTimeKind.Local).AddTicks(8069));

            migrationBuilder.UpdateData(
                table: "Donaciones",
                keyColumn: "Id",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2024, 12, 1, 15, 33, 44, 110, DateTimeKind.Local).AddTicks(8071));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Donaciones",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 12, 1, 15, 32, 29, 258, DateTimeKind.Local).AddTicks(6520));

            migrationBuilder.UpdateData(
                table: "Donaciones",
                keyColumn: "Id",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2024, 12, 1, 15, 32, 29, 258, DateTimeKind.Local).AddTicks(6539));

            migrationBuilder.UpdateData(
                table: "Donaciones",
                keyColumn: "Id",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2024, 12, 1, 15, 32, 29, 258, DateTimeKind.Local).AddTicks(6541));
        }
    }
}
