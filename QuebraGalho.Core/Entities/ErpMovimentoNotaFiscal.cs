using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpMovimentoNotaFiscal
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdMovimento { get; set; }

    public decimal IdEmpresa { get; set; }

    public string? XmlEmissao { get; set; }

    public byte[]? DanfeEmissao { get; set; }

    public string? DsStatus { get; set; }

    public string? DmPreview { get; set; }

    public virtual ErpMovimento ErpMovimento { get; set; } = null!;
}
