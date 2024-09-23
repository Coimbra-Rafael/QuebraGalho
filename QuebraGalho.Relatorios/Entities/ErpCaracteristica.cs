using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpCaracteristica
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdCaracteristica { get; set; }

    public string DsCaracteristica { get; set; } = null!;

    public string? CdCaracteristicaExterno { get; set; }

    public string DmEnviaEcommerce { get; set; } = null!;

    public virtual ICollection<ErpProdutoServicoCaracteristica> ErpProdutoServicoCaracteristicas { get; set; } = new List<ErpProdutoServicoCaracteristica>();
}
