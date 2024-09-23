using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpMovimentoCupomReferenciado
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdMovimento { get; set; }

    public decimal IdEmpresa { get; set; }

    public string NrChaveAcesso { get; set; } = null!;

    public virtual ErpMovimento ErpMovimento { get; set; } = null!;
}
