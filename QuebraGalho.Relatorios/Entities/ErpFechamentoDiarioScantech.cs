using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpFechamentoDiarioScantech
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdEmpresa { get; set; }

    public decimal IdCaixa { get; set; }

    public DateTime DtFechamento { get; set; }

    public decimal QtdeVendas { get; set; }

    public decimal VlFechamento { get; set; }

    public decimal QtdeCancelamentos { get; set; }

    public decimal VlCancelamentos { get; set; }

    public virtual ErpEmpresa ErpEmpresa { get; set; } = null!;
}
