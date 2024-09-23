using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpPedidoVendaItemPendente
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdEmpresa { get; set; }

    public decimal IdPedidoVenda { get; set; }

    public decimal NrItem { get; set; }

    public decimal IdProdutoServico { get; set; }

    public decimal Quantidade { get; set; }

    public decimal VlUnitario { get; set; }

    public decimal VlProdutos { get; set; }

    public decimal VlDesconto { get; set; }

    public string? DsObservacao { get; set; }

    public decimal VlFlex { get; set; }

    public virtual ErpPedidoVendaPendente ErpPedidoVendaPendente { get; set; } = null!;
}
