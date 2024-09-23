using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpEntradaGemItemLote
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdGem { get; set; }

    public decimal IdEmpresa { get; set; }

    public decimal NrItem { get; set; }

    public string IdSerialLote { get; set; } = null!;

    public virtual ErpEntradaGemItem ErpEntradaGemItem { get; set; } = null!;

    public virtual ErpProdutoLote ErpProdutoLote { get; set; } = null!;
}
