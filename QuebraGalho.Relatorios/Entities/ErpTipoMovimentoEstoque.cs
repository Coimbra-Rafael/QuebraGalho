using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpTipoMovimentoEstoque
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdTipoMovimento { get; set; }

    public string DsSigla { get; set; } = null!;

    public string DsTipoMovimento { get; set; } = null!;

    public string DmEntradaSaida { get; set; } = null!;

    public string? DmCalculoCustoMedio { get; set; }

    public virtual ICollection<ErpInventario> ErpInventarioErpTipoMovimentoEstoqueNavigations { get; set; } = new List<ErpInventario>();

    public virtual ICollection<ErpInventario> ErpInventarioErpTipoMovimentoEstoques { get; set; } = new List<ErpInventario>();

    public virtual ICollection<ErpKardex> ErpKardices { get; set; } = new List<ErpKardex>();

    public virtual ICollection<ErpMovimentoEstoque> ErpMovimentoEstoques { get; set; } = new List<ErpMovimentoEstoque>();

    public virtual ICollection<ErpNaturezaOperacao> ErpNaturezaOperacaos { get; set; } = new List<ErpNaturezaOperacao>();

    public virtual ErpLicenca NrLicencaNavigation { get; set; } = null!;
}
