using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpInventarioContagemRapidum
{
    public string NrLicenca { get; set; } = null!;

    public string IdContagem { get; set; } = null!;

    public decimal IdTipoMovimentoEntrada { get; set; }

    public decimal IdTipoMovimentoSaida { get; set; }

    public DateTime DthrContagem { get; set; }

    public decimal IdProdutoServico { get; set; }

    public decimal QtdeContagem { get; set; }

    public decimal VlCustoProduto { get; set; }

    public decimal IdUsuario { get; set; }

    public string IdKardex { get; set; } = null!;

    public decimal IdAlmoxarifado { get; set; }

    public decimal IdEmpresa { get; set; }
}
