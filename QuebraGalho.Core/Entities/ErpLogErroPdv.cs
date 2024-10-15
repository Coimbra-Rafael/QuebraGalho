using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpLogErroPdv
{
    public byte[] Identificador { get; set; } = null!;

    public string NrLicenca { get; set; } = null!;

    public DateTime DthrLog { get; set; }

    public string MsgLog { get; set; } = null!;
}
