using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpProducaoFichaKardex
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdEmpresa { get; set; }

    public decimal IdProducaoFicha { get; set; }

    public string IdKardex { get; set; } = null!;

    public virtual ErpProducaoFicha ErpProducaoFicha { get; set; } = null!;
}
