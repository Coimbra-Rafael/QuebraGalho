using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpPromocaoTipo
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdTipoPromocao { get; set; }

    public string DsTipoPromocao { get; set; } = null!;

    public virtual ICollection<ErpPromocao> ErpPromocaos { get; set; } = new List<ErpPromocao>();
}
