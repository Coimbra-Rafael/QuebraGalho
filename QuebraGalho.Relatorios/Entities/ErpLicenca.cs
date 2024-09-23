using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpLicenca
{
    public string NrLicenca { get; set; } = null!;

    public string NmFantasia { get; set; } = null!;

    public string NrVersao { get; set; } = null!;

    public string? DmSituacao { get; set; }

    public string? DmTipoSistema { get; set; }

    public string TipoArmazenamento { get; set; } = null!;

    public virtual ICollection<ErpAlmoxarifado> ErpAlmoxarifados { get; set; } = new List<ErpAlmoxarifado>();

    public virtual ICollection<ErpCmd> ErpCmds { get; set; } = new List<ErpCmd>();

    public virtual ICollection<ErpEmpresa> ErpEmpresas { get; set; } = new List<ErpEmpresa>();

    public virtual ICollection<ErpEntradaGem> ErpEntradaGems { get; set; } = new List<ErpEntradaGem>();

    public virtual ICollection<ErpGrupoDespesa> ErpGrupoDespesas { get; set; } = new List<ErpGrupoDespesa>();

    public virtual ICollection<ErpGrupoProduto> ErpGrupoProdutos { get; set; } = new List<ErpGrupoProduto>();

    public virtual ICollection<ErpGrupoReceitum> ErpGrupoReceita { get; set; } = new List<ErpGrupoReceitum>();

    public virtual ICollection<ErpLicencaSession> ErpLicencaSessions { get; set; } = new List<ErpLicencaSession>();

    public virtual ICollection<ErpNaturezaOperacao> ErpNaturezaOperacaos { get; set; } = new List<ErpNaturezaOperacao>();

    public virtual ICollection<ErpPessoa> ErpPessoas { get; set; } = new List<ErpPessoa>();

    public virtual ICollection<ErpProdutoServico> ErpProdutoServicos { get; set; } = new List<ErpProdutoServico>();

    public virtual ICollection<ErpTipoMovimentoEstoque> ErpTipoMovimentoEstoques { get; set; } = new List<ErpTipoMovimentoEstoque>();

    public virtual ICollection<ErpUnidadeMedidum> ErpUnidadeMedida { get; set; } = new List<ErpUnidadeMedidum>();

    public virtual ICollection<PdvTipoRecebimento> PdvTipoRecebimentos { get; set; } = new List<PdvTipoRecebimento>();
}
