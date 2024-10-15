using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpGrupoReceitum
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdGrupoReceita { get; set; }

    public string DsGrupoReceita { get; set; } = null!;

    public virtual ICollection<ErpSubgrupoReceitum> ErpSubgrupoReceita { get; set; } = new List<ErpSubgrupoReceitum>();

    public virtual ErpLicenca NrLicencaNavigation { get; set; } = null!;
}
