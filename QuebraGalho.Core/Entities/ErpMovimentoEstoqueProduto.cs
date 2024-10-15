using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpMovimentoEstoqueProduto
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdMovimento { get; set; }

    public decimal IdEmpresa { get; set; }

    public decimal NrItem { get; set; }

    public decimal IdProdutoServico { get; set; }

    public decimal Quantidade { get; set; }

    public decimal VlMovimento { get; set; }

    public virtual ICollection<ErpKardexMovimentoEstoqueProduto> ErpKardexMovimentoEstoqueProdutos { get; set; } = new List<ErpKardexMovimentoEstoqueProduto>();

    public virtual ErpMovimentoEstoque ErpMovimentoEstoque { get; set; } = null!;

    public virtual ErpProdutoServico ErpProdutoServico { get; set; } = null!;
}
