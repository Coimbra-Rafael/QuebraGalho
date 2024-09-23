using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpParametrosSubgrupo
{
    public decimal IdSubgrupo { get; set; }

    public string DsSubgrupo { get; set; } = null!;

    public decimal IdGrupo { get; set; }

    public virtual ICollection<ErpParametrosDefault> ErpParametrosDefaults { get; set; } = new List<ErpParametrosDefault>();
}
