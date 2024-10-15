using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpPedidoVendaParcela
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdEmpresa { get; set; }

    public decimal IdPedidoVenda { get; set; }

    public decimal NrParcela { get; set; }

    public decimal VlParcela { get; set; }

    public DateTime DtVencimento { get; set; }

    public decimal? IdCarteira { get; set; }

    public virtual ErpBancoCarteira? ErpBancoCarteira { get; set; }
}
