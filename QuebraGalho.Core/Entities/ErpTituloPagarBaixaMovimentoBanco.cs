using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpTituloPagarBaixaMovimentoBanco
{
    public string NrLicenca { get; set; } = null!;

    public string IdBaixaPagar { get; set; } = null!;

    public string IdMovimento { get; set; } = null!;

    public virtual ErpMovimentoBanco ErpMovimentoBanco { get; set; } = null!;

    public virtual ErpTituloPagarBaixa ErpTituloPagarBaixa { get; set; } = null!;
}
