using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpUsuarioIp
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdUsuario { get; set; }

    public string NrIp { get; set; } = null!;

    public virtual ErpUsuario ErpUsuario { get; set; } = null!;
}
