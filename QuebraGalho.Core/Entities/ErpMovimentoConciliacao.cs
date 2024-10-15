using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpMovimentoConciliacao
{
    public string NrLicenca { get; set; } = null!;

    public DateOnly DtConciliacao { get; set; }

    public string IdComputador { get; set; } = null!;

    public decimal TotalVendas { get; set; }

    public decimal QuantidadeVendas { get; set; }

    public decimal TotalVendasCanceladas { get; set; }

    public decimal QuantidadeVendasCanceladas { get; set; }

    public DateTime DthrUltimaSincronizacao { get; set; }
}
