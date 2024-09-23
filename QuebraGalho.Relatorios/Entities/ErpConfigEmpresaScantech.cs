using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpConfigEmpresaScantech
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdEmpresa { get; set; }

    public string NrEmpresaScantech { get; set; } = null!;

    public string NrLocalScantech { get; set; } = null!;

    public decimal TempoBuscaScantech { get; set; }

    public string DmAtivo { get; set; } = null!;

    public DateTime DtUltimaExecucao { get; set; }

    public string? NmUsuarioWs { get; set; }

    public string? NmPasswordWs { get; set; }

    public virtual ErpEmpresa ErpEmpresa { get; set; } = null!;
}
