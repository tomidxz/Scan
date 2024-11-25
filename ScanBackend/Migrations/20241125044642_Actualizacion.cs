using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScanBackend.Migrations
{
    /// <inheritdoc />
    public partial class Actualizacion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Direccion",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "FormaDePago",
                table: "DetallesDonaciones");

            migrationBuilder.AddColumn<string>(
                name: "Comentario",
                table: "Solicitudes",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

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

            migrationBuilder.UpdateData(
                table: "Solicitudes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Comentario",
                value: "Me gustaría que lo traduzcan al español");

            migrationBuilder.UpdateData(
                table: "Solicitudes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Comentario",
                value: "Si es posible me encantaria que lo traduzcan al español");

            migrationBuilder.UpdateData(
                table: "Solicitudes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Comentario",
                value: "por favor traduzcanlo al español");

            migrationBuilder.UpdateData(
                table: "Solicitudes",
                keyColumn: "Id",
                keyValue: 4,
                column: "Comentario",
                value: "Apreciaria mucho que lo traduzcan");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comentario",
                table: "Solicitudes");

            migrationBuilder.AddColumn<string>(
                name: "Direccion",
                table: "Empleados",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "FormaDePago",
                table: "DetallesDonaciones",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "DetallesDonaciones",
                keyColumn: "Id",
                keyValue: 1,
                column: "FormaDePago",
                value: 0);

            migrationBuilder.UpdateData(
                table: "DetallesDonaciones",
                keyColumn: "Id",
                keyValue: 2,
                column: "FormaDePago",
                value: 0);

            migrationBuilder.UpdateData(
                table: "DetallesDonaciones",
                keyColumn: "Id",
                keyValue: 3,
                column: "FormaDePago",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Donaciones",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 11, 24, 3, 10, 53, 535, DateTimeKind.Local).AddTicks(7387));

            migrationBuilder.UpdateData(
                table: "Donaciones",
                keyColumn: "Id",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2024, 11, 24, 3, 10, 53, 535, DateTimeKind.Local).AddTicks(7409));

            migrationBuilder.UpdateData(
                table: "Donaciones",
                keyColumn: "Id",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2024, 11, 24, 3, 10, 53, 535, DateTimeKind.Local).AddTicks(7411));

            migrationBuilder.UpdateData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 1,
                column: "Direccion",
                value: "Calle Falsa 123");

            migrationBuilder.UpdateData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 2,
                column: "Direccion",
                value: "Avenida Siempre Viva 742");

            migrationBuilder.UpdateData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 3,
                column: "Direccion",
                value: "Boulevard de los Sueños Rotos 101");

            migrationBuilder.UpdateData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 4,
                column: "Direccion",
                value: "Ruta Nacional 19 Km 58");

            migrationBuilder.UpdateData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 5,
                column: "Direccion",
                value: "Calle del Sol 456");

            migrationBuilder.UpdateData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 6,
                column: "Direccion",
                value: "Avenida de los Pajaros 789");
        }
    }
}
