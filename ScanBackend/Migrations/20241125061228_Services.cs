using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScanBackend.Migrations
{
    /// <inheritdoc />
    public partial class Services : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Popular",
                table: "Manwhas",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Donaciones",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 11, 25, 3, 12, 27, 334, DateTimeKind.Local).AddTicks(4262));

            migrationBuilder.UpdateData(
                table: "Donaciones",
                keyColumn: "Id",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2024, 11, 25, 3, 12, 27, 334, DateTimeKind.Local).AddTicks(4286));

            migrationBuilder.UpdateData(
                table: "Donaciones",
                keyColumn: "Id",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2024, 11, 25, 3, 12, 27, 334, DateTimeKind.Local).AddTicks(4288));

            migrationBuilder.UpdateData(
                table: "Manwhas",
                keyColumn: "Id",
                keyValue: 1,
                column: "Popular",
                value: false);

            migrationBuilder.UpdateData(
                table: "Manwhas",
                keyColumn: "Id",
                keyValue: 2,
                column: "Popular",
                value: false);

            migrationBuilder.UpdateData(
                table: "Manwhas",
                keyColumn: "Id",
                keyValue: 3,
                column: "Popular",
                value: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Popular",
                table: "Manwhas");

            migrationBuilder.UpdateData(
                table: "Donaciones",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 11, 25, 1, 46, 41, 253, DateTimeKind.Local).AddTicks(7202));

            migrationBuilder.UpdateData(
                table: "Donaciones",
                keyColumn: "Id",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2024, 11, 25, 1, 46, 41, 253, DateTimeKind.Local).AddTicks(7224));

            migrationBuilder.UpdateData(
                table: "Donaciones",
                keyColumn: "Id",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2024, 11, 25, 1, 46, 41, 253, DateTimeKind.Local).AddTicks(7226));
        }
    }
}
