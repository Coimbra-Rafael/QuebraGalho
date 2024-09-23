using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpProdutoValorMedio
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdProdutoServico { get; set; }

    public DateTime DtValorMedio { get; set; }

    public decimal IdEmpresa { get; set; }

    public decimal? ValorMedio { get; set; }

    public virtual ErpEmpresa ErpEmpresa { get; set; } = null!;

    public virtual ErpProdutoServico ErpProdutoServico { get; set; } = null!;
}
