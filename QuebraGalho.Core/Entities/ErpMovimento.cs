using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpMovimento
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdMovimento { get; set; }

    public decimal IdEmpresa { get; set; }

    public decimal? IdPessoa { get; set; }

    public decimal? IdPessoaVendedor { get; set; }

    public decimal? IdPessoaTransportador { get; set; }

    public decimal? IdCondicaoPagamento { get; set; }

    public decimal? IdPedidoVenda { get; set; }

    public decimal IdNaturezaOperacao { get; set; }

    public string? NrPedidoCliente { get; set; }

    public string DmCancelamento { get; set; } = null!;

    public string DmStatus { get; set; } = null!;

    public string DmEntradaSaida { get; set; } = null!;

    public decimal VlBaseIcms { get; set; }

    public decimal VlIcms { get; set; }

    public decimal VlBaseIcmsSubst { get; set; }

    public decimal VlIcmsSubst { get; set; }

    public decimal VlBaseIpi { get; set; }

    public decimal VlIpi { get; set; }

    public decimal VlBasePis { get; set; }

    public decimal VlPis { get; set; }

    public decimal VlBaseCofins { get; set; }

    public decimal VlCofins { get; set; }

    public decimal VlFrete { get; set; }

    public decimal VlDesconto { get; set; }

    public decimal VlDespesasAcessorias { get; set; }

    public decimal VlSeguro { get; set; }

    public decimal VlProdutos { get; set; }

    public decimal VlDescIcmsSuframa { get; set; }

    public decimal VlDespesaAduaneira { get; set; }

    public decimal VlSiscomex { get; set; }

    public decimal VlAfrmm { get; set; }

    public string? NrDocumento { get; set; }

    public string? NrSerie { get; set; }

    public DateTime? DtEmissao { get; set; }

    public DateTime? DtEntradaSaida { get; set; }

    public string DmTipoFrete { get; set; } = null!;

    public decimal NrPesoLiquido { get; set; }

    public decimal NrPesoBruto { get; set; }

    public decimal VolumesQtde { get; set; }

    public string VolumesEspecie { get; set; } = null!;

    public decimal VolumesNumero { get; set; }

    public string VolumesMarca { get; set; } = null!;

    public string? DsDadosAdicionais { get; set; }

    public string DsNaturezaOperacao { get; set; } = null!;

    public string DmFinalidadeEmissao { get; set; } = null!;

    public string DmConsumidorFinal { get; set; } = null!;

    public string? DmTipoTransporte { get; set; }

    public string? DmFormaImportacao { get; set; }

    public string? NrCnpjTerceiros { get; set; }

    public string? IdUfExportacao { get; set; }

    public string? NrDocumentoImportacao { get; set; }

    public DateOnly? DtDocumentoImportacao { get; set; }

    public string? NrChaveAcesso { get; set; }

    public string? NrChaveAcessoRef { get; set; }

    public string CdModeloDocumento { get; set; } = null!;

    public string? NrColeta { get; set; }

    public string? IdVendaPdv { get; set; }

    public decimal? VlTotal { get; set; }

    public decimal IdUsuario { get; set; }

    public decimal? IdUsuarioCancelamento { get; set; }

    public string? IdComputador { get; set; }

    public string? DmEnviadoScantech { get; set; }

    public string? NrCpfCnpjConsumidor { get; set; }

    public decimal? VlTroco { get; set; }

    public decimal? NrVenda { get; set; }

    public string? Ippc { get; set; }

    public string? Usupc { get; set; }

    public string? NrExtratoSat { get; set; }

    public virtual ErpComputador? ErpComputador { get; set; }

    public virtual ErpCondicaoPagamento? ErpCondicaoPagamento { get; set; }

    public virtual ErpMovimentoCancelamento? ErpMovimentoCancelamento { get; set; }

    public virtual ICollection<ErpMovimentoCupomReferenciado> ErpMovimentoCupomReferenciados { get; set; } = new List<ErpMovimentoCupomReferenciado>();

    public virtual ICollection<ErpMovimentoItem> ErpMovimentoItems { get; set; } = new List<ErpMovimentoItem>();

    public virtual ErpMovimentoNotaFiscal? ErpMovimentoNotaFiscal { get; set; }

    public virtual ICollection<ErpMovimentoRecebimento> ErpMovimentoRecebimentos { get; set; } = new List<ErpMovimentoRecebimento>();

    public virtual ErpMovimentoXmlImportado? ErpMovimentoXmlImportado { get; set; }

    public virtual ErpNaturezaOperacao ErpNaturezaOperacao { get; set; } = null!;

    public virtual ICollection<ErpPedidoVendaGeradoErpMovimento> ErpPedidoVendaGeradoErpMovimentos { get; set; } = new List<ErpPedidoVendaGeradoErpMovimento>();

    public virtual ErpPedidoVendum? ErpPedidoVendum { get; set; }

    public virtual ErpPessoa? ErpPessoa { get; set; }

    public virtual ErpPessoa? ErpPessoa1 { get; set; }

    public virtual ErpPessoa? ErpPessoaNavigation { get; set; }
}
