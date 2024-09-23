using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpSincEcommerce
{
    public string NrLicenca { get; set; } = null!;

    public string IdSinc { get; set; } = null!;

    public decimal IdEmpresa { get; set; }

    public string DsSinc { get; set; } = null!;

    public string VlSinc { get; set; } = null!;

    public string DmStatus { get; set; } = null!;

    public DateOnly DthrGeracao { get; set; }

    public decimal DmPrioridade { get; set; }
}
