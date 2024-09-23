using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpVendaProduto
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdEmpresa { get; set; }

    public string IdVenda { get; set; } = null!;

    public decimal NrItem { get; set; }

    public string DsProdutoServico { get; set; } = null!;

    public string IdProdutosCodigos { get; set; } = null!;

    public decimal VlQuantidade { get; set; }

    public decimal VlUnitario { get; set; }

    public decimal VlSubTotal { get; set; }

    public virtual ErpVendum ErpVendum { get; set; } = null!;
}
