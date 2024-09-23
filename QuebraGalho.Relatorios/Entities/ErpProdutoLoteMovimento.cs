using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpProdutoLoteMovimento
{
    public string NrLicenca { get; set; } = null!;

    public string Identificador { get; set; } = null!;

    public string IdSerialLote { get; set; } = null!;

    public decimal Quantidade { get; set; }

    public string DmEntradaSaida { get; set; } = null!;

    public virtual ErpProdutoLote ErpProdutoLote { get; set; } = null!;
}
