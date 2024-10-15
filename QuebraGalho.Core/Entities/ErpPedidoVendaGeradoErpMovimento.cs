using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpPedidoVendaGeradoErpMovimento
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdEmpresa { get; set; }

    public decimal IdPedidoVenda { get; set; }

    public decimal IdMovimento { get; set; }

    public virtual ErpMovimento ErpMovimento { get; set; } = null!;

    public virtual ErpPedidoVendum ErpPedidoVendum { get; set; } = null!;
}
