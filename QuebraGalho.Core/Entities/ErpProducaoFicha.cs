using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpProducaoFicha
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdEmpresa { get; set; }

    public decimal IdProducaoFicha { get; set; }

    public DateTime DtInicioProducao { get; set; }

    public DateTime? DtTerminoProducao { get; set; }

    public decimal IdProdutoServico { get; set; }

    public decimal QuantidadeAProduzir { get; set; }

    public decimal QuantidadeProduzida { get; set; }

    public decimal IdAlmoxarifado { get; set; }

    public decimal IdUsuario { get; set; }

    public decimal? IdUsuarioFinalizou { get; set; }

    public string? DsObservacao { get; set; }

    public string DmStatus { get; set; } = null!;

    public virtual ErpAlmoxarifado ErpAlmoxarifado { get; set; } = null!;

    public virtual ErpProducaoFichaKardex? ErpProducaoFichaKardex { get; set; }

    public virtual ICollection<ErpProducaoFichaLote> ErpProducaoFichaLotes { get; set; } = new List<ErpProducaoFichaLote>();

    public virtual ICollection<ErpProducaoFichaMateriaPrima> ErpProducaoFichaMateriaPrimas { get; set; } = new List<ErpProducaoFichaMateriaPrima>();

    public virtual ErpProdutoServico ErpProdutoServico { get; set; } = null!;

    public virtual ErpUsuario ErpUsuario { get; set; } = null!;

    public virtual ErpUsuario? ErpUsuarioNavigation { get; set; }
}
