using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpKardex
{
    public string NrLicenca { get; set; } = null!;

    public string IdKardex { get; set; } = null!;

    public DateTime DtMovimento { get; set; }

    public decimal IdTipoMovimento { get; set; }

    public decimal IdAlmoxarifado { get; set; }

    public decimal Quantidade { get; set; }

    public decimal VlMovimento { get; set; }

    public decimal VlMedio { get; set; }

    public string NrDocumento { get; set; } = null!;

    public decimal IdUsuario { get; set; }

    public DateTime DtAtualizacao { get; set; }

    public decimal IdEmpresa { get; set; }

    public decimal IdProdutoServico { get; set; }

    public virtual ErpAlmoxarifado ErpAlmoxarifado { get; set; } = null!;

    public virtual ErpEmpresa ErpEmpresa { get; set; } = null!;

    public virtual ICollection<ErpEntradaGemItemKardex> ErpEntradaGemItemKardices { get; set; } = new List<ErpEntradaGemItemKardex>();

    public virtual ICollection<ErpKardexMovimentoEstoqueProduto> ErpKardexMovimentoEstoqueProdutos { get; set; } = new List<ErpKardexMovimentoEstoqueProduto>();

    public virtual ICollection<ErpMovimentoItemKardexCancelamento> ErpMovimentoItemKardexCancelamentos { get; set; } = new List<ErpMovimentoItemKardexCancelamento>();

    public virtual ICollection<ErpMovimentoItemKardex> ErpMovimentoItemKardices { get; set; } = new List<ErpMovimentoItemKardex>();

    public virtual ErpProdutoServico ErpProdutoServico { get; set; } = null!;

    public virtual ErpTipoMovimentoEstoque ErpTipoMovimentoEstoque { get; set; } = null!;

    public virtual ErpUsuario ErpUsuario { get; set; } = null!;
}
