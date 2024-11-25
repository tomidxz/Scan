﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ScanService.DataContext;

#nullable disable

namespace ScanBackend.Migrations
{
    [DbContext(typeof(ScanContext))]
    [Migration("20241125141022_modificacionModels")]
    partial class modificacionModels
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("ScanServices.Models.DetallesDonacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DonacionId")
                        .HasColumnType("int");

                    b.Property<bool>("Eliminado")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("MensajeDonador")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("DonacionId");

                    b.ToTable("DetallesDonaciones");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DonacionId = 1,
                            Eliminado = false,
                            MensajeDonador = "Muchas gracias por traducir mis manwhas preferidos"
                        },
                        new
                        {
                            Id = 2,
                            DonacionId = 2,
                            Eliminado = false,
                            MensajeDonador = "Espero que les sirva para seguir con su trabajo"
                        },
                        new
                        {
                            Id = 3,
                            DonacionId = 3,
                            Eliminado = false,
                            MensajeDonador = "Gracias por todo lo que hacen"
                        });
                });

            modelBuilder.Entity("ScanServices.Models.DetallesTraduccion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("CompraId")
                        .HasColumnType("int");

                    b.Property<bool>("Eliminado")
                        .HasColumnType("tinyint(1)");

                    b.Property<int?>("EmpleadoCleanerId")
                        .HasColumnType("int");

                    b.Property<int?>("EmpleadoEncargadoId")
                        .HasColumnType("int");

                    b.Property<int?>("EmpleadoTraductorId")
                        .HasColumnType("int");

                    b.Property<int?>("EmpleadoTyperId")
                        .HasColumnType("int");

                    b.Property<int?>("ManwhaId")
                        .HasColumnType("int");

                    b.Property<int>("ManwhasId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmpleadoCleanerId");

                    b.HasIndex("EmpleadoEncargadoId");

                    b.HasIndex("EmpleadoTraductorId");

                    b.HasIndex("EmpleadoTyperId");

                    b.HasIndex("ManwhaId");

                    b.ToTable("DetallesTraducciones");
                });

            modelBuilder.Entity("ScanServices.Models.Donacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Descuento")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("DonadorId")
                        .HasColumnType("int");

                    b.Property<bool>("Eliminado")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("FormaPago")
                        .HasColumnType("int");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.HasIndex("DonadorId");

                    b.ToTable("Donaciones");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Descuento = 5m,
                            DonadorId = 1,
                            Eliminado = false,
                            Fecha = new DateTime(2024, 11, 25, 11, 10, 21, 277, DateTimeKind.Local).AddTicks(6903),
                            FormaPago = 3,
                            Total = 3000m
                        },
                        new
                        {
                            Id = 2,
                            Descuento = 10m,
                            DonadorId = 2,
                            Eliminado = false,
                            Fecha = new DateTime(2024, 11, 25, 11, 10, 21, 277, DateTimeKind.Local).AddTicks(6924),
                            FormaPago = 0,
                            Total = 5000m
                        },
                        new
                        {
                            Id = 3,
                            Descuento = 21m,
                            DonadorId = 1,
                            Eliminado = false,
                            Fecha = new DateTime(2024, 11, 25, 11, 10, 21, 277, DateTimeKind.Local).AddTicks(6926),
                            FormaPago = 1,
                            Total = 8000m
                        });
                });

            modelBuilder.Entity("ScanServices.Models.Donador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Eliminado")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Pais")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Telefonos")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal>("TotalDonado")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.ToTable("Donadores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Eliminado = false,
                            Nombre = "Damian",
                            Pais = "Argentina",
                            Telefonos = "123456789",
                            TotalDonado = 1000m
                        },
                        new
                        {
                            Id = 2,
                            Eliminado = false,
                            Nombre = "Lorena",
                            Pais = "Chile",
                            Telefonos = "987654321",
                            TotalDonado = 2000m
                        },
                        new
                        {
                            Id = 3,
                            Eliminado = false,
                            Nombre = "Carlos",
                            Pais = "Cuba",
                            Telefonos = "555666777",
                            TotalDonado = 3000m
                        },
                        new
                        {
                            Id = 4,
                            Eliminado = false,
                            Nombre = "Ana",
                            Pais = "Brasil",
                            Telefonos = "444555666",
                            TotalDonado = 2500m
                        },
                        new
                        {
                            Id = 5,
                            Eliminado = false,
                            Nombre = "Pedro",
                            Pais = "Peru",
                            Telefonos = "333444555",
                            TotalDonado = 1500m
                        });
                });

            modelBuilder.Entity("ScanServices.Models.Empleado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("Eliminado")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("PuestoEmpleado")
                        .HasColumnType("int");

                    b.Property<string>("Telefonos")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Empleados");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Correo = "cesartorres21@gmail.com",
                            Eliminado = false,
                            FechaNacimiento = new DateTime(1985, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Cesar Torres",
                            PuestoEmpleado = 3,
                            Telefonos = "123456789"
                        },
                        new
                        {
                            Id = 2,
                            Correo = "agustinasan32@gmail.com",
                            Eliminado = false,
                            FechaNacimiento = new DateTime(1990, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Agustina Santillan",
                            PuestoEmpleado = 2,
                            Telefonos = "987654321"
                        },
                        new
                        {
                            Id = 3,
                            Correo = "lucasdjo431@gmail.com",
                            Eliminado = false,
                            FechaNacimiento = new DateTime(1978, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Lucas Djovanni",
                            PuestoEmpleado = 1,
                            Telefonos = "555666777"
                        },
                        new
                        {
                            Id = 4,
                            Correo = "ananoseda320@gmail.com",
                            Eliminado = false,
                            FechaNacimiento = new DateTime(2000, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Ana Noseda",
                            PuestoEmpleado = 0,
                            Telefonos = "444555666"
                        },
                        new
                        {
                            Id = 5,
                            Correo = "pedrogimenez5463@gmail.com",
                            Eliminado = false,
                            FechaNacimiento = new DateTime(1995, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Pedro Gimenez",
                            PuestoEmpleado = 1,
                            Telefonos = "333444555"
                        },
                        new
                        {
                            Id = 6,
                            Correo = "camilaperez@gmail.com",
                            Eliminado = false,
                            FechaNacimiento = new DateTime(1992, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Camila Perez",
                            PuestoEmpleado = 2,
                            Telefonos = "222333444"
                        });
                });

            modelBuilder.Entity("ScanServices.Models.Manwha", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Capitulos")
                        .HasColumnType("decimal(65,30)");

                    b.Property<bool>("Eliminado")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("ImagenUrl")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("Popular")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Sinopsis")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Manwhas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Capitulos = 528m,
                            Eliminado = false,
                            ImagenUrl = "https://i.pinimg.com/564x/bb/3c/f7/bb3cf78908440b3b06898fb0fd9935da.jpg",
                            Nombre = "Lookism",
                            Popular = false,
                            Sinopsis = "Daniel Park, o Park Hyung Suk, es un estudiante de secundaria impopular, gordo y feo que es intimidado y despreciado.\r\nDecidido a huir de sus problemas actuales y comenzar de nuevo, se muda a Seúl y asiste a una nueva escuela secundaria. Sin embargo, una noche durante las vacaciones, obtiene un nuevo cuerpo alto, musculoso y muy guapo. También se da cuenta de que al dormir en un cuerpo, despierta en el otro, y que no importa si lleva 24 horas seguidas despierto, siempre se siente descansado en el cuerpo que ocupa.\r\nMientras Daniel vive su vida con sus dos cuerpos, comienza a ver cuánto el mundo discrimina a las personas simplemente por ser poco atractivas o diferentes. De ahí el nombre de la obra \"Lookism\"."
                        },
                        new
                        {
                            Id = 2,
                            Capitulos = 165m,
                            Eliminado = false,
                            ImagenUrl = "https://i.pinimg.com/564x/43/cf/63/43cf6368ec1b14bf4b069601fbdfbdff.jpg",
                            Nombre = "Manager Kim",
                            Popular = false,
                            Sinopsis = "Padre soltero, gerente de la compañía y ex miembro de operaciones encubiertas, el Sr. Kim vivió una vida normal hasta que su hija, Minji, desapareció. Después de descubrir que su hija podría estar muerta, el Sr. Kim se vuelve despiadado y busca información. Rescatará a su hija por cualquier medio necesario, incluso si eso significa destruir todo y a todos los que se interpongan en su camino."
                        },
                        new
                        {
                            Id = 3,
                            Capitulos = 163m,
                            Eliminado = false,
                            ImagenUrl = "https://i.pinimg.com/564x/18/7c/41/187c410a2f4d705ed87bc881843a35cf.jpg",
                            Nombre = "Quest Supremacy",
                            Popular = false,
                            Sinopsis = "Kim SooHyun es un estudiante de secundaria normal que no es bueno para estudiar, pelear o ser atractivo. De repente, se enfrenta a una ventana de menú justo frente a sus ojos para acto seguido recibir los poderes de un [sistema] de juego de la nada, ¿cómo enfrentará nuestro héroe los desafíos que tiene por delante?"
                        },
                        new
                        {
                            Id = 4,
                            Capitulos = 141m,
                            Eliminado = false,
                            ImagenUrl = "https://static.wikia.nocookie.net/vsbattles/images/b/b4/Dowan-reality-quest.jpg",
                            Nombre = "Reality Quest",
                            Popular = true,
                            Sinopsis = "Debido a la amenaza del matón de la escuela de conseguirle objetos raros en un juego de movil, Ha Do-wan, el desafortunado jugador de videojuegos, murió después de jugar dia y noche durante una semana. En el momento en que murió, fue revivido en su clase, una semana antes de morir… Todo seguia igual que aquel día. ¡Lo único que ha cambiado es la que flota delante de él! ¿Qué? ¡¿Utilizara las habilidades de los juegos que ha jugado hasta ahora para vencer al tipo que le hacia bulling?!"
                        },
                        new
                        {
                            Id = 5,
                            Capitulos = 68m,
                            Eliminado = false,
                            ImagenUrl = "https://i.pinimg.com/originals/d9/3b/1c/d93b1c5bd932f0d22fdea2a7960053b7.jpg",
                            Nombre = "Killer Pietro",
                            Popular = true,
                            Sinopsis = "Luego de consagrar su vida a la organización criminal El Club de la Gloria, Pietro abandona su carrera de sicario legendario para pasar sus últimos días a cargo de una tienda de libros de segunda. Motivados por la amenaza que supone, la organización aprovecha su edad para eliminarlo. Pero al borde de la muerte, un golpe de suerte le permite regresar a sus años mozos y recuperar la fuerza que perdió con el tiempo. Ahora que está en óptimas condiciones, Pietro se vengará de la organización que lo traicionó."
                        });
                });

            modelBuilder.Entity("ScanServices.Models.Origen", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Eliminado")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Origenes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Eliminado = false,
                            Nombre = "Coreano"
                        },
                        new
                        {
                            Id = 2,
                            Eliminado = false,
                            Nombre = "Chino"
                        },
                        new
                        {
                            Id = 3,
                            Eliminado = false,
                            Nombre = "Japones"
                        });
                });

            modelBuilder.Entity("ScanServices.Models.Solicitud", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("CantidadCapitulos")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("Comentario")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("Eliminado")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("ManwhaPedido")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Solicitudes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CantidadCapitulos = 50m,
                            Comentario = "Me gustaría que lo traduzcan al español",
                            Eliminado = false,
                            Fecha = new DateTime(2021, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ManwhaPedido = "Prision Juvenil"
                        },
                        new
                        {
                            Id = 2,
                            CantidadCapitulos = 72m,
                            Comentario = "Si es posible me encantaria que lo traduzcan al español",
                            Eliminado = false,
                            Fecha = new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ManwhaPedido = "The Breaker"
                        },
                        new
                        {
                            Id = 3,
                            CantidadCapitulos = 0m,
                            Comentario = "por favor traduzcanlo al español",
                            Eliminado = false,
                            Fecha = new DateTime(2021, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ManwhaPedido = "To not Die"
                        },
                        new
                        {
                            Id = 4,
                            CantidadCapitulos = 100m,
                            Comentario = "Apreciaria mucho que lo traduzcan",
                            Eliminado = false,
                            Fecha = new DateTime(2021, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ManwhaPedido = "The God of High School"
                        });
                });

            modelBuilder.Entity("ScanServices.Models.DetallesDonacion", b =>
                {
                    b.HasOne("ScanServices.Models.Donacion", "Donacion")
                        .WithMany("DetallesDonacion")
                        .HasForeignKey("DonacionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Donacion");
                });

            modelBuilder.Entity("ScanServices.Models.DetallesTraduccion", b =>
                {
                    b.HasOne("ScanServices.Models.Empleado", "EmpleadoCleaner")
                        .WithMany()
                        .HasForeignKey("EmpleadoCleanerId");

                    b.HasOne("ScanServices.Models.Empleado", "EmpleadoEncargado")
                        .WithMany()
                        .HasForeignKey("EmpleadoEncargadoId");

                    b.HasOne("ScanServices.Models.Empleado", "EmpleadoTraductor")
                        .WithMany()
                        .HasForeignKey("EmpleadoTraductorId");

                    b.HasOne("ScanServices.Models.Empleado", "EmpleadoTyper")
                        .WithMany()
                        .HasForeignKey("EmpleadoTyperId");

                    b.HasOne("ScanServices.Models.Manwha", "Manwha")
                        .WithMany()
                        .HasForeignKey("ManwhaId");

                    b.Navigation("EmpleadoCleaner");

                    b.Navigation("EmpleadoEncargado");

                    b.Navigation("EmpleadoTraductor");

                    b.Navigation("EmpleadoTyper");

                    b.Navigation("Manwha");
                });

            modelBuilder.Entity("ScanServices.Models.Donacion", b =>
                {
                    b.HasOne("ScanServices.Models.Donador", "Donador")
                        .WithMany()
                        .HasForeignKey("DonadorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Donador");
                });

            modelBuilder.Entity("ScanServices.Models.Donacion", b =>
                {
                    b.Navigation("DetallesDonacion");
                });
#pragma warning restore 612, 618
        }
    }
}
