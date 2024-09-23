using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpDispositivosMovei
{
    public string NrLicenca { get; set; } = null!;

    public string IdImei { get; set; } = null!;

    public DateTime DthrCadastro { get; set; }

    public string DsDispositivo { get; set; } = null!;

    public string DmAtivo { get; set; } = null!;
}
