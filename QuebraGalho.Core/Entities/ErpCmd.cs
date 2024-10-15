using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpCmd
{
    public decimal IdCmd { get; set; }

    public string DsCmd { get; set; } = null!;

    public string? VlCmd { get; set; }

    public decimal IdEmpresa { get; set; }

    public string DmStatus { get; set; } = null!;

    public string NrLicenca { get; set; } = null!;

    public string? NmDatacenter { get; set; }

    public DateTime DthrAtual { get; set; }

    public decimal Prioridade { get; set; }

    public virtual ErpEmpresa ErpEmpresa { get; set; } = null!;

    public virtual ErpLicenca NrLicencaNavigation { get; set; } = null!;
}
