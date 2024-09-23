using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpMovimentoItem
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdMovimento { get; set; }

    public decimal IdEmpresa { get; set; }

    public decimal NrItem { get; set; }

    public decimal IdProdutoServico { get; set; }

    public decimal Quantidade { get; set; }

    public decimal VlUnitario { get; set; }

    public decimal VlProdutos { get; set; }

    public decimal VlDesconto { get; set; }

    public decimal PercDesconto { get; set; }

    public decimal AliqIcms { get; set; }

    public decimal VlBaseIcms { get; set; }

    public decimal VlIcms { get; set; }

    public decimal PercRedIcms { get; set; }

    public decimal AliqIcmsSubst { get; set; }

    public decimal VlBaseIcmsSubst { get; set; }

    public decimal VlIcmsSubst { get; set; }

    public decimal PercRedIcmsSubst { get; set; }

    public decimal PercMva { get; set; }

    public string DmDetBaseIcms { get; set; } = null!;

    public decimal VlBaseIcmsSubstRet { get; set; }

    public decimal VlIcmsSubstRet { get; set; }

    public string DmDetBaseIcmsSt { get; set; } = null!;

    public string CdClassificacao { get; set; } = null!;

    public string? CdServico { get; set; }

    public string? CstCsosn { get; set; }

    public string IdUnidade { get; set; } = null!;

    public string? IdUnidadeTrib { get; set; }

    public decimal? VlUnitarioTrib { get; set; }

    public decimal? QuantidadeTrib { get; set; }

    public decimal? VlProdutosTrib { get; set; }

    public string? DsComplementar { get; set; }

    public decimal VlBaseIpi { get; set; }

    public decimal AliqIpi { get; set; }

    public decimal VlIpi { get; set; }

    public string? CdEnquadramento { get; set; }

    public string? CstIpi { get; set; }

    public decimal VlBasePis { get; set; }

    public decimal AliqPis { get; set; }

    public decimal VlPis { get; set; }

    public string CstPis { get; set; } = null!;

    public decimal VlBaseCofins { get; set; }

    public decimal AliqCofins { get; set; }

    public decimal VlCofins { get; set; }

    public string CstCofins { get; set; } = null!;

    public decimal VlFrete { get; set; }

    public decimal VlSeguro { get; set; }

    public decimal VlDespesasAcessorias { get; set; }

    public decimal PercFcp { get; set; }

    public decimal PercUfDestInter { get; set; }

    public decimal PercUfDestIntest { get; set; }

    public decimal PercPartilha { get; set; }

    public decimal VlIcmsFcp { get; set; }

    public decimal VlIcmsUfDest { get; set; }

    public decimal VlIcmsUfRem { get; set; }

    public decimal VlDescDi { get; set; }

    public string? NrDrawback { get; set; }

    public decimal VlTotal { get; set; }

    public string? IdProdutosCodigos { get; set; }

    public string? DsProdutoServico { get; set; }

    public decimal? IdPromocao { get; set; }

    public string? DmSituacao { get; set; }

    public decimal? AliqIcmsCredito { get; set; }

    public decimal? VlIcmsCredito { get; set; }

    public decimal? PercComissao { get; set; }

    public decimal? VlComissao { get; set; }

    public virtual ErpMovimento ErpMovimento { get; set; } = null!;

    public virtual ErpMovimentoItemKardex? ErpMovimentoItemKardex { get; set; }

    public virtual ICollection<ErpMovimentoItemLote> ErpMovimentoItemLotes { get; set; } = new List<ErpMovimentoItemLote>();

    public virtual ErpProdutoServico ErpProdutoServico { get; set; } = null!;
}
