using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpParametrosDefault
{
    public string NmParametro { get; set; } = null!;

    public string GrupoParametro { get; set; } = null!;

    public string? VlParametro { get; set; }

    public string DmTipoParametro { get; set; } = null!;

    public string DsParametro { get; set; } = null!;

    public string? ParametroNovo { get; set; }

    public decimal? IdGrupo { get; set; }

    public decimal? IdSubgrupo { get; set; }

    public decimal? IdCategoria { get; set; }

    public virtual ICollection<ErpParametrosLicenca> ErpParametrosLicencas { get; set; } = new List<ErpParametrosLicenca>();

    public virtual ErpParametrosCategorium? IdCategoriaNavigation { get; set; }

    public virtual ErpParametrosGrupo? IdGrupoNavigation { get; set; }

    public virtual ErpParametrosSubgrupo? IdSubgrupoNavigation { get; set; }
}
