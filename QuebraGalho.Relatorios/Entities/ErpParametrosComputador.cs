using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpParametrosComputador
{
    public string NrLicenca { get; set; } = null!;

    public string IdComputador { get; set; } = null!;

    public string NmParametro { get; set; } = null!;

    public string GrupoParametro { get; set; } = null!;

    public string? VlParametro { get; set; }

    public string? DsParametro { get; set; }

    public string? Identificador { get; set; }

    public string? ParametroNovo { get; set; }

    public virtual ErpComputador ErpComputador { get; set; } = null!;
}
