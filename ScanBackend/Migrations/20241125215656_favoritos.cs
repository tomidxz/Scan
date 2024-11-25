using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScanBackend.Migrations
{
    /// <inheritdoc />
    public partial class favoritos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Favoritos",
                table: "Manwhas",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

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

            migrationBuilder.UpdateData(
                table: "Manwhas",
                keyColumn: "Id",
                keyValue: 1,
                column: "Favoritos",
                value: true);

            migrationBuilder.UpdateData(
                table: "Manwhas",
                keyColumn: "Id",
                keyValue: 2,
                column: "Favoritos",
                value: false);

            migrationBuilder.UpdateData(
                table: "Manwhas",
                keyColumn: "Id",
                keyValue: 3,
                column: "Favoritos",
                value: false);

            migrationBuilder.UpdateData(
                table: "Manwhas",
                keyColumn: "Id",
                keyValue: 4,
                column: "Favoritos",
                value: false);

            migrationBuilder.UpdateData(
                table: "Manwhas",
                keyColumn: "Id",
                keyValue: 5,
                column: "Favoritos",
                value: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Favoritos",
                table: "Manwhas");

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
        }
    }
}
