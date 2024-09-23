using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpWebLog
{
    public string IdSession { get; set; } = null!;

    public DateTime DthrLog { get; set; }

    public string? DsUrl { get; set; }
}
