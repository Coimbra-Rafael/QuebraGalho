using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpBancoContaSaldo
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdBancoConta { get; set; }

    public DateOnly DtSaldo { get; set; }

    public decimal VlSaldo { get; set; }

    public virtual ErpBancoContum ErpBancoContum { get; set; } = null!;
}
