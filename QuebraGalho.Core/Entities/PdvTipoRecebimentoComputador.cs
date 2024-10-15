using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class PdvTipoRecebimentoComputador
{
    public string NrLicenca { get; set; } = null!;

    public string IdComputador { get; set; } = null!;

    public decimal IdRecebimento { get; set; }

    public virtual ErpComputador ErpComputador { get; set; } = null!;

    public virtual PdvTipoRecebimento PdvTipoRecebimento { get; set; } = null!;
}
