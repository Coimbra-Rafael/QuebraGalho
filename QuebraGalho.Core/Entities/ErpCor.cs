using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpCor
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdCor { get; set; }

    public string DsCor { get; set; } = null!;

    public string? CdCorExterno { get; set; }

    public string DmEnviaEcommerce { get; set; } = null!;
}
