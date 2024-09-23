using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpTipoPagamento
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdTipoPagamento { get; set; }

    public string DsTipoPagamento { get; set; } = null!;

    public decimal? IdTipoMovimento { get; set; }

    public virtual ErpTipoMovimentoBanco? ErpTipoMovimentoBanco { get; set; }

    public virtual ICollection<ErpTituloPagarBaixa> ErpTituloPagarBaixas { get; set; } = new List<ErpTituloPagarBaixa>();
}
