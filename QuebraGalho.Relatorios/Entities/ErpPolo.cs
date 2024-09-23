using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpPolo
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdPolo { get; set; }

    public string DsPolo { get; set; } = null!;

    public virtual ICollection<ErpSetor> ErpSetors { get; set; } = new List<ErpSetor>();
}
