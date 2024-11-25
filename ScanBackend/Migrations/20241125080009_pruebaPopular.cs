using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ScanBackend.Migrations
{
    /// <inheritdoc />
    public partial class pruebaPopular : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Manwhas",
                columns: new[] { "Id", "Capitulos", "Eliminado", "ImagenUrl", "Nombre", "Popular", "Sinopsis" },
                values: new object[,]
                {
                    { 4, 141m, false, "https://static.wikia.nocookie.net/vsbattles/images/b/b4/Dowan-reality-quest.jpg", "Reality Quest", true, "Debido a la amenaza del matón de la escuela de conseguirle objetos raros en un juego de movil, Ha Do-wan, el desafortunado jugador de videojuegos, murió después de jugar dia y noche durante una semana. En el momento en que murió, fue revivido en su clase, una semana antes de morir… Todo seguia igual que aquel día. ¡Lo único que ha cambiado es la que flota delante de él! ¿Qué? ¡¿Utilizara las habilidades de los juegos que ha jugado hasta ahora para vencer al tipo que le hacia bulling?!" },
                    { 5, 68m, false, "https://i.pinimg.com/originals/d9/3b/1c/d93b1c5bd932f0d22fdea2a7960053b7.jpg", "Killer Pietro", true, "Luego de consagrar su vida a la organización criminal El Club de la Gloria, Pietro abandona su carrera de sicario legendario para pasar sus últimos días a cargo de una tienda de libros de segunda. Motivados por la amenaza que supone, la organización aprovecha su edad para eliminarlo. Pero al borde de la muerte, un golpe de suerte le permite regresar a sus años mozos y recuperar la fuerza que perdió con el tiempo. Ahora que está en óptimas condiciones, Pietro se vengará de la organización que lo traicionó." }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Manwhas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Manwhas",
                keyColumn: "Id",
                keyValue: 5);

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
        }
    }
}
