using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpEntradaTipoRateio
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdTipo { get; set; }

    public string DsTipo { get; set; } = null!;

    public virtual ICollection<ErpEntradaGemRateio> ErpEntradaGemRateios { get; set; } = new List<ErpEntradaGemRateio>();
}
