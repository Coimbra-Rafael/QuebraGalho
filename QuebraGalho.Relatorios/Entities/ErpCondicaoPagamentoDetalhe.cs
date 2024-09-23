using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpCondicaoPagamentoDetalhe
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdCondicaoPagamento { get; set; }

    public decimal NrDia { get; set; }

    public virtual ErpCondicaoPagamento ErpCondicaoPagamento { get; set; } = null!;
}
