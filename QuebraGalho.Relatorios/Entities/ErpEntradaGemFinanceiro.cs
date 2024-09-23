using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpEntradaGemFinanceiro
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdGem { get; set; }

    public decimal IdEmpresa { get; set; }

    public DateTime DtVencimento { get; set; }

    public decimal IdTipoDespesa { get; set; }

    public string? NrDocumento { get; set; }

    public decimal VlDuplicata { get; set; }

    public decimal NrItem { get; set; }

    public virtual ErpEntradaGem ErpEntradaGem { get; set; } = null!;

    public virtual ErpTipoDespesa ErpTipoDespesa { get; set; } = null!;
}
