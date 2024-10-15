using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpCaixaMovimentoSangriaAporte
{
    public string NrLicenca { get; set; } = null!;

    public string IdMovimento { get; set; } = null!;

    public decimal IdEmpresa { get; set; }

    public string IdMovimentoCaixa { get; set; } = null!;

    public DateTime? DtMovimento { get; set; }

    public string DmSangriaAporte { get; set; } = null!;

    public decimal VlMovimento { get; set; }

    public decimal? IdUsuarioFiscal { get; set; }

    public string? DsObservacao { get; set; }

    public virtual ErpCaixaMovimento ErpCaixaMovimento { get; set; } = null!;
}
