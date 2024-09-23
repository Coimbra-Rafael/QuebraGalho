using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class YandehProcessamento
{
    public string Identificador { get; set; } = null!;

    public DateTime DthrEnvio { get; set; }

    public string DsCmd { get; set; } = null!;

    public string VlCmd { get; set; } = null!;

    public string? CdRetorno { get; set; }

    public string DsRetorno { get; set; } = null!;

    public string NrLicenca { get; set; } = null!;
}
