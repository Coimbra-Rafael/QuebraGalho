using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpPerfilTributarioIpi
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdPerfilTributario { get; set; }

    public decimal IdNaturezaOperacao { get; set; }

    public string? Cst { get; set; }

    public decimal? AliqIpi { get; set; }

    public string? CodigoEnquadramento { get; set; }

    public string? ClasseEnquadramento { get; set; }

    public string? CnpjProdutor { get; set; }

    public string? CodigoSelo { get; set; }

    public virtual ErpPerfilTributario ErpPerfilTributario { get; set; } = null!;
}
