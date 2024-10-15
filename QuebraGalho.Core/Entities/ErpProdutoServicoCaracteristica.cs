using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpProdutoServicoCaracteristica
{
    public string NrLicenca { get; set; } = null!;

    public string NrReferencia { get; set; } = null!;

    public decimal IdCaracteristica { get; set; }

    public virtual ErpCaracteristica ErpCaracteristica { get; set; } = null!;
}
