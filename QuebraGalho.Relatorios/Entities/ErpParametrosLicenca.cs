using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpParametrosLicenca
{
    public string NrLicenca { get; set; } = null!;

    public string NmParametro { get; set; } = null!;

    public string GrupoParametro { get; set; } = null!;

    public string? VlParametro { get; set; }

    public string DsParametro { get; set; } = null!;

    public string? ParametroNovo { get; set; }

    public virtual ErpParametrosDefault NmParametroNavigation { get; set; } = null!;
}
