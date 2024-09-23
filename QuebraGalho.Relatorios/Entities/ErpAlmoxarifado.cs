using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpAlmoxarifado
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdAlmoxarifado { get; set; }

    public string DsAlmoxarifado { get; set; } = null!;

    public virtual ICollection<ErpKardex> ErpKardices { get; set; } = new List<ErpKardex>();

    public virtual ICollection<ErpMovimentoEstoque> ErpMovimentoEstoques { get; set; } = new List<ErpMovimentoEstoque>();

    public virtual ICollection<ErpProducaoFicha> ErpProducaoFichas { get; set; } = new List<ErpProducaoFicha>();

    public virtual ErpLicenca NrLicencaNavigation { get; set; } = null!;
}
