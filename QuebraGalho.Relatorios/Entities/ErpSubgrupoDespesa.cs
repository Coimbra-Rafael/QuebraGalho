using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpSubgrupoDespesa
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdSubgrupoDespesa { get; set; }

    public decimal IdGrupoDespesa { get; set; }

    public string DsSubgrupoDespesa { get; set; } = null!;

    public virtual ErpGrupoDespesa ErpGrupoDespesa { get; set; } = null!;

    public virtual ICollection<ErpTipoDespesa> ErpTipoDespesas { get; set; } = new List<ErpTipoDespesa>();
}
