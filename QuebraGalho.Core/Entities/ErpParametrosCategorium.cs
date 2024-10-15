using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpParametrosCategorium
{
    public decimal IdCategoria { get; set; }

    public string DsCategoria { get; set; } = null!;

    public decimal IdSubgrupo { get; set; }

    public virtual ICollection<ErpParametrosDefault> ErpParametrosDefaults { get; set; } = new List<ErpParametrosDefault>();
}
