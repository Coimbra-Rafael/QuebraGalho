using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpPedidoCompra
{
    public string NrLicenca { get; set; } = null!;

    public decimal NrPedido { get; set; }

    public decimal IdPessoa { get; set; }

    public DateTime DthrEmissao { get; set; }

    public DateTime DthrPedido { get; set; }

    public DateTime DtPrevisaoEntrega { get; set; }

    public string DmSituacao { get; set; } = null!;

    public string? IdentificadorCotacao { get; set; }

    public decimal? IdUsuario { get; set; }

    public virtual ICollection<ErpPedidoCompraItem> ErpPedidoCompraItems { get; set; } = new List<ErpPedidoCompraItem>();
}
