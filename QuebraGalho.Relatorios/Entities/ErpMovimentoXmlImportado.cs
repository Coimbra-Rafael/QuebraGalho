using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpMovimentoXmlImportado
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdMovimento { get; set; }

    public decimal IdEmpresa { get; set; }

    public string XmlEnviado { get; set; } = null!;

    public string? XmlEnviado2 { get; set; }

    public virtual ErpMovimento ErpMovimento { get; set; } = null!;
}
