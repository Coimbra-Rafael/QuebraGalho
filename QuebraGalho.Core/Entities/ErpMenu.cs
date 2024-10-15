using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpMenu
{
    public decimal IdModulo { get; set; }

    public decimal IdNivel { get; set; }

    public decimal NrItem { get; set; }

    public string DsMenu { get; set; } = null!;

    public string? Url { get; set; }

    public string? NmIcone { get; set; }

    public decimal? IdNivelChamar { get; set; }

    public string? DsMenuAnterior { get; set; }

    public virtual ErpModulo IdModuloNavigation { get; set; } = null!;
}
