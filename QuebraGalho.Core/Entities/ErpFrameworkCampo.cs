using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpFrameworkCampo
{
    public string NmClasse { get; set; } = null!;

    public decimal NrItem { get; set; }

    public string? NmAtributo { get; set; }

    public string? NmTabela { get; set; }

    public string? DsAtributo { get; set; }

    public string? DsMascara { get; set; }

    public string? NmTipoClasse { get; set; }

    public string? DmPk { get; set; }

    public string? DmPkGerada { get; set; }

    public decimal? TamGrid { get; set; }

    public string? DmVisivel { get; set; }

    public string? DmNull { get; set; }

    public string? TamPermitido { get; set; }

    public string? NmClasseValidacao { get; set; }

    public virtual ErpFrameworkTabela NmClasseNavigation { get; set; } = null!;
}
