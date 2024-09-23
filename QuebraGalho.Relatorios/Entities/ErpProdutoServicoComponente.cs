using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpProdutoServicoComponente
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdProdutoServico { get; set; }

    public decimal IdProdutoServicoComponente { get; set; }

    public decimal Quantidade { get; set; }

    public virtual ErpProdutoServico ErpProdutoServico { get; set; } = null!;

    public virtual ErpProdutoServico ErpProdutoServicoNavigation { get; set; } = null!;
}
