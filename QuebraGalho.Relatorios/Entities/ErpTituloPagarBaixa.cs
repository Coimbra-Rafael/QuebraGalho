using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpTituloPagarBaixa
{
    public string NrLicenca { get; set; } = null!;

    public string IdBaixaPagar { get; set; } = null!;

    public decimal IdTitulo { get; set; }

    public decimal IdEmpresa { get; set; }

    public DateOnly DtBaixa { get; set; }

    public decimal VlBaixa { get; set; }

    public decimal IdUsuario { get; set; }

    public decimal IdBancoConta { get; set; }

    public decimal IdTipoPagamento { get; set; }

    public string? DsObservacao { get; set; }

    public virtual ErpBancoContum ErpBancoContum { get; set; } = null!;

    public virtual ErpTipoPagamento ErpTipoPagamento { get; set; } = null!;

    public virtual ErpTituloPagar ErpTituloPagar { get; set; } = null!;

    public virtual ICollection<ErpTituloPagarBaixaMovimentoBanco> ErpTituloPagarBaixaMovimentoBancos { get; set; } = new List<ErpTituloPagarBaixaMovimentoBanco>();
}
