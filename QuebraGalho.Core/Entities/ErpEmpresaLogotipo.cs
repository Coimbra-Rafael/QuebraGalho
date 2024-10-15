using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpEmpresaLogotipo
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdEmpresa { get; set; }

    public string? NmArquivo { get; set; }

    public byte[]? ConteudoArquivo { get; set; }

    public virtual ErpEmpresa ErpEmpresa { get; set; } = null!;
}
