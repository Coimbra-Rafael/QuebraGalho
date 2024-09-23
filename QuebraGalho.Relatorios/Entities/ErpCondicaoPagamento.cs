using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpCondicaoPagamento
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdCondicaoPagamento { get; set; }

    public string DsCondicaoPagamento { get; set; } = null!;

    public decimal PercDesconto { get; set; }

    public decimal PercAcrescimo { get; set; }

    public decimal PercComissao { get; set; }

    public decimal? IdTabelaPreco { get; set; }

    public virtual ICollection<ErpCondicaoPagamentoDetalhe> ErpCondicaoPagamentoDetalhes { get; set; } = new List<ErpCondicaoPagamentoDetalhe>();

    public virtual ICollection<ErpMovimento> ErpMovimentos { get; set; } = new List<ErpMovimento>();

    public virtual ICollection<ErpPedidoVendum> ErpPedidoVenda { get; set; } = new List<ErpPedidoVendum>();

    public virtual ErpTabelaPreco? ErpTabelaPreco { get; set; }
}
