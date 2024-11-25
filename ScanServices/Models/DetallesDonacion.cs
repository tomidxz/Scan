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
    public string MensajeDonador { get; set; } = null!;

    public bool Eliminado { get; set; } = false;

}
