using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpPai
{
    public decimal IdPais { get; set; }

    public string DsPais { get; set; } = null!;

    public virtual ICollection<ErpEmpresa> ErpEmpresas { get; set; } = new List<ErpEmpresa>();
}
