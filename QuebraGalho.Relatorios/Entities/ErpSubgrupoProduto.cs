using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpSubgrupoProduto
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdSubgrupo { get; set; }

    public decimal IdGrupo { get; set; }

    public string DsSubgrupo { get; set; } = null!;

    public virtual ICollection<ErpCategoriaProduto> ErpCategoriaProdutos { get; set; } = new List<ErpCategoriaProduto>();

    public virtual ErpGrupoProduto ErpGrupoProduto { get; set; } = null!;

    public virtual ICollection<ErpProdutoServico> ErpProdutoServicos { get; set; } = new List<ErpProdutoServico>();
}
