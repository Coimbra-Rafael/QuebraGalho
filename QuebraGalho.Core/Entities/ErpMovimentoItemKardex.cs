using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpMovimentoItemKardex
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdMovimento { get; set; }

    public decimal IdEmpresa { get; set; }

    public decimal NrItem { get; set; }

    public string IdKardex { get; set; } = null!;

    public virtual ErpKardex ErpKardex { get; set; } = null!;

    public virtual ErpMovimentoItem ErpMovimentoItem { get; set; } = null!;
}
