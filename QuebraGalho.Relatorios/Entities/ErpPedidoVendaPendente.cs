using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpPedidoVendaPendente
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdEmpresa { get; set; }

    public decimal IdPedidoVenda { get; set; }

    public DateTime DthrPedido { get; set; }

    public decimal IdPessoa { get; set; }

    public decimal? IdPessoaVendedor { get; set; }

    public string? IdImei { get; set; }

    public string DmStatus { get; set; } = null!;

    public decimal IdUsuario { get; set; }

    public virtual ICollection<ErpPedidoVendaItemPendente> ErpPedidoVendaItemPendentes { get; set; } = new List<ErpPedidoVendaItemPendente>();
}
