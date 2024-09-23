using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpLicencaSession
{
    public string IdSession { get; set; } = null!;

    public string NrLicenca { get; set; } = null!;

    public virtual ErpLicenca NrLicencaNavigation { get; set; } = null!;
}
