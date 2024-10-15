using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpMovimentoRecebimento
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdMovimento { get; set; }

    public decimal IdEmpresa { get; set; }

    public decimal NrItem { get; set; }

    public decimal IdRecebimento { get; set; }

    public string DmSituacao { get; set; } = null!;

    public string? Impressao { get; set; }

    public string? ImpressaoEstorno { get; set; }

    public string? Numeroautorizacao { get; set; }

    public string? Numerocontrole { get; set; }

    public string? Numerodoc { get; set; }

    public string? Bandeira { get; set; }

    public decimal VlRecebimento { get; set; }

    public decimal VlTroco { get; set; }

    public virtual ErpMovimento ErpMovimento { get; set; } = null!;
}
