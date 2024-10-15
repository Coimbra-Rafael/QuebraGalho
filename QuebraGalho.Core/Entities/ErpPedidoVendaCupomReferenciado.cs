using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpPedidoVendaCupomReferenciado
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdEmpresa { get; set; }

    public decimal IdPedidoVenda { get; set; }

    public string NrChaveAcesso { get; set; } = null!;

    public virtual ErpPedidoVendum ErpPedidoVendum { get; set; } = null!;
}
