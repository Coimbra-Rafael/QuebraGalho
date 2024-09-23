using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class CartoesBandeira
{
    public string IdBandeira { get; set; } = null!;

    public string DsBandeira { get; set; } = null!;

    public virtual ICollection<PdvCartoesBandeira> PdvCartoesBandeiras { get; set; } = new List<PdvCartoesBandeira>();
}
