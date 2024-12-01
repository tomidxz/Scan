using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScanBackend.Migrations
{
    /// <inheritdoc />
    public partial class Traduccion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrigenId",
                table: "Manwhas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Donaciones",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 12, 1, 15, 24, 52, 814, DateTimeKind.Local).AddTicks(2917));

            migrationBuilder.UpdateData(
                table: "Donaciones",
                keyColumn: "Id",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2024, 12, 1, 15, 24, 52, 814, DateTimeKind.Local).AddTicks(2943));

            migrationBuilder.UpdateData(
                table: "Donaciones",
                keyColumn: "Id",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2024, 12, 1, 15, 24, 52, 814, DateTimeKind.Local).AddTicks(2945));

            migrationBuilder.UpdateData(
                table: "Manwhas",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrigenId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Manwhas",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrigenId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Manwhas",
                keyColumn: "Id",
                keyValue: 3,
                column: "OrigenId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Manwhas",
                keyColumn: "Id",
                keyValue: 4,
                column: "OrigenId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Manwhas",
                keyColumn: "Id",
                keyValue: 5,
                column: "OrigenId",
                value: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Manwhas_OrigenId",
                table: "Manwhas",
                column: "OrigenId");

            migrationBuilder.AddForeignKey(
                name: "FK_Manwhas_Origenes_OrigenId",
                table: "Manwhas",
                column: "OrigenId",
                principalTable: "Origenes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Manwhas_Origenes_OrigenId",
                table: "Manwhas");

            migrationBuilder.DropIndex(
                name: "IX_Manwhas_OrigenId",
                table: "Manwhas");

            migrationBuilder.DropColumn(
                name: "OrigenId",
                table: "Manwhas");

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
    }
}
