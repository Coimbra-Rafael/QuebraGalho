using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpProdutoServicoCodigo
{
    public string NrLicenca { get; set; } = null!;

    public string IdProdutosCodigos { get; set; } = null!;

    public decimal IdProdutoServico { get; set; }

    public string IdUnidadeMedida { get; set; } = null!;

    public string? DsProdutoCodigo { get; set; }

    public decimal? IdTabelaPreco { get; set; }

    public decimal? QtdeFatorEntrada { get; set; }

    public string? DmCodigoPrincipal { get; set; }

    public decimal? QtdeFatorSaida { get; set; }

    public virtual ErpProdutoServico ErpProdutoServico { get; set; } = null!;

    public virtual ICollection<ErpProdutoServicoEmpresaPreco> ErpProdutoServicoEmpresaPrecos { get; set; } = new List<ErpProdutoServicoEmpresaPreco>();

    public virtual ICollection<ErpPromocaoProdutosCodigo> ErpPromocaoProdutosCodigos { get; set; } = new List<ErpPromocaoProdutosCodigo>();

    public virtual ICollection<ErpSincCodigo> ErpSincCodigos { get; set; } = new List<ErpSincCodigo>();

    public virtual ErpTabelaPreco? ErpTabelaPreco { get; set; }
}
