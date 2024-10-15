using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ViewErpCategoriaProduto
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdCategoria { get; set; }

    public decimal IdSubgrupo { get; set; }

    public string DsCategoria { get; set; } = null!;
}
