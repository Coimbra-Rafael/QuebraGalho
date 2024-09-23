using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpModulo
{
    public decimal IdModulo { get; set; }

    public string DsModulo { get; set; } = null!;

    public virtual ICollection<ErpMenu> ErpMenus { get; set; } = new List<ErpMenu>();
}
