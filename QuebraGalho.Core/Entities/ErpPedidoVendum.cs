using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpPedidoVendum
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdEmpresa { get; set; }

    public decimal IdPedidoVenda { get; set; }

    public decimal IdNaturezaOperacao { get; set; }

    public decimal IdPessoa { get; set; }

    public decimal? IdPessoaVendedor { get; set; }

    public DateTime DtPedido { get; set; }

    public DateTime? DtPrevisao { get; set; }

    public string DmStatus { get; set; } = null!;

    public string DmTipoFrete { get; set; } = null!;

    public decimal VlFrete { get; set; }

    public decimal PercDesconto { get; set; }

    public string? NrChaveAcessoReferencia { get; set; }

    public decimal VlDespAcessorias { get; set; }

    public decimal IdCondicaoPagamento { get; set; }

    public string? DsObservacao { get; set; }

    public decimal? VlDesconto { get; set; }

    public decimal? IdPessoaTransportador { get; set; }

    public string? NrPedidoCliente { get; set; }

    public string? NrColeta { get; set; }

    public string? DsDadosAdicionais { get; set; }

    public decimal? NrPesoBruto { get; set; }

    public decimal? NrPesoLiquido { get; set; }

    public decimal? VolumesQtde { get; set; }

    public string? VolumesEspecie { get; set; }

    public decimal? VolumesNumero { get; set; }

    public string? VolumesMarca { get; set; }

    public virtual ErpCondicaoPagamento ErpCondicaoPagamento { get; set; } = null!;

    public virtual ICollection<ErpMovimento> ErpMovimentos { get; set; } = new List<ErpMovimento>();

    public virtual ErpNaturezaOperacao ErpNaturezaOperacao { get; set; } = null!;

    public virtual ICollection<ErpPedidoVendaCupomReferenciado> ErpPedidoVendaCupomReferenciados { get; set; } = new List<ErpPedidoVendaCupomReferenciado>();

    public virtual ICollection<ErpPedidoVendaGeradoErpMovimento> ErpPedidoVendaGeradoErpMovimentos { get; set; } = new List<ErpPedidoVendaGeradoErpMovimento>();

    public virtual ErpPessoa ErpPessoa { get; set; } = null!;

    public virtual ErpPessoa? ErpPessoaNavigation { get; set; }
}
