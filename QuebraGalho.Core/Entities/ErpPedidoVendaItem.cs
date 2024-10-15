using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpPedidoVendaItem
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdEmpresa { get; set; }

    public decimal IdPedidoVenda { get; set; }

    public decimal NrItem { get; set; }

    public decimal IdProdutoServico { get; set; }

    public decimal Quantidade { get; set; }

    public decimal VlUnitario { get; set; }

    public decimal VlProdutos { get; set; }

    public decimal PercDesconto { get; set; }

    public decimal VlDesconto { get; set; }

    public decimal VlFrete { get; set; }

    public decimal VlDespAcessorias { get; set; }

    public decimal VlBaseIcms { get; set; }

    public decimal AliqIcms { get; set; }

    public decimal VlIcms { get; set; }

    public decimal VlBaseIcmsSt { get; set; }

    public decimal AliqIcmsSt { get; set; }

    public decimal PercMva { get; set; }

    public decimal VlIcmsSt { get; set; }

    public string? CstCsosn { get; set; }

    public string? CdClassificacaoFiscal { get; set; }

    public decimal VlBaseIpi { get; set; }

    public decimal AliqIpi { get; set; }

    public decimal VlIpi { get; set; }

    public string? CstIpi { get; set; }

    public decimal VlBasePis { get; set; }

    public decimal AliqPis { get; set; }

    public decimal VlPis { get; set; }

    public string? CstPis { get; set; }

    public decimal VlBaseCofins { get; set; }

    public decimal AliqCofins { get; set; }

    public decimal VlCofins { get; set; }

    public string? CstCofins { get; set; }

    public decimal VlTotalPedido { get; set; }

    public decimal VlBaseFcp { get; set; }

    public decimal PercFcp { get; set; }

    public decimal VlFcp { get; set; }

    public decimal PercIcmsInterFcp { get; set; }

    public decimal PercIcmsInterPartilha { get; set; }

    public decimal VlIcmsUfDest { get; set; }

    public decimal VlIcmsUfRem { get; set; }

    public decimal VlFcpUfDest { get; set; }

    public string? DsMensagemRegra { get; set; }

    public string? IdProdutosCodigos { get; set; }

    public decimal? AliqIcmsCredito { get; set; }

    public decimal? VlIcmsCredito { get; set; }
}
