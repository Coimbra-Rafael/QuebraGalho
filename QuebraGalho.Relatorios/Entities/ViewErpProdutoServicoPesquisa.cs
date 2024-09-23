using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ViewErpProdutoServicoPesquisa
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdProdutoServico { get; set; }

    public string DsProdutoServicoCodigo { get; set; } = null!;
}
