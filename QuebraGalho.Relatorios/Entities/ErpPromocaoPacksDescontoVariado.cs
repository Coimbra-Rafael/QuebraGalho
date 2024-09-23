using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpPromocaoPacksDescontoVariado
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdEmpresa { get; set; }

    public decimal IdPromocao { get; set; }

    public decimal NrItem { get; set; }

    public string IdProdutosCodigos { get; set; } = null!;

    public decimal Qtde { get; set; }

    public decimal PercDesconto { get; set; }

    public virtual ErpPromocaoPack ErpPromocaoPack { get; set; } = null!;
}
