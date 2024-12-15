using ScanServices.Enums;
using System;
using System.Collections.Generic;

namespace ScanServices.Models;

public partial class Donacion
{
    public int Id { get; set; }
    public DateTime Fecha { get; set; }
    public virtual Donador? Donador { get; set; }
    public int? DonadorId { get; set; }
    public virtual Empleado? Empleado { get; set; }
    public int? EmpleadoId { get; set; }

    public FormaDePagoEnum FormaPago { get; set; }

    public decimal Total { get; set; }

    public bool Eliminado { get; set; } = false;


}
