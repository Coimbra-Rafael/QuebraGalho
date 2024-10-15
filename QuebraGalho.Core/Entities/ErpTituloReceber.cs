using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpTituloReceber
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdTitulo { get; set; }

    public decimal IdEmpresa { get; set; }

    public decimal IdCarteira { get; set; }

    public DateTime? DtEmissao { get; set; }

    public DateOnly DtVencimento { get; set; }

    public DateOnly? DtRecebimento { get; set; }

    public decimal NrParcela { get; set; }

    public decimal QtdeParcelas { get; set; }

    public decimal IdPessoa { get; set; }

    public decimal IdUsuario { get; set; }

    public decimal? IdMovimento { get; set; }

    public decimal IdTipoReceita { get; set; }

    public decimal? IdPessoaVendedor { get; set; }

    public decimal NrDocumento { get; set; }

    public string DmStatus { get; set; } = null!;

    public string? DsObservacao { get; set; }

    public decimal VlTitulo { get; set; }

    public decimal VlSaldo { get; set; }

    public decimal VlDesconto { get; set; }

    public decimal VlJuros { get; set; }

    public decimal TxJuros { get; set; }

    public decimal VlCustoAdm { get; set; }

    public decimal VlTotalBaixa { get; set; }

    public decimal VlMulta { get; set; }

    public decimal VlComissao { get; set; }

    public decimal? PercDesconto { get; set; }

    public string? IdVenda { get; set; }

    public virtual ErpBancoCarteira ErpBancoCarteira { get; set; } = null!;

    public virtual ErpPessoa ErpPessoa { get; set; } = null!;

    public virtual ErpTipoReceitum ErpTipoReceitum { get; set; } = null!;

    public virtual ICollection<ErpTituloReceberBaixa> ErpTituloReceberBaixas { get; set; } = new List<ErpTituloReceberBaixa>();
}
