using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpMovimentoCancelamento
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdMovimento { get; set; }

    public decimal IdEmpresa { get; set; }

    public DateTime DthrCancelamento { get; set; }

    public decimal IdUsuarioCancelamento { get; set; }

    public string? DsJustificativa { get; set; }

    public virtual ErpMovimento ErpMovimento { get; set; } = null!;
}
