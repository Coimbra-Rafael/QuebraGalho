using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpCategoriaProduto
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdCategoria { get; set; }

    public decimal IdSubgrupo { get; set; }

    public string DsCategoria { get; set; } = null!;

    public virtual ICollection<ErpProdutoServico> ErpProdutoServicos { get; set; } = new List<ErpProdutoServico>();

    public virtual ErpSubgrupoProduto ErpSubgrupoProduto { get; set; } = null!;
}
