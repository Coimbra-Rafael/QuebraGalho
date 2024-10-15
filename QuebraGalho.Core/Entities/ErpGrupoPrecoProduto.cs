using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpGrupoPrecoProduto
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdGrupoPrecoProduto { get; set; }

    public string DsGrupoPrecoProduto { get; set; } = null!;

    public virtual ICollection<ErpProdutoServico> ErpProdutoServicos { get; set; } = new List<ErpProdutoServico>();
}
