using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;
using ScanServices.Enums;
using ScanServices.Models;

namespace ScanService.DataContext;



public partial class ScanContext : DbContext
{
    public ScanContext()
    {
    }

    public ScanContext(DbContextOptions<ScanContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Empleado> Empleados { get; set; }

    public virtual DbSet<Solicitud> Solicitudes { get; set; }

    public virtual DbSet<DetallesTraduccion> DetallesTraducciones { get; set; }

    public virtual DbSet<Donador> Donadores { get; set; }

    public virtual DbSet<Origen> Origenes { get; set; }

    public virtual DbSet<Manwha> Manwhas { get; set; }

    public virtual DbSet<Donacion> Donaciones { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

    {
        var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

        string? cadenaConexion = configuration.GetConnectionString("mysqlRemoto");
        optionsBuilder.UseMySql(cadenaConexion, ServerVersion.AutoDetect(cadenaConexion));
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        #region datos semilla Scan
        //carga de datos semilla Manwhas
        modelBuilder.Entity<Manwha>().HasData(
            new Manwha()
            {
                Id = 1,
                Nombre = "Lookism",
                Capitulos = 528,
                Sinopsis = "Daniel Park, o Park Hyung Suk, es un estudiante de secundaria impopular, gordo y feo que es intimidado y despreciado.\r\nDecidido a huir de sus problemas actuales y comenzar de nuevo, se muda a Seúl y asiste a una nueva escuela secundaria. Sin embargo, una noche durante las vacaciones, obtiene un nuevo cuerpo alto, musculoso y muy guapo. También se da cuenta de que al dormir en un cuerpo, despierta en el otro, y que no importa si lleva 24 horas seguidas despierto, siempre se siente descansado en el cuerpo que ocupa.\r\nMientras Daniel vive su vida con sus dos cuerpos, comienza a ver cuánto el mundo discrimina a las personas simplemente por ser poco atractivas o diferentes. De ahí el nombre de la obra \"Lookism\".",
                ImagenUrl = "https://i.pinimg.com/564x/bb/3c/f7/bb3cf78908440b3b06898fb0fd9935da.jpg",
                Favoritos = true
            },
            new Manwha()
            {
                Id = 2,
                Nombre = "Manager Kim",
                Capitulos = 165,
                Sinopsis = "Padre soltero, gerente de la compañía y ex miembro de operaciones encubiertas, el Sr. Kim vivió una vida normal hasta que su hija, Minji, desapareció. Después de descubrir que su hija podría estar muerta, el Sr. Kim se vuelve despiadado y busca información. Rescatará a su hija por cualquier medio necesario, incluso si eso significa destruir todo y a todos los que se interpongan en su camino.",
                ImagenUrl = "https://i.pinimg.com/564x/43/cf/63/43cf6368ec1b14bf4b069601fbdfbdff.jpg"
            },
            new Manwha()
            {
                Id = 3,
                Nombre = "Quest Supremacy",
                Capitulos = 163,
                Sinopsis = "Kim SooHyun es un estudiante de secundaria normal que no es bueno para estudiar, pelear o ser atractivo. De repente, se enfrenta a una ventana de menú justo frente a sus ojos para acto seguido recibir los poderes de un [sistema] de juego de la nada, ¿cómo enfrentará nuestro héroe los desafíos que tiene por delante?",
                ImagenUrl = "https://i.pinimg.com/564x/18/7c/41/187c410a2f4d705ed87bc881843a35cf.jpg"
            },
            new Manwha()
            {
                Id = 4,
                Nombre = "Reality Quest",
                Capitulos = 141,
                Sinopsis = "Debido a la amenaza del matón de la escuela de conseguirle objetos raros en un juego de movil, Ha Do-wan, el desafortunado jugador de videojuegos, murió después de jugar dia y noche durante una semana. En el momento en que murió, fue revivido en su clase, una semana antes de morir… Todo seguia igual que aquel día. ¡Lo único que ha cambiado es la que flota delante de él! ¿Qué? ¡¿Utilizara las habilidades de los juegos que ha jugado hasta ahora para vencer al tipo que le hacia bulling?!",
                ImagenUrl = "https://static.wikia.nocookie.net/vsbattles/images/b/b4/Dowan-reality-quest.jpg",
                Popular = true
            },
            new Manwha()
            {
                Id = 5,
                Nombre = "Killer Pietro",
                Capitulos = 68,
                Sinopsis = "Luego de consagrar su vida a la organización criminal El Club de la Gloria, Pietro abandona su carrera de sicario legendario para pasar sus últimos días a cargo de una tienda de libros de segunda. Motivados por la amenaza que supone, la organización aprovecha su edad para eliminarlo. Pero al borde de la muerte, un golpe de suerte le permite regresar a sus años mozos y recuperar la fuerza que perdió con el tiempo. Ahora que está en óptimas condiciones, Pietro se vengará de la organización que lo traicionó.",
                ImagenUrl = "https://i.pinimg.com/originals/d9/3b/1c/d93b1c5bd932f0d22fdea2a7960053b7.jpg",
                Popular = true
            }
            );
        //carga de datos semilla de Origenes
        modelBuilder.Entity<Origen>().HasData(
            new Origen() { Id = 1, Nombre = "Coreano" },
            new Origen() { Id = 2, Nombre = "Chino" },
            new Origen() { Id = 3, Nombre = "Japones" }
            );
        //carga de datos semilla de Empleados
        modelBuilder.Entity<Empleado>().HasData(
        new Empleado
        {
            Id = 1,
            Nombre = "Cesar Torres",
            Telefonos = "123456789",
            PuestoEmpleado = PuestoEmpleadoEnum.Encargado,
            FechaNacimiento = new DateTime(1985, 5, 15),
            Correo = "cesartorres21@gmail.com"
        },
        new Empleado
        {
            Id = 2,
            Nombre = "Agustina Santillan",
            Telefonos = "987654321",
            PuestoEmpleado = PuestoEmpleadoEnum.Traductor,
            FechaNacimiento = new DateTime(1990, 8, 25),
            Correo = "agustinasan32@gmail.com"
        },
        new Empleado
        {
            Id = 3,
            Nombre = "Lucas Djovanni",
            Telefonos = "555666777",
            PuestoEmpleado = PuestoEmpleadoEnum.Typer,
            FechaNacimiento = new DateTime(1978, 2, 3),
            Correo = "lucasdjo431@gmail.com"
        },
        new Empleado
        {
            Id = 4,
            Nombre = "Ana Noseda",
            Telefonos = "444555666",
            PuestoEmpleado = PuestoEmpleadoEnum.Cleaner,
            FechaNacimiento = new DateTime(2000, 12, 12),
            Correo = "ananoseda320@gmail.com"
        },
        new Empleado
        {
            Id = 5,
            Nombre = "Pedro Gimenez",
            Telefonos = "333444555",
            PuestoEmpleado = PuestoEmpleadoEnum.Typer,
            FechaNacimiento = new DateTime(1995, 7, 30),
            Correo = "pedrogimenez5463@gmail.com"
        },
        new Empleado
        {
            Id = 6,
            Nombre = "Camila Perez",
            Telefonos = "222333444",
            PuestoEmpleado = PuestoEmpleadoEnum.Traductor,
            FechaNacimiento = new DateTime(1992, 10, 10),
            Correo = "camilaperez@gmail.com"
        }

        );
        //carga de datos semilla de Donadores
        modelBuilder.Entity<Donador>().HasData(
        new Donador
        {
            Id = 1,
            Nombre = "Damian",
            Pais = "Argentina",
            Telefonos = "123456789",
            TotalDonado = 1000,
        },
        new Donador
        {
            Id = 2,
            Nombre = "Lorena",
            Pais = "Chile",
            Telefonos = "987654321",
            TotalDonado = 2000,
        },
        new Donador
        {
            Id = 3,
            Nombre = "Carlos",
            Pais = "Cuba",
            Telefonos = "555666777",
            TotalDonado = 3000,
        },
        new Donador
        {
            Id = 4,
            Nombre = "Ana",
            Pais = "Brasil",
            Telefonos = "444555666",
            TotalDonado = 2500,
        },
        new Donador
        {
            Id = 5,
            Nombre = "Pedro",
            Pais = "Peru",
            Telefonos = "333444555",
            TotalDonado = 1500,
        }

        );
        //Carga de datos semillas de Donaciones
        modelBuilder.Entity<Donacion>().HasData(
            new Donacion()
            {
                Id = 1,
                FormaPago = FormaDePagoEnum.Paypal,
                Total = 3000,
                DonadorId = 1,
                Fecha = DateTime.Now
         
            },
            new Donacion() { Id = 2, FormaPago = FormaDePagoEnum.Tarjeta_Credito, Total = 5000, DonadorId = 2, Fecha = DateTime.Now },
            new Donacion() { Id = 3, FormaPago = FormaDePagoEnum.Tarjeta_Debito, Total = 8000, DonadorId = 1, Fecha = DateTime.Now }
        );

        //carga de datos semilla de Solicitudes
        modelBuilder.Entity<Solicitud>().HasData(
            new Solicitud
            {
                Id = 1,
                ManwhaPedido = "Prision Juvenil",
                Comentario = "Me gustaría que lo traduzcan al español",
                CantidadCapitulos = 50,
                Fecha = new DateTime(2021, 5, 15),
            },
            new Solicitud
            {
                Id = 2,
                ManwhaPedido = "The Breaker",
                Comentario = "Si es posible me encantaria que lo traduzcan al español",
                CantidadCapitulos = 72,
                Fecha = new DateTime(2021, 5, 16),
            },
            new Solicitud
            {
                Id = 3,
                ManwhaPedido = "To not Die",
                Comentario = "por favor traduzcanlo al español",
                Fecha = new DateTime(2021, 5, 17),

            },
            new Solicitud
            {
                Id = 4,
                ManwhaPedido = "The God of High School",
                Comentario = "Apreciaria mucho que lo traduzcan",
                CantidadCapitulos = 100,
                Fecha = new DateTime(2021, 5, 18),

            }
        );


        #endregion


        #region definición de filtros de eliminación
        // (este código no lo habilitamos todavía porque es cuando agregamos un campo Eliminado a las tablas y modificamos los
        // ApiControllers para que al mandar a eliminar solo cambien este campo y lo pongan en verdadero, esta configuración de
        // eliminación hace que el sistema ignore los registros que tengan el eliminado en verdadero, así que hace que en
        // apariencia y funcionalidad esté "eliminado", pero van a seguir estando ahí para que podamos observar las eliminaciones que hubo)
        modelBuilder.Entity<Empleado>().HasQueryFilter(m => !m.Eliminado);
        modelBuilder.Entity<Solicitud>().HasQueryFilter(m => !m.Eliminado);
        modelBuilder.Entity<DetallesTraduccion>().HasQueryFilter(m => !m.Eliminado);
        modelBuilder.Entity<Origen>().HasQueryFilter(m => !m.Eliminado);
        modelBuilder.Entity<Manwha>().HasQueryFilter(m => !m.Eliminado);
        modelBuilder.Entity<Donacion>().HasQueryFilter(m => !m.Eliminado);
        #endregion
    }
   
}

