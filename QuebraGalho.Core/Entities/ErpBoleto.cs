using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpBoleto
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdEmpresa { get; set; }

    public string GuidBoleto { get; set; } = null!;

    public DateOnly DtVencimento { get; set; }

    public string NmCliente { get; set; } = null!;

    public string NmBoleto { get; set; } = null!;

    public string? DmSituacao { get; set; }

    public decimal? VlBoleto { get; set; }

    public virtual ErpEmpresa ErpEmpresa { get; set; } = null!;
}
