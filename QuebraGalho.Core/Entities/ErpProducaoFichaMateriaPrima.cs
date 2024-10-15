using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpProducaoFichaMateriaPrima
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdEmpresa { get; set; }

    public decimal IdProducaoFicha { get; set; }

    public decimal NrItem { get; set; }

    public decimal IdProdutoServico { get; set; }

    public decimal Quantidade { get; set; }

    public string? DsObservacao { get; set; }

    public virtual ErpProducaoFicha ErpProducaoFicha { get; set; } = null!;

    public virtual ErpProducaoFichaMateriaPrimaKardex? ErpProducaoFichaMateriaPrimaKardex { get; set; }

    public virtual ICollection<ErpProducaoFichaMateriaPrimaLote> ErpProducaoFichaMateriaPrimaLotes { get; set; } = new List<ErpProducaoFichaMateriaPrimaLote>();
}
