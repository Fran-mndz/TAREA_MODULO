﻿using System;
using System.Collections.Generic;

namespace TAREA_MODULO.AppMVCDataFirst.Models;

public partial class Proveedore
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Direccion { get; set; }

    public string? Telefono { get; set; }

    public string? Email { get; set; }
}
