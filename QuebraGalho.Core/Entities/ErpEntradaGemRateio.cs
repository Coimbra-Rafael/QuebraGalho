using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpEntradaGemRateio
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdEmpresa { get; set; }

    public decimal IdGem { get; set; }

    public decimal IdTipo { get; set; }

    public decimal VlRateio { get; set; }

    public string? DsObservacao { get; set; }

    public virtual ErpEntradaGem ErpEntradaGem { get; set; } = null!;

    public virtual ErpEntradaTipoRateio ErpEntradaTipoRateio { get; set; } = null!;
}
