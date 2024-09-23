using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpTipoSangriaAporte
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdTipoSangriaAporte { get; set; }

    public string DsTipoSangriaAporte { get; set; } = null!;

    public string DmSangriaAporte { get; set; } = null!;
}
