using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpCaixaMovimentoVenda
{
    public string NrLicenca { get; set; } = null!;

    public string IdMovimento { get; set; } = null!;

    public string IdVenda { get; set; } = null!;

    public decimal IdEmpresa { get; set; }

    public virtual ErpCaixaMovimento ErpCaixaMovimento { get; set; } = null!;
}
