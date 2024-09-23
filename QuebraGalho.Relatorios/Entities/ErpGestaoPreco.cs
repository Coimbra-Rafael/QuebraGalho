using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpGestaoPreco
{
    public string NrLicenca { get; set; } = null!;

    public string IdGestaoPreco { get; set; } = null!;

    public DateTime? DtRecebimento { get; set; }

    public decimal IdProdutoServico { get; set; }

    public decimal IdTabelaPreco { get; set; }

    public decimal IdEmpresa { get; set; }

    public string DmStatus { get; set; } = null!;

    public decimal VlPreco { get; set; }

    public decimal? IdGem { get; set; }

    public DateTime? DtAtualizacao { get; set; }

    public decimal? VlCusto { get; set; }

    public decimal? PercMargem { get; set; }

    public string? DmGerouEtiqueta { get; set; }

    public virtual ErpProdutoServico ErpProdutoServico { get; set; } = null!;

    public virtual ErpTabelaPreco ErpTabelaPreco { get; set; } = null!;
}
