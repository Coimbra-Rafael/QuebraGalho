using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpPedidoCotacaoItem
{
    public string NrLicenca { get; set; } = null!;

    public decimal NrCotacao { get; set; }

    public decimal IdPessoa { get; set; }

    public decimal NrItem { get; set; }

    public decimal IdProdutoServico { get; set; }

    public decimal QtdePedida { get; set; }

    public decimal QtdeAtendida { get; set; }

    public decimal ValorUnitario { get; set; }

    public string? DmVencedor { get; set; }

    public virtual ErpPedidoCotacao ErpPedidoCotacao { get; set; } = null!;
}
