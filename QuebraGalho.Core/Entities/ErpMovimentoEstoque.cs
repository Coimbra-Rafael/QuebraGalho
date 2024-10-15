using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpMovimentoEstoque
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdMovimento { get; set; }

    public decimal IdEmpresa { get; set; }

    public decimal IdTipoMovimento { get; set; }

    public decimal IdAlmoxarifado { get; set; }

    public string NrDocumento { get; set; } = null!;

    public DateOnly DtMovimento { get; set; }

    public DateOnly? DtAtualizacao { get; set; }

    public decimal IdUsuario { get; set; }

    public virtual ErpAlmoxarifado ErpAlmoxarifado { get; set; } = null!;

    public virtual ErpEmpresa ErpEmpresa { get; set; } = null!;

    public virtual ICollection<ErpMovimentoEstoqueProduto> ErpMovimentoEstoqueProdutos { get; set; } = new List<ErpMovimentoEstoqueProduto>();

    public virtual ErpTipoMovimentoEstoque ErpTipoMovimentoEstoque { get; set; } = null!;

    public virtual ErpUsuario ErpUsuario { get; set; } = null!;
}
