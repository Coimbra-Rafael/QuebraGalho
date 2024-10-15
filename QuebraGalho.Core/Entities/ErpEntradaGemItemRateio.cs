using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpEntradaGemItemRateio
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdEmpresa { get; set; }

    public decimal IdGem { get; set; }

    public decimal NrItem { get; set; }

    public decimal IdTipo { get; set; }

    public decimal VlRateio { get; set; }

    public virtual ErpEntradaGemItem ErpEntradaGemItem { get; set; } = null!;
}
