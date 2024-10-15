using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpProducaoFichaLote
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdEmpresa { get; set; }

    public decimal IdProducaoFicha { get; set; }

    public string IdSerialLote { get; set; } = null!;

    public virtual ErpProducaoFicha ErpProducaoFicha { get; set; } = null!;
}
