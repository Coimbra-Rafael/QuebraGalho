using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpPerfilTributarioPi
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdPerfilTributario { get; set; }

    public decimal IdNaturezaOperacao { get; set; }

    public string? Cst { get; set; }

    public decimal? AliqPis { get; set; }

    public virtual ErpPerfilTributario ErpPerfilTributario { get; set; } = null!;
}
