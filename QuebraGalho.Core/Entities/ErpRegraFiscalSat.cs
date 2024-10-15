using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpRegraFiscalSat
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdRegraFiscal { get; set; }

    public string DsDescricao { get; set; } = null!;

    public string DsRegraFiscal { get; set; } = null!;
}
