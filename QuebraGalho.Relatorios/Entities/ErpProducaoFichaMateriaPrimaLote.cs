using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpProducaoFichaMateriaPrimaLote
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdEmpresa { get; set; }

    public decimal IdProducaoFicha { get; set; }

    public decimal NrItem { get; set; }

    public string Identificador { get; set; } = null!;

    public virtual ErpProducaoFichaMateriaPrima ErpProducaoFichaMateriaPrima { get; set; } = null!;
}
