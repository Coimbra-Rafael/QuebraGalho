using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpSubgrupoReceitum
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdSubgrupoReceita { get; set; }

    public decimal IdGrupoReceita { get; set; }

    public string DsSubgrupoReceita { get; set; } = null!;

    public virtual ErpGrupoReceitum ErpGrupoReceitum { get; set; } = null!;

    public virtual ICollection<ErpTipoReceitum> ErpTipoReceita { get; set; } = new List<ErpTipoReceitum>();
}
