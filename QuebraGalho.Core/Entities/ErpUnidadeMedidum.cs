using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpUnidadeMedidum
{
    public string NrLicenca { get; set; } = null!;

    public string IdUnidadeMedida { get; set; } = null!;

    public string DsUnidadeMedida { get; set; } = null!;

    public virtual ErpLicenca NrLicencaNavigation { get; set; } = null!;
}
