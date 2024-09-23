using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpBancoCarteira
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdCarteira { get; set; }

    public string DsCarteira { get; set; } = null!;

    public decimal IdBancoConta { get; set; }

    public string? NrCarteira { get; set; }

    public string? NrPrefixo { get; set; }

    public decimal? NrNossoNumero { get; set; }

    public decimal? NrPrazoProtesto { get; set; }

    public string? DmFluxoCaixa { get; set; }

    public decimal? NrDiasBloqueio { get; set; }

    public decimal? NrVariacaoCarteira { get; set; }

    public string? DmImpressaoBoleto { get; set; }

    public decimal? VlJurosMensal { get; set; }

    public virtual ErpBancoContum ErpBancoContum { get; set; } = null!;

    public virtual ICollection<ErpPedidoVendaParcela> ErpPedidoVendaParcelas { get; set; } = new List<ErpPedidoVendaParcela>();

    public virtual ICollection<ErpPessoaCliente> ErpPessoaClientes { get; set; } = new List<ErpPessoaCliente>();

    public virtual ICollection<ErpTituloReceber> ErpTituloRecebers { get; set; } = new List<ErpTituloReceber>();
}
