using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpEtiquetaImpressao
{
    public string NrLicenca { get; set; } = null!;

    public string IdImpressao { get; set; } = null!;

    public decimal? IdProdutoServico { get; set; }

    public string? IdProdutosCodigos { get; set; }

    public string? DsProdutoServico { get; set; }

    public string? IdUnidade { get; set; }

    public decimal? VlProduto { get; set; }

    public decimal QtdeImpressao { get; set; }

    public decimal IdEtiqueta { get; set; }

    public string DmSinc { get; set; } = null!;

    public decimal? IdGem { get; set; }
}
