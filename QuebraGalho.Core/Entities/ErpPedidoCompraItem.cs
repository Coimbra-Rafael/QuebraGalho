using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpPedidoCompraItem
{
    public string NrLicenca { get; set; } = null!;

    public decimal NrPedido { get; set; }

    public decimal NrItem { get; set; }

    public decimal IdProdutoServico { get; set; }

    public decimal Quantidade { get; set; }

    public decimal ValorUnitario { get; set; }

    public decimal? QuantidadeEntregue { get; set; }

    public decimal? ValorUnitarioEntregue { get; set; }

    public virtual ErpPedidoCompra ErpPedidoCompra { get; set; } = null!;
}
