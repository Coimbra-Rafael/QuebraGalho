using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpNaturezaOperacao
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdNaturezaOperacao { get; set; }

    public string DsNaturezaOperacao { get; set; } = null!;

    public string DmEntradaSaida { get; set; } = null!;

    public string DmFinalidadeEmissao { get; set; } = null!;

    public string DmFinanceiro { get; set; } = null!;

    public string DmEstoque { get; set; } = null!;

    public decimal? IdTipoMovimento { get; set; }

    public virtual ICollection<ErpEntradaGem> ErpEntradaGems { get; set; } = new List<ErpEntradaGem>();

    public virtual ICollection<ErpMovimento> ErpMovimentos { get; set; } = new List<ErpMovimento>();

    public virtual ICollection<ErpPedidoVendum> ErpPedidoVenda { get; set; } = new List<ErpPedidoVendum>();

    public virtual ICollection<ErpPerfilTributarioIcm> ErpPerfilTributarioIcms { get; set; } = new List<ErpPerfilTributarioIcm>();

    public virtual ICollection<ErpPerfilTributarioIcmsSimple> ErpPerfilTributarioIcmsSimples { get; set; } = new List<ErpPerfilTributarioIcmsSimple>();

    public virtual ErpTipoMovimentoEstoque? ErpTipoMovimentoEstoque { get; set; }

    public virtual ErpLicenca NrLicencaNavigation { get; set; } = null!;
}
