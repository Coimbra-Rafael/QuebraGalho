using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpTeste
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdTeste { get; set; }

    public string DsTeste { get; set; } = null!;
}
