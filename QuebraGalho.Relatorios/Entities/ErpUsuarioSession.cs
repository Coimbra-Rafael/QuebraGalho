using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpUsuarioSession
{
    public string IdSession { get; set; } = null!;

    public decimal IdUsuario { get; set; }

    public decimal IdEmpresa { get; set; }

    public DateTime DthrLogin { get; set; }

    public string NrLicenca { get; set; } = null!;

    public virtual ErpUsuario ErpUsuario { get; set; } = null!;
}
