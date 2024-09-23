using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpTipoReceitum
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdTipoReceita { get; set; }

    public decimal IdSubgrupoReceita { get; set; }

    public string DsTipoReceita { get; set; } = null!;

    public virtual ErpSubgrupoReceitum ErpSubgrupoReceitum { get; set; } = null!;

    public virtual ICollection<ErpTituloReceber> ErpTituloRecebers { get; set; } = new List<ErpTituloReceber>();
}
