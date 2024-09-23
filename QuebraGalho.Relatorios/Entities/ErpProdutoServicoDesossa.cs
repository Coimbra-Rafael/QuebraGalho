using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpProdutoServicoDesossa
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdProdutoServico { get; set; }

    public decimal IdProdutoServicoPeca { get; set; }

    public decimal FatorPercentual { get; set; }

    public virtual ErpProdutoServico ErpProdutoServico { get; set; } = null!;

    public virtual ErpProdutoServico ErpProdutoServicoNavigation { get; set; } = null!;
}
