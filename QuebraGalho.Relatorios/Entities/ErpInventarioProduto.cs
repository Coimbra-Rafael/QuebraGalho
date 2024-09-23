using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpInventarioProduto
{
    public string NrLicenca { get; set; } = null!;

    public string IdInventario { get; set; } = null!;

    public decimal IdProdutoServico { get; set; }

    public decimal QtdeContagem { get; set; }

    public decimal IdUsuarioContagem { get; set; }

    public decimal VlCustoProduto { get; set; }

    public string? DmAtualizado { get; set; }

    public virtual ErpInventario ErpInventario { get; set; } = null!;

    public virtual ErpProdutoServico ErpProdutoServico { get; set; } = null!;
}
