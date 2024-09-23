using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpMovimentoItemKardexCancelamento
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdMovimento { get; set; }

    public decimal IdEmpresa { get; set; }

    public decimal NrItem { get; set; }

    public string IdKardex { get; set; } = null!;

    public virtual ErpKardex ErpKardex { get; set; } = null!;
}
