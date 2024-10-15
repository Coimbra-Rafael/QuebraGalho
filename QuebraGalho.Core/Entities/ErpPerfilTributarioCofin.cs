using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpPerfilTributarioCofin
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdPerfilTributario { get; set; }

    public decimal IdNaturezaOperacao { get; set; }

    public string? Cst { get; set; }

    public decimal? AliqCofins { get; set; }

    public virtual ErpPerfilTributario ErpPerfilTributario { get; set; } = null!;
}
