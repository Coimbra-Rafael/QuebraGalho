using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpGrupoDespesa
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdGrupoDespesa { get; set; }

    public string DsGrupoDespesa { get; set; } = null!;

    public virtual ICollection<ErpSubgrupoDespesa> ErpSubgrupoDespesas { get; set; } = new List<ErpSubgrupoDespesa>();

    public virtual ErpLicenca NrLicencaNavigation { get; set; } = null!;
}
