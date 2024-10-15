using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpMovimentoItemLote
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdEmpresa { get; set; }

    public decimal IdMovimento { get; set; }

    public decimal NrItem { get; set; }

    public string IdSerialLote { get; set; } = null!;

    public decimal Quantidade { get; set; }

    public virtual ErpMovimentoItem ErpMovimentoItem { get; set; } = null!;
}
