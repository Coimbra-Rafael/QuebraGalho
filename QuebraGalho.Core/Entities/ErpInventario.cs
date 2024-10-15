using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpInventario
{
    public string NrLicenca { get; set; } = null!;

    public string IdInventario { get; set; } = null!;

    public decimal IdEmpresa { get; set; }

    public decimal IdAlmoxarifado { get; set; }

    public DateOnly DtInventario { get; set; }

    public DateTime? DthrAtualizacao { get; set; }

    public decimal? IdUsuarioAtualizacao { get; set; }

    public decimal IdTipoMovimentoEntrada { get; set; }

    public decimal IdTipoMovimentoSaida { get; set; }

    public string DmAtualizado { get; set; } = null!;

    public string DmSaldo { get; set; } = null!;

    public string? DsInventario { get; set; }

    public decimal? NrDocumento { get; set; }

    public virtual ErpEmpresa ErpEmpresa { get; set; } = null!;

    public virtual ICollection<ErpInventarioProduto> ErpInventarioProdutos { get; set; } = new List<ErpInventarioProduto>();

    public virtual ErpTipoMovimentoEstoque ErpTipoMovimentoEstoque { get; set; } = null!;

    public virtual ErpTipoMovimentoEstoque ErpTipoMovimentoEstoqueNavigation { get; set; } = null!;

    public virtual ErpUsuario? ErpUsuario { get; set; }
}
