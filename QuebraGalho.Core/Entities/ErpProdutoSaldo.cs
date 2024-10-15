using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpProdutoSaldo
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdProdutoServico { get; set; }

    public DateTime DtSaldo { get; set; }

    public decimal IdEmpresa { get; set; }

    public decimal IdAlmoxarifado { get; set; }

    public decimal QtdAnterior { get; set; }

    public decimal QtdEntrada { get; set; }

    public decimal QtdSaida { get; set; }

    public decimal? QtdSaldoAtual { get; set; }

    public virtual ErpEmpresa ErpEmpresa { get; set; } = null!;

    public virtual ErpProdutoServico ErpProdutoServico { get; set; } = null!;
}
