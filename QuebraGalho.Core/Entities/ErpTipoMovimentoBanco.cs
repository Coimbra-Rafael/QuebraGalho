using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpTipoMovimentoBanco
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdTipoMovimento { get; set; }

    public string DsTipoMovimento { get; set; } = null!;

    public string DmEntradaSaida { get; set; } = null!;

    public virtual ICollection<ErpTipoPagamento> ErpTipoPagamentos { get; set; } = new List<ErpTipoPagamento>();
}
