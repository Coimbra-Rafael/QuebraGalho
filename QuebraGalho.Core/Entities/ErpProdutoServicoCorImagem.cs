using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpProdutoServicoCorImagem
{
    public string NrLicenca { get; set; } = null!;

    public string NrReferencia { get; set; } = null!;

    public decimal NrItem { get; set; }

    public decimal IdCor { get; set; }

    public string IdImagem { get; set; } = null!;

    public string? CdImagemExterno { get; set; }

    public virtual ErpImagem IdImagemNavigation { get; set; } = null!;
}
