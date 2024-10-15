using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpProxCodigo
{
    public string NrLicenca { get; set; } = null!;

    public string NmEntidade { get; set; } = null!;

    public decimal NrUltimoCodigo { get; set; }
}
