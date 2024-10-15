using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ViewErpSubgrupoProduto
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdSubgrupo { get; set; }

    public decimal IdGrupo { get; set; }

    public string? DsSubgrupo { get; set; }
}
