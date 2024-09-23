using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpUsuario
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdUsuario { get; set; }

    public string NmUsuario { get; set; } = null!;

    public string NmCompleto { get; set; } = null!;

    public string SenhaUsuarioMd5 { get; set; } = null!;

    public string? DsEmail { get; set; }

    public string DmStatus { get; set; } = null!;

    public string NmLogin { get; set; } = null!;

    public string? HashAtivacao { get; set; }

    public string? DmFiscal { get; set; }

    public string? DmCaixa { get; set; }

    public string? DsSenhaFiscal { get; set; }

    public string? SenhaUsuario { get; set; }

    public string? SenhaFiscal { get; set; }

    public string? DmTipoUsuario { get; set; }

    public virtual ICollection<ErpInventario> ErpInventarios { get; set; } = new List<ErpInventario>();

    public virtual ICollection<ErpKardex> ErpKardices { get; set; } = new List<ErpKardex>();

    public virtual ICollection<ErpMovimentoEstoque> ErpMovimentoEstoques { get; set; } = new List<ErpMovimentoEstoque>();

    public virtual ICollection<ErpProducaoFicha> ErpProducaoFichaErpUsuarioNavigations { get; set; } = new List<ErpProducaoFicha>();

    public virtual ICollection<ErpProducaoFicha> ErpProducaoFichaErpUsuarios { get; set; } = new List<ErpProducaoFicha>();

    public virtual ICollection<ErpTabelaPrecoProduto> ErpTabelaPrecoProdutos { get; set; } = new List<ErpTabelaPrecoProduto>();

    public virtual ICollection<ErpUsuarioIp> ErpUsuarioIps { get; set; } = new List<ErpUsuarioIp>();

    public virtual ICollection<ErpUsuarioSession> ErpUsuarioSessions { get; set; } = new List<ErpUsuarioSession>();
}
