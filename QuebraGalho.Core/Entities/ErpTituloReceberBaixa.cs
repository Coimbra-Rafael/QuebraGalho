using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpTituloReceberBaixa
{
    public string NrLicenca { get; set; } = null!;

    public string IdBaixaReceber { get; set; } = null!;

    public decimal IdTitulo { get; set; }

    public decimal IdEmpresa { get; set; }

    public DateTime? DtRecebimento { get; set; }

    public decimal VlRecebimento { get; set; }

    public decimal IdUsuario { get; set; }

    public decimal IdTipoRecebimento { get; set; }

    public string? DsObservacao { get; set; }

    public decimal IdBancoConta { get; set; }

    public string? NrLote { get; set; }

    public virtual ErpTipoRecebimento ErpTipoRecebimento { get; set; } = null!;

    public virtual ErpTituloReceber ErpTituloReceber { get; set; } = null!;

    public virtual ICollection<ErpTituloReceberBaixaMovimentoBanco> ErpTituloReceberBaixaMovimentoBancos { get; set; } = new List<ErpTituloReceberBaixaMovimentoBanco>();
}
