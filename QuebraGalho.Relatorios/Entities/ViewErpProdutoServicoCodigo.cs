using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ViewErpProdutoServicoCodigo
{
    public string NrLicenca { get; set; } = null!;

    public string IdProdutosCodigos { get; set; } = null!;

    public decimal IdProdutoServico { get; set; }

    public string DsProdutoServico { get; set; } = null!;

    public string IdUnidadeMedida { get; set; } = null!;

    public string DsProdutoServicoUnMedida { get; set; } = null!;
}
