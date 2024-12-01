using ScanServices.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScanServices.Models;

public partial class DetallesDonacion
{
    public int Id { get; set; }
    
    public int DonacionId { get; set; }
    public virtual Donacion? Donacion { get; set; } = null!;
    public virtual Donacion? Donador { get; set; } = null!;
    public virtual Donacion? Total { get; set; } = null!;
    public virtual Empleado? Empleado { get; set; } = null!;
    public int EmpleadoId { get; set; }
    public string MensajeDonador { get; set; } = null!;

    public bool Eliminado { get; set; } = false;

}
