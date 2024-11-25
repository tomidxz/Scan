using ScanServices.Enums;
using System;
using System.Collections.Generic;

namespace ScanServices.Models;

public partial class Solicitud
{
    public int Id { get; set; }

    public string ManwhaPedido { get; set; } = null!;
    public string Comentario { get; set; } = null!;
    public decimal CantidadCapitulos { get; set; }
    public DateTime Fecha { get; set; }
    public bool Eliminado { get; set; } = false;
}
