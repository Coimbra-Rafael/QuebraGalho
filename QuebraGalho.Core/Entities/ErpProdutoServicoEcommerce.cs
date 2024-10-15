using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpProdutoServicoEcommerce
{
    public string NrLicenca { get; set; } = null!;

    public string NrReferencia { get; set; } = null!;

    public decimal IdPessoaMarca { get; set; }

    public string? DescricaoResumida { get; set; }

    public string? DescricaoCompleta { get; set; }

    public string? DescricaoMetaKeywords { get; set; }

    public string? DescricaoTags { get; set; }

    public string? DsProdutoLoja { get; set; }
}
