using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpPedidoCotacaoPendenteItem
{
    public string NrLicenca { get; set; } = null!;

    public string Identificador { get; set; } = null!;

    public decimal NrItem { get; set; }

    public decimal IdProdutoServico { get; set; }

    public decimal QtdePedida { get; set; }

    public virtual ErpPedidoCotacaoPendente ErpPedidoCotacaoPendente { get; set; } = null!;
}
