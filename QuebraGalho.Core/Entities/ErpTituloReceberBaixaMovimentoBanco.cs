using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpTituloReceberBaixaMovimentoBanco
{
    public string NrLicenca { get; set; } = null!;

    public string IdBaixaReceber { get; set; } = null!;

    public string IdMovimento { get; set; } = null!;

    public virtual ErpMovimentoBanco ErpMovimentoBanco { get; set; } = null!;

    public virtual ErpTituloReceberBaixa ErpTituloReceberBaixa { get; set; } = null!;
}
