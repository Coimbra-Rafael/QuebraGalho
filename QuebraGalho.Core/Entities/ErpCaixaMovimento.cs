using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpCaixaMovimento
{
    public string IdMovimento { get; set; } = null!;

    public string NrLicenca { get; set; } = null!;

    public decimal IdEmpresa { get; set; }

    public decimal IdUsuario { get; set; }

    public DateTime? DtAbertura { get; set; }

    public decimal VlAbertura { get; set; }

    public DateTime? DtEncerramento { get; set; }

    public decimal? VlFechamento { get; set; }

    public string? DsObservacao { get; set; }

    public string? IdComputador { get; set; }

    public virtual ICollection<ErpCaixaMovimentoSangriaAporte> ErpCaixaMovimentoSangriaAportes { get; set; } = new List<ErpCaixaMovimentoSangriaAporte>();

    public virtual ICollection<ErpCaixaMovimentoVenda> ErpCaixaMovimentoVenda { get; set; } = new List<ErpCaixaMovimentoVenda>();
}
