using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpProdutoServicoDesossaPerdum
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdProdutoServico { get; set; }

    public decimal IdTipoMovimento { get; set; }

    public virtual ErpProdutoServico ErpProdutoServico { get; set; } = null!;
}
