using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpProdutoServicoFornecedoresCotacao
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdProdutoServico { get; set; }

    public decimal IdPessoa { get; set; }

    public virtual ErpPessoa ErpPessoa { get; set; } = null!;

    public virtual ErpProdutoServico ErpProdutoServico { get; set; } = null!;
}
