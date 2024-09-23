using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpInventarioProdutosKardex
{
    public string NrLicenca { get; set; } = null!;

    public string IdInventario { get; set; } = null!;

    public string IdKardex { get; set; } = null!;
}
