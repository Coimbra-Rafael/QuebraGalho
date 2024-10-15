using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpPromocao
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdEmpresa { get; set; }

    public decimal IdPromocao { get; set; }

    public string DsPromocao { get; set; } = null!;

    public DateTime? DtInicio { get; set; }

    public DateTime? DtTermino { get; set; }

    public decimal IdUsuario { get; set; }

    public string DmLiberado { get; set; } = null!;

    public decimal? IdTipoPromocao { get; set; }

    public virtual ErpEmpresa ErpEmpresa { get; set; } = null!;

    public virtual ICollection<ErpPromocaoProdutosCodigo> ErpPromocaoProdutosCodigos { get; set; } = new List<ErpPromocaoProdutosCodigo>();

    public virtual ErpPromocaoTipo? ErpPromocaoTipo { get; set; }
}
