using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpConfigEmpresaYandeh
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdEmpresa { get; set; }

    public string DsChaveApi { get; set; } = null!;

    public virtual ErpEmpresa ErpEmpresa { get; set; } = null!;
}
