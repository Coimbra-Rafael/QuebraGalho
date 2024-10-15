using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpTituloGuidsProcessado
{
    public string NrLicenca { get; set; } = null!;

    public string GuidTitulo { get; set; } = null!;

    public string DmProcessado { get; set; } = null!;

    public string? DsProcessamento { get; set; }

    public DateTime DtLancamento { get; set; }

    public decimal IdUsuario { get; set; }
}
