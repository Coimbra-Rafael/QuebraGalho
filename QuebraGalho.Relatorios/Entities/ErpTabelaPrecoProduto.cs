using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpTabelaPrecoProduto
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdTabelaPreco { get; set; }

    public DateTime DtInicio { get; set; }

    public decimal IdProdutoServico { get; set; }

    public decimal PercMargem { get; set; }

    public decimal VlPreco { get; set; }

    public decimal IdUsuario { get; set; }

    public string Identificador { get; set; } = null!;

    public decimal VlCusto { get; set; }

    public virtual ErpProdutoServico ErpProdutoServico { get; set; } = null!;

    public virtual ErpTabelaPreco ErpTabelaPreco { get; set; } = null!;

    public virtual ErpUsuario ErpUsuario { get; set; } = null!;
}
