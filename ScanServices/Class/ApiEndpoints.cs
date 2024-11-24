using ScanServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScanServices.Class
{
    public static class ApiEndpoints
    {
        public static string Donador { get; set; } = "donadores";
        public static string Donacion { get; set; } = "donaciones";
        public static string DetallesDonacion { get; set; } = "detallesdonaciones";
        public static string DetallesTraduccion { get; set; } = "detallesraducciones";
        public static string Origen { get; set; } = "origenes";
        public static string Manwha { get; set; } = "manwhas";
        public static string Empleado { get; set; } = "empleados";
        public static string Solicitud { get; set; } = "solicitudes";
        




        public static string GetEndpoint(string name)
        {
            return name switch
            {
                nameof(Donador) => Donador,
                nameof(Donacion) => Donacion,
                nameof(DetallesDonacion) => DetallesDonacion,
                nameof(DetallesTraduccion) => DetallesTraduccion,
                nameof(Origen) => Origen,
                nameof(Manwha) => Manwha,
                nameof(Empleado) => Empleado,
                nameof(Solicitud) => Solicitud,


                _ => throw new ArgumentException($"Endpoint '{name}' no está definido.")
            };
        }
    }
}
