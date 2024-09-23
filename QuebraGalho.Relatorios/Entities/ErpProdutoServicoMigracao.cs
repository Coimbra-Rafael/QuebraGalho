using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpProdutoServicoMigracao
{
    public string NrLicenca { get; set; } = null!;

    public string Identificador { get; set; } = null!;

    public string IdProdutosCodigos { get; set; } = null!;

    public string DsProdutoServico { get; set; } = null!;

    public string? DsGrupoProduto { get; set; }

    public string? DsSubgrupoProduto { get; set; }

    public string? DsCategoriaProduto { get; set; }

    public string DmOrigem { get; set; } = null!;

    public string IdUnidadeMedida { get; set; } = null!;

    public string CdNcm { get; set; } = null!;

    public decimal PesoBruto { get; set; }

    public decimal PesoLiquido { get; set; }

    public decimal QtdeEmbalagem { get; set; }

    public decimal VlCusto { get; set; }

    public decimal VlPreco { get; set; }

    public decimal? IdProdutoServico { get; set; }

    public string DmControlaLote { get; set; } = null!;

    public string DmProdutoBalanca { get; set; } = null!;

    public decimal QtdeEstoque { get; set; }

    public string? DsRegraFiscalSat { get; set; }

    public decimal IdPerfilTributarioNfe { get; set; }

    public string DmProcessado { get; set; } = null!;
}
