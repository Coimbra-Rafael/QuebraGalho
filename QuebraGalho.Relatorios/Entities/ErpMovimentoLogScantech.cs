using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpMovimentoLogScantech
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdMovimento { get; set; }

    public decimal IdEmpresa { get; set; }

    public DateTime DthrEnvio { get; set; }

    public string DsLog { get; set; } = null!;
}
