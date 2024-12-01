using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScanBackend.Migrations
{
    /// <inheritdoc />
    public partial class Origen : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Manwhas_Origenes_OrigenId",
                table: "Manwhas");

            migrationBuilder.AlterColumn<int>(
                name: "OrigenId",
                table: "Manwhas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.UpdateData(
                table: "Manwhas",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrigenId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Manwhas",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrigenId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Manwhas",
                keyColumn: "Id",
                keyValue: 3,
                column: "OrigenId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Manwhas",
                keyColumn: "Id",
                keyValue: 4,
                column: "OrigenId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Manwhas",
                keyColumn: "Id",
                keyValue: 5,
                column: "OrigenId",
                value: 1);

            migrationBuilder.AddForeignKey(
                name: "FK_Manwhas_Origenes_OrigenId",
                table: "Manwhas",
                column: "OrigenId",
                principalTable: "Origenes",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Manwhas_Origenes_OrigenId",
                table: "Manwhas");

            migrationBuilder.AlterColumn<int>(
                name: "OrigenId",
                table: "Manwhas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Manwhas_Origenes_OrigenId",
                table: "Manwhas",
                column: "OrigenId",
                principalTable: "Origenes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
