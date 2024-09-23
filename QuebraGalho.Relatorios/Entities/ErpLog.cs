using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpLog
{
    public decimal IdLog { get; set; }

    public DateTime? DtAtualizacao { get; set; }

    public string? NmClasse { get; set; }

    public string NrLicenca { get; set; } = null!;

    public string IdSession { get; set; } = null!;

    public decimal? IdEmpresa { get; set; }
}
