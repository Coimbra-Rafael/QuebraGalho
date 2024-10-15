using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpProdutoServicoOutro
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdProdutoServico { get; set; }

    public decimal IdEmpresa { get; set; }

    public decimal QtdeMinimaEstoque { get; set; }

    public decimal QtdeMaximaEstoque { get; set; }

    public string? DsRegraTributacaoSat { get; set; }

    public string? DsLocalizacaoProduto { get; set; }

    public decimal? IdPerfilTributario { get; set; }

    public decimal? PercComissao { get; set; }

    public virtual ErpPerfilTributario? ErpPerfilTributario { get; set; }

    public virtual ErpProdutoServico ErpProdutoServico { get; set; } = null!;
}
