using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpParametrosGrupo
{
    public decimal IdGrupo { get; set; }

    public string DsGrupo { get; set; } = null!;

    public virtual ICollection<ErpParametrosDefault> ErpParametrosDefaults { get; set; } = new List<ErpParametrosDefault>();
}
