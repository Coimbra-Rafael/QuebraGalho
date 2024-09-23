using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpProdutoServicoEmpresaPreco
{
    public string NrLicenca { get; set; } = null!;

    public string IdProdutosCodigos { get; set; } = null!;

    public decimal IdEmpresa { get; set; }

    public decimal IdTabelaPreco { get; set; }

    public string? Identificador { get; set; }

    public virtual ErpProdutoServicoCodigo ErpProdutoServicoCodigo { get; set; } = null!;
}
