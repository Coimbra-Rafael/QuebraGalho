using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpMovimentoBanco
{
    public string NrLicenca { get; set; } = null!;

    public string IdMovimento { get; set; } = null!;

    public decimal IdEmpresa { get; set; }

    public DateOnly DtMovimento { get; set; }

    public decimal IdBancoConta { get; set; }

    public decimal VlMovimento { get; set; }

    public decimal IdTipoMovimento { get; set; }

    public string? DsObservacao { get; set; }

    public virtual ICollection<ErpTituloPagarBaixaMovimentoBanco> ErpTituloPagarBaixaMovimentoBancos { get; set; } = new List<ErpTituloPagarBaixaMovimentoBanco>();

    public virtual ICollection<ErpTituloReceberBaixaMovimentoBanco> ErpTituloReceberBaixaMovimentoBancos { get; set; } = new List<ErpTituloReceberBaixaMovimentoBanco>();
}
