using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpPromocaoPack
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdEmpresa { get; set; }

    public decimal IdPromocao { get; set; }

    public string? DsPromocao { get; set; }

    public string DsPromocaoTitulo { get; set; } = null!;

    public string? AutorPromocao { get; set; }

    public DateTime? DtInicio { get; set; }

    public DateTime? DtTermino { get; set; }

    public decimal? LimiteTicket { get; set; }

    public virtual ICollection<ErpPromocaoPacksDescontoVariado> ErpPromocaoPacksDescontoVariados { get; set; } = new List<ErpPromocaoPacksDescontoVariado>();

    public virtual ICollection<ErpPromocaoPacksLevaPaga> ErpPromocaoPacksLevaPagas { get; set; } = new List<ErpPromocaoPacksLevaPaga>();

    public virtual ICollection<ErpPromocaoPacksPrecoFixo> ErpPromocaoPacksPrecoFixos { get; set; } = new List<ErpPromocaoPacksPrecoFixo>();
}
