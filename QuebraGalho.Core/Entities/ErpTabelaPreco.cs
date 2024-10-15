using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpTabelaPreco
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdTabelaPreco { get; set; }

    public string DsTabelaPreco { get; set; } = null!;

    public DateOnly DtInicioVigencia { get; set; }

    public DateOnly DtTerminoVigencia { get; set; }

    public virtual ICollection<ErpCondicaoPagamento> ErpCondicaoPagamentos { get; set; } = new List<ErpCondicaoPagamento>();

    public virtual ICollection<ErpGestaoPreco> ErpGestaoPrecos { get; set; } = new List<ErpGestaoPreco>();

    public virtual ICollection<ErpPessoaCliente> ErpPessoaClientes { get; set; } = new List<ErpPessoaCliente>();

    public virtual ICollection<ErpProdutoServicoCodigo> ErpProdutoServicoCodigos { get; set; } = new List<ErpProdutoServicoCodigo>();

    public virtual ICollection<ErpTabelaPrecoProduto> ErpTabelaPrecoProdutos { get; set; } = new List<ErpTabelaPrecoProduto>();
}
