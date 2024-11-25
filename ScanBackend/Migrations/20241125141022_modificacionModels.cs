using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScanBackend.Migrations
{
    /// <inheritdoc />
    public partial class modificacionModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "CantidadCapitulos",
                table: "Solicitudes",
                type: "decimal(65,30)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "Donaciones",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 11, 25, 11, 10, 21, 277, DateTimeKind.Local).AddTicks(6903));

            migrationBuilder.UpdateData(
                table: "Donaciones",
                keyColumn: "Id",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2024, 11, 25, 11, 10, 21, 277, DateTimeKind.Local).AddTicks(6924));

            migrationBuilder.UpdateData(
                table: "Donaciones",
                keyColumn: "Id",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2024, 11, 25, 11, 10, 21, 277, DateTimeKind.Local).AddTicks(6926));

            migrationBuilder.UpdateData(
                table: "Solicitudes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CantidadCapitulos",
                value: 50m);

            migrationBuilder.UpdateData(
                table: "Solicitudes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CantidadCapitulos",
                value: 72m);

            migrationBuilder.UpdateData(
                table: "Solicitudes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CantidadCapitulos",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Solicitudes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CantidadCapitulos",
                value: 100m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CantidadCapitulos",
                table: "Solicitudes");

            migrationBuilder.UpdateData(
                table: "Donaciones",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 11, 25, 5, 0, 7, 947, DateTimeKind.Local).AddTicks(5312));

            migrationBuilder.UpdateData(
                table: "Donaciones",
                keyColumn: "Id",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2024, 11, 25, 5, 0, 7, 947, DateTimeKind.Local).AddTicks(5333));

            migrationBuilder.UpdateData(
                table: "Donaciones",
                keyColumn: "Id",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2024, 11, 25, 5, 0, 7, 947, DateTimeKind.Local).AddTicks(5336));
        }
    }
}
