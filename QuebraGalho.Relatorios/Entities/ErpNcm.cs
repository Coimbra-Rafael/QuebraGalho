using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpNcm
{
    public decimal IdNcm { get; set; }

    public string CdNcm { get; set; } = null!;

    public string DsNcm { get; set; } = null!;

    public decimal? PercTributoMuncipal { get; set; }

    public decimal? PercTributoEstadual { get; set; }

    public decimal? PercTributoFederal { get; set; }

    public string? DsVersao { get; set; }

    public string? DsFonte { get; set; }

    public decimal? PercTributoImportado { get; set; }
}
