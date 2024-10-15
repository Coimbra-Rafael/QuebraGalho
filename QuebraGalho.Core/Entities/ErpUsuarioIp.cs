using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpUsuarioIp
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdUsuario { get; set; }

    public string NrIp { get; set; } = null!;

    public virtual ErpUsuario ErpUsuario { get; set; } = null!;
}
