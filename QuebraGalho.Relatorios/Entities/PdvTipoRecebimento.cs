using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class PdvTipoRecebimento
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdRecebimento { get; set; }

    public string DsRecebimento { get; set; } = null!;

    public string? Observacao { get; set; }

    public string? DmTeclaAtalho { get; set; }

    public string? DmTef { get; set; }

    public string? DmOperacaotef { get; set; }

    public string? DmParcelamento { get; set; }

    public decimal? IdGrupo { get; set; }

    public string? DmPreencheValor { get; set; }

    public decimal? DmOrdemTotal { get; set; }

    public string? DmTipoRecebimento { get; set; }

    public virtual ICollection<ErpPromocaoProdutosCodigo> ErpPromocaoProdutosCodigos { get; set; } = new List<ErpPromocaoProdutosCodigo>();

    public virtual ErpLicenca NrLicencaNavigation { get; set; } = null!;

    public virtual ICollection<PdvTipoRecebimentoComputador> PdvTipoRecebimentoComputadors { get; set; } = new List<PdvTipoRecebimentoComputador>();
}
