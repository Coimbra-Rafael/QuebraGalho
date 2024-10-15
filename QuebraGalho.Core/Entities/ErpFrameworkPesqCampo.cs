using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpFrameworkPesqCampo
{
    public string IdPesquisa { get; set; } = null!;

    public decimal NrItem { get; set; }

    public string? NmEntidade { get; set; }

    public string? NmAtributo { get; set; }

    public string? DsAtributo { get; set; }

    public string? DsMascara { get; set; }

    public string? DmTipoClasse { get; set; }

    public string? DmPk { get; set; }

    public string? DmVisivel { get; set; }

    public decimal? TamGrid { get; set; }

    public virtual ErpFrameworkPesq IdPesquisaNavigation { get; set; } = null!;
}
