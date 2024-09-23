using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpProdutoServico
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdProdutoServico { get; set; }

    public string DsProdutoServico { get; set; } = null!;

    public string DmProdutoServico { get; set; } = null!;

    public decimal? IdCategoria { get; set; }

    public decimal? IdNcm { get; set; }

    public string? IdEan13 { get; set; }

    public string CdProdutoServico { get; set; } = null!;

    public string DmOrigem { get; set; } = null!;

    public string IdUnidadeMedida { get; set; } = null!;

    public string DmTipoItem { get; set; } = null!;

    public string? CdCest { get; set; }

    public decimal NrPesoLiquido { get; set; }

    public decimal NrPesoBruto { get; set; }

    public string? DmControlaLote { get; set; }

    public decimal? QtdeEmbalagem { get; set; }

    public string DmSituacao { get; set; } = null!;

    public string DmProdutoBalanca { get; set; } = null!;

    public DateTime? DthrAtualizacao { get; set; }

    public decimal? VlCusto { get; set; }

    public string? NrReferencia { get; set; }

    public string? CdProdutoExterno { get; set; }

    public string? NrTamanho { get; set; }

    public decimal? IdCor { get; set; }

    public decimal? NrAltura { get; set; }

    public decimal? NrLargura { get; set; }

    public decimal? NrComprimento { get; set; }

    public decimal? IdGrupoPrecoProduto { get; set; }

    public DateTime? DthrInclusao { get; set; }

    public string? NrDiasValidadeBalanca { get; set; }

    public decimal? IdGrupo { get; set; }

    public decimal? IdSubgrupo { get; set; }

    public string? NmImpressora { get; set; }

    public string? DsObservacao { get; set; }

    public virtual ErpCategoriaProduto? ErpCategoriaProduto { get; set; }

    public virtual ICollection<ErpEntradaGemItem> ErpEntradaGemItems { get; set; } = new List<ErpEntradaGemItem>();

    public virtual ICollection<ErpGestaoPreco> ErpGestaoPrecos { get; set; } = new List<ErpGestaoPreco>();

    public virtual ErpGrupoPrecoProduto? ErpGrupoPrecoProduto { get; set; }

    public virtual ErpGrupoProduto? ErpGrupoProduto { get; set; }

    public virtual ICollection<ErpInventarioProduto> ErpInventarioProdutos { get; set; } = new List<ErpInventarioProduto>();

    public virtual ICollection<ErpKardex> ErpKardices { get; set; } = new List<ErpKardex>();

    public virtual ICollection<ErpMovimentoEstoqueProduto> ErpMovimentoEstoqueProdutos { get; set; } = new List<ErpMovimentoEstoqueProduto>();

    public virtual ICollection<ErpMovimentoItem> ErpMovimentoItems { get; set; } = new List<ErpMovimentoItem>();

    public virtual ICollection<ErpProducaoFicha> ErpProducaoFichas { get; set; } = new List<ErpProducaoFicha>();

    public virtual ICollection<ErpProdutoSaldo> ErpProdutoSaldos { get; set; } = new List<ErpProdutoSaldo>();

    public virtual ICollection<ErpProdutoServicoCodigo> ErpProdutoServicoCodigos { get; set; } = new List<ErpProdutoServicoCodigo>();

    public virtual ICollection<ErpProdutoServicoComponente> ErpProdutoServicoComponenteErpProdutoServicoNavigations { get; set; } = new List<ErpProdutoServicoComponente>();

    public virtual ICollection<ErpProdutoServicoComponente> ErpProdutoServicoComponenteErpProdutoServicos { get; set; } = new List<ErpProdutoServicoComponente>();

    public virtual ICollection<ErpProdutoServicoDesossa> ErpProdutoServicoDesossaErpProdutoServicoNavigations { get; set; } = new List<ErpProdutoServicoDesossa>();

    public virtual ICollection<ErpProdutoServicoDesossa> ErpProdutoServicoDesossaErpProdutoServicos { get; set; } = new List<ErpProdutoServicoDesossa>();

    public virtual ICollection<ErpProdutoServicoDesossaPerdum> ErpProdutoServicoDesossaPerda { get; set; } = new List<ErpProdutoServicoDesossaPerdum>();

    public virtual ICollection<ErpProdutoServicoFornecedoresCotacao> ErpProdutoServicoFornecedoresCotacaos { get; set; } = new List<ErpProdutoServicoFornecedoresCotacao>();

    public virtual ErpProdutoServicoLock? ErpProdutoServicoLock { get; set; }

    public virtual ICollection<ErpProdutoServicoOutro> ErpProdutoServicoOutros { get; set; } = new List<ErpProdutoServicoOutro>();

    public virtual ICollection<ErpProdutoValorMedio> ErpProdutoValorMedios { get; set; } = new List<ErpProdutoValorMedio>();

    public virtual ErpSubgrupoProduto? ErpSubgrupoProduto { get; set; }

    public virtual ICollection<ErpSugestaoCompra> ErpSugestaoCompras { get; set; } = new List<ErpSugestaoCompra>();

    public virtual ICollection<ErpTabelaPrecoProduto> ErpTabelaPrecoProdutos { get; set; } = new List<ErpTabelaPrecoProduto>();

    public virtual ErpLicenca NrLicencaNavigation { get; set; } = null!;
}
