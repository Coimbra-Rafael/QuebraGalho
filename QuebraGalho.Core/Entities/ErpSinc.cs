using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpSinc
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdEmpresa { get; set; }

    public string IdSinc { get; set; } = null!;

    public string NmTabela { get; set; } = null!;

    public string? VlChave { get; set; }

    public string? IdComputador { get; set; }

    public string DmSinc { get; set; } = null!;

    public DateTime? DthrGeracao { get; set; }

    public decimal DmPrioridade { get; set; }

    public string? DsErroExecucao { get; set; }

    public virtual ErpEmpresa ErpEmpresa { get; set; } = null!;
}
