using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpPromocaoPacksLevaPaga
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdEmpresa { get; set; }

    public decimal IdPromocao { get; set; }

    public string IdProdutosCodigos { get; set; } = null!;

    public decimal QtdeLeva { get; set; }

    public decimal QtdePaga { get; set; }

    public virtual ErpPromocaoPack ErpPromocaoPack { get; set; } = null!;
}
