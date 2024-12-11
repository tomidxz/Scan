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
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Donadores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Pais = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefonos = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TotalDonado = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Eliminado = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Donadores", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefonos = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PuestoEmpleado = table.Column<int>(type: "int", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Correo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Eliminado = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Manwhas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Capitulos = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Eliminado = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Sinopsis = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ImagenUrl = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Popular = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Favoritos = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manwhas", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Solicitudes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ManwhaPedido = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Comentario = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CantidadCapitulos = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Eliminado = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Solicitudes", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Donaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Fecha = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DonadorId = table.Column<int>(type: "int", nullable: false),
                    FormaPago = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Eliminado = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Donaciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Donaciones_Donadores_DonadorId",
                        column: x => x.DonadorId,
                        principalTable: "Donadores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DetallesTraducciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Fecha = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ManwhasId = table.Column<int>(type: "int", nullable: false),
                    ManwhaId = table.Column<int>(type: "int", nullable: true),
                    EmpleadoEncargadoId = table.Column<int>(type: "int", nullable: true),
                    EmpleadoTraductorId = table.Column<int>(type: "int", nullable: true),
                    EmpleadoTyperId = table.Column<int>(type: "int", nullable: true),
                    EmpleadoCleanerId = table.Column<int>(type: "int", nullable: true),
                    CapituloTraducido = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Eliminado = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetallesTraducciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetallesTraducciones_Empleados_EmpleadoCleanerId",
                        column: x => x.EmpleadoCleanerId,
                        principalTable: "Empleados",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DetallesTraducciones_Empleados_EmpleadoEncargadoId",
                        column: x => x.EmpleadoEncargadoId,
                        principalTable: "Empleados",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DetallesTraducciones_Empleados_EmpleadoTraductorId",
                        column: x => x.EmpleadoTraductorId,
                        principalTable: "Empleados",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DetallesTraducciones_Empleados_EmpleadoTyperId",
                        column: x => x.EmpleadoTyperId,
                        principalTable: "Empleados",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DetallesTraducciones_Manwhas_ManwhaId",
                        column: x => x.ManwhaId,
                        principalTable: "Manwhas",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Donadores",
                columns: new[] { "Id", "Eliminado", "Nombre", "Pais", "Telefonos", "TotalDonado" },
                values: new object[,]
                {
                    { 1, false, "Damian", "Argentina", "123456789", 1000m },
                    { 2, false, "Lorena", "Chile", "987654321", 2000m },
                    { 3, false, "Carlos", "Cuba", "555666777", 3000m },
                    { 4, false, "Ana", "Brasil", "444555666", 2500m },
                    { 5, false, "Pedro", "Peru", "333444555", 1500m }
                });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "Id", "Correo", "Eliminado", "FechaNacimiento", "Nombre", "PuestoEmpleado", "Telefonos" },
                values: new object[,]
                {
                    { 1, "cesartorres21@gmail.com", false, new DateTime(1985, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cesar Torres", 3, "123456789" },
                    { 2, "agustinasan32@gmail.com", false, new DateTime(1990, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agustina Santillan", 2, "987654321" },
                    { 3, "lucasdjo431@gmail.com", false, new DateTime(1978, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lucas Djovanni", 1, "555666777" },
                    { 4, "ananoseda320@gmail.com", false, new DateTime(2000, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ana Noseda", 0, "444555666" },
                    { 5, "pedrogimenez5463@gmail.com", false, new DateTime(1995, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pedro Gimenez", 1, "333444555" },
                    { 6, "camilaperez@gmail.com", false, new DateTime(1992, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Camila Perez", 2, "222333444" }
                });

            migrationBuilder.InsertData(
                table: "Manwhas",
                columns: new[] { "Id", "Capitulos", "Eliminado", "Favoritos", "ImagenUrl", "Nombre", "Popular", "Sinopsis" },
                values: new object[,]
                {
                    { 1, 528m, false, true, "https://i.pinimg.com/564x/bb/3c/f7/bb3cf78908440b3b06898fb0fd9935da.jpg", "Lookism", false, "Daniel Park, o Park Hyung Suk, es un estudiante de secundaria impopular, gordo y feo que es intimidado y despreciado.\r\nDecidido a huir de sus problemas actuales y comenzar de nuevo, se muda a Seúl y asiste a una nueva escuela secundaria. Sin embargo, una noche durante las vacaciones, obtiene un nuevo cuerpo alto, musculoso y muy guapo. También se da cuenta de que al dormir en un cuerpo, despierta en el otro, y que no importa si lleva 24 horas seguidas despierto, siempre se siente descansado en el cuerpo que ocupa.\r\nMientras Daniel vive su vida con sus dos cuerpos, comienza a ver cuánto el mundo discrimina a las personas simplemente por ser poco atractivas o diferentes. De ahí el nombre de la obra \"Lookism\"." },
                    { 2, 165m, false, false, "https://i.pinimg.com/564x/43/cf/63/43cf6368ec1b14bf4b069601fbdfbdff.jpg", "Manager Kim", false, "Padre soltero, gerente de la compañía y ex miembro de operaciones encubiertas, el Sr. Kim vivió una vida normal hasta que su hija, Minji, desapareció. Después de descubrir que su hija podría estar muerta, el Sr. Kim se vuelve despiadado y busca información. Rescatará a su hija por cualquier medio necesario, incluso si eso significa destruir todo y a todos los que se interpongan en su camino." },
                    { 3, 163m, false, false, "https://i.pinimg.com/564x/18/7c/41/187c410a2f4d705ed87bc881843a35cf.jpg", "Quest Supremacy", false, "Kim SooHyun es un estudiante de secundaria normal que no es bueno para estudiar, pelear o ser atractivo. De repente, se enfrenta a una ventana de menú justo frente a sus ojos para acto seguido recibir los poderes de un [sistema] de juego de la nada, ¿cómo enfrentará nuestro héroe los desafíos que tiene por delante?" },
                    { 4, 141m, false, false, "https://static.wikia.nocookie.net/vsbattles/images/b/b4/Dowan-reality-quest.jpg", "Reality Quest", true, "Debido a la amenaza del matón de la escuela de conseguirle objetos raros en un juego de movil, Ha Do-wan, el desafortunado jugador de videojuegos, murió después de jugar dia y noche durante una semana. En el momento en que murió, fue revivido en su clase, una semana antes de morir… Todo seguia igual que aquel día. ¡Lo único que ha cambiado es la que flota delante de él! ¿Qué? ¡¿Utilizara las habilidades de los juegos que ha jugado hasta ahora para vencer al tipo que le hacia bulling?!" },
                    { 5, 68m, false, false, "https://i.pinimg.com/originals/d9/3b/1c/d93b1c5bd932f0d22fdea2a7960053b7.jpg", "Killer Pietro", true, "Luego de consagrar su vida a la organización criminal El Club de la Gloria, Pietro abandona su carrera de sicario legendario para pasar sus últimos días a cargo de una tienda de libros de segunda. Motivados por la amenaza que supone, la organización aprovecha su edad para eliminarlo. Pero al borde de la muerte, un golpe de suerte le permite regresar a sus años mozos y recuperar la fuerza que perdió con el tiempo. Ahora que está en óptimas condiciones, Pietro se vengará de la organización que lo traicionó." }
                });

            migrationBuilder.InsertData(
                table: "Solicitudes",
                columns: new[] { "Id", "CantidadCapitulos", "Comentario", "Eliminado", "Fecha", "ManwhaPedido" },
                values: new object[,]
                {
                    { 1, 50m, "Me gustaría que lo traduzcan al español", false, new DateTime(2021, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Prision Juvenil" },
                    { 2, 72m, "Si es posible me encantaria que lo traduzcan al español", false, new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Breaker" },
                    { 3, 0m, "por favor traduzcanlo al español", false, new DateTime(2021, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "To not Die" },
                    { 4, 100m, "Apreciaria mucho que lo traduzcan", false, new DateTime(2021, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "The God of High School" }
                });

            migrationBuilder.InsertData(
                table: "Donaciones",
                columns: new[] { "Id", "DonadorId", "Eliminado", "Fecha", "FormaPago", "Total" },
                values: new object[,]
                {
                    { 1, 1, false, new DateTime(2024, 12, 11, 11, 13, 23, 251, DateTimeKind.Local).AddTicks(1783), 3, 3000m },
                    { 2, 2, false, new DateTime(2024, 12, 11, 11, 13, 23, 251, DateTimeKind.Local).AddTicks(1803), 0, 5000m },
                    { 3, 1, false, new DateTime(2024, 12, 11, 11, 13, 23, 251, DateTimeKind.Local).AddTicks(1805), 1, 8000m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DetallesTraducciones_EmpleadoCleanerId",
                table: "DetallesTraducciones",
                column: "EmpleadoCleanerId");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesTraducciones_EmpleadoEncargadoId",
                table: "DetallesTraducciones",
                column: "EmpleadoEncargadoId");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesTraducciones_EmpleadoTraductorId",
                table: "DetallesTraducciones",
                column: "EmpleadoTraductorId");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesTraducciones_EmpleadoTyperId",
                table: "DetallesTraducciones",
                column: "EmpleadoTyperId");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesTraducciones_ManwhaId",
                table: "DetallesTraducciones",
                column: "ManwhaId");

            migrationBuilder.CreateIndex(
                name: "IX_Donaciones_DonadorId",
                table: "Donaciones",
                column: "DonadorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetallesTraducciones");

            migrationBuilder.DropTable(
                name: "Donaciones");

            migrationBuilder.DropTable(
                name: "Solicitudes");

            migrationBuilder.DropTable(
                name: "Empleados");

            migrationBuilder.DropTable(
                name: "Manwhas");

            migrationBuilder.DropTable(
                name: "Donadores");
        }
    }
}
