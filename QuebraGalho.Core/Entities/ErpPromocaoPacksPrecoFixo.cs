using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpPromocaoPacksPrecoFixo
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdEmpresa { get; set; }

    public decimal IdPromocao { get; set; }

    public decimal NrItem { get; set; }

    public string IdProdutosCodigos { get; set; } = null!;

    public decimal Qtde { get; set; }

    public decimal ValorFixo { get; set; }

    public virtual ErpPromocaoPack ErpPromocaoPack { get; set; } = null!;
}
