using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpConfigEmpresaModulo
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdEmpresa { get; set; }

    public string DmUsaDesossa { get; set; } = null!;

    public string DmUsaProducao { get; set; } = null!;

    public string DmUsaParametrosAntigo { get; set; } = null!;

    public string? DmUsaCotacao { get; set; }

    public virtual ErpEmpresa ErpEmpresa { get; set; } = null!;
}
