using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpEntradaGemItem
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdGem { get; set; }

    public decimal IdEmpresa { get; set; }

    public decimal NrItem { get; set; }

    public decimal IdProdutoServico { get; set; }

    public decimal Quantidade { get; set; }

    public decimal VlUnitario { get; set; }

    public decimal VlProdutos { get; set; }

    public string DmOrigem { get; set; } = null!;

    public string CstCsosnIcms { get; set; } = null!;

    public decimal VlBaseIcms { get; set; }

    public decimal AliqIcms { get; set; }

    public decimal VlIcms { get; set; }

    public decimal VlBaseIcmsSt { get; set; }

    public decimal AliqIcmsSt { get; set; }

    public decimal VlIcmsSt { get; set; }

    public string? CstIpi { get; set; }

    public decimal VlBaseIpi { get; set; }

    public decimal AliqIpi { get; set; }

    public decimal VlIpi { get; set; }

    public string? CstPis { get; set; }

    public decimal VlBasePis { get; set; }

    public decimal AliqPis { get; set; }

    public decimal VlPis { get; set; }

    public string? CstCofins { get; set; }

    public decimal VlBaseCofins { get; set; }

    public decimal AliqCofins { get; set; }

    public decimal VlCofins { get; set; }

    public decimal PercDesconto { get; set; }

    public decimal VlDesconto { get; set; }

    public decimal VlDespesasAcessorias { get; set; }

    public decimal VlTotalItem { get; set; }

    public decimal AliqIss { get; set; }

    public string? CdServico { get; set; }

    public decimal VlIss { get; set; }

    public decimal? PercMva { get; set; }

    public decimal? QuantidadeFator { get; set; }

    public string? CdClassificacaoFiscal { get; set; }

    public decimal? VlFrete { get; set; }

    public string? DescricaoItemXml { get; set; }

    public decimal? VlFcp { get; set; }

    public decimal? PesoUnitario { get; set; }

    public virtual ErpEntradaGem ErpEntradaGem { get; set; } = null!;

    public virtual ICollection<ErpEntradaGemItemKardex> ErpEntradaGemItemKardices { get; set; } = new List<ErpEntradaGemItemKardex>();

    public virtual ICollection<ErpEntradaGemItemLote> ErpEntradaGemItemLotes { get; set; } = new List<ErpEntradaGemItemLote>();

    public virtual ICollection<ErpEntradaGemItemRateio> ErpEntradaGemItemRateios { get; set; } = new List<ErpEntradaGemItemRateio>();

    public virtual ErpProdutoServico ErpProdutoServico { get; set; } = null!;
}
