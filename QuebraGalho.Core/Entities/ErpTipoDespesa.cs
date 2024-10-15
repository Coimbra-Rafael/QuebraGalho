using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpTipoDespesa
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdTipoDespesa { get; set; }

    public decimal IdSubgrupoDespesa { get; set; }

    public string DsTipoDespesa { get; set; } = null!;

    public virtual ICollection<ErpEntradaGemFinanceiro> ErpEntradaGemFinanceiros { get; set; } = new List<ErpEntradaGemFinanceiro>();

    public virtual ErpSubgrupoDespesa ErpSubgrupoDespesa { get; set; } = null!;

    public virtual ICollection<ErpTituloPagar> ErpTituloPagars { get; set; } = new List<ErpTituloPagar>();
}
