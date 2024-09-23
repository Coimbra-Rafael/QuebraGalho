using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class PdvCartoesBandeira
{
    public string NrLicenca { get; set; } = null!;

    public string IdCartoesBandeira { get; set; } = null!;

    public string IdBandeira { get; set; } = null!;

    public string DmDebitoCredito { get; set; } = null!;

    public decimal DiaCompensacao { get; set; }

    public decimal PercTarifa { get; set; }

    public virtual CartoesBandeira IdBandeiraNavigation { get; set; } = null!;
}
