using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpTituloPagar
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdTitulo { get; set; }

    public decimal IdEmpresa { get; set; }

    public DateTime DtEmissao { get; set; }

    public DateTime DtVencimento { get; set; }

    public DateTime? DtPagamento { get; set; }

    public decimal NrParcela { get; set; }

    public decimal QtdeParcelas { get; set; }

    public decimal IdPessoa { get; set; }

    public decimal IdUsuario { get; set; }

    public decimal IdTipoDespesa { get; set; }

    public string? NrDocumento { get; set; }

    public string DmStatus { get; set; } = null!;

    public string? DsObservacao { get; set; }

    public decimal VlDocumento { get; set; }

    public decimal VlSaldo { get; set; }

    public decimal? IdGem { get; set; }

    public virtual ErpEntradaGem? ErpEntradaGem { get; set; }

    public virtual ErpPessoa ErpPessoa { get; set; } = null!;

    public virtual ErpTipoDespesa ErpTipoDespesa { get; set; } = null!;

    public virtual ICollection<ErpTituloPagarBaixa> ErpTituloPagarBaixas { get; set; } = new List<ErpTituloPagarBaixa>();
}
