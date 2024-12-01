using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ScanBackend.Migrations
{
    /// <inheritdoc />
    public partial class Arreglos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Manwhas_Origenes_OrigenId",
                table: "Manwhas");

            migrationBuilder.DropTable(
                name: "Origenes");

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
                value: new DateTime(2024, 12, 1, 15, 41, 58, 710, DateTimeKind.Local).AddTicks(9074));

            migrationBuilder.UpdateData(
                table: "Donaciones",
                keyColumn: "Id",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2024, 12, 1, 15, 41, 58, 710, DateTimeKind.Local).AddTicks(9092));

            migrationBuilder.UpdateData(
                table: "Donaciones",
                keyColumn: "Id",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2024, 12, 1, 15, 41, 58, 710, DateTimeKind.Local).AddTicks(9094));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrigenId",
                table: "Manwhas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Origenes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Eliminado = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Origenes", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

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

            migrationBuilder.InsertData(
                table: "Origenes",
                columns: new[] { "Id", "Eliminado", "Nombre" },
                values: new object[,]
                {
                    { 1, false, "Coreano" },
                    { 2, false, "Chino" },
                    { 3, false, "Japones" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Manwhas_OrigenId",
                table: "Manwhas",
                column: "OrigenId");

            migrationBuilder.AddForeignKey(
                name: "FK_Manwhas_Origenes_OrigenId",
                table: "Manwhas",
                column: "OrigenId",
                principalTable: "Origenes",
                principalColumn: "Id");
        }
    }
}
