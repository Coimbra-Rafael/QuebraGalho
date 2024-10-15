using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpGrupoProduto
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdGrupo { get; set; }

    public string DsGrupo { get; set; } = null!;

    public virtual ICollection<ErpProdutoServico> ErpProdutoServicos { get; set; } = new List<ErpProdutoServico>();

    public virtual ICollection<ErpSubgrupoProduto> ErpSubgrupoProdutos { get; set; } = new List<ErpSubgrupoProduto>();

    public virtual ErpLicenca NrLicencaNavigation { get; set; } = null!;
}
