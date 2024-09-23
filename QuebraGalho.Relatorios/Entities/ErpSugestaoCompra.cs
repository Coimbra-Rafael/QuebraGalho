using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpSugestaoCompra
{
    public string NrLicenca { get; set; } = null!;

    public DateTime DtCompra { get; set; }

    public decimal IdProdutoServico { get; set; }

    public decimal IdEmpresa { get; set; }

    public decimal QtdeSugestao { get; set; }

    public decimal QtdeComprar { get; set; }

    public decimal QtdeVendida30Dias { get; set; }

    public decimal QtdeVendida60Dias { get; set; }

    public decimal QtdeVendida90Dias { get; set; }

    public decimal VlUltimaCompra { get; set; }

    public decimal VlPrecoPedido { get; set; }

    public DateOnly? DtUltimaCompra { get; set; }

    public decimal QtdeEstoque { get; set; }

    public virtual ErpProdutoServico ErpProdutoServico { get; set; } = null!;
}
