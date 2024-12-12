using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScanServices.Models;

public partial class DetallesTraduccion
{
    public int Id { get; set; }
    public DateTime Fecha { get; set; }

    public int? ManwhaId { get; set; }
    public virtual Manwha? Manwha { get; set; }

    public int? EmpleadoEncargadoId { get; set; }

    public Empleado? EmpleadoEncargado { get; set; }

    public int? EmpleadoTraductorId { get; set; }
    public Empleado? EmpleadoTraductor { get; set; }

    public int? EmpleadoTyperId { get; set; }
    public Empleado? EmpleadoTyper { get; set; }

    public int? EmpleadoCleanerId { get; set; }
    public Empleado? EmpleadoCleaner { get; set; }


    public decimal CapituloTraducido { get; set; }

    public bool Eliminado { get; set; } = false;

}
