using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpVendum
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdEmpresa { get; set; }

    public string IdVenda { get; set; } = null!;

    public decimal? NrComanda { get; set; }

    public decimal? IdCliente { get; set; }

    public string? NmCliente { get; set; }

    public string? DsObservacao { get; set; }

    public string DmSituacao { get; set; } = null!;

    public decimal IdUsuario { get; set; }

    public decimal NrVenda { get; set; }

    public virtual ICollection<ErpVendaProduto> ErpVendaProdutos { get; set; } = new List<ErpVendaProduto>();
}
