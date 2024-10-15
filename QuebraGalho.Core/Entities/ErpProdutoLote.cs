using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpProdutoLote
{
    public string NrLicenca { get; set; } = null!;

    public string IdSerialLote { get; set; } = null!;

    public decimal IdProdutoServico { get; set; }

    public string? NrLote { get; set; }

    public DateTime DtFabricacao { get; set; }

    public DateTime DtVencimento { get; set; }

    public decimal Quantidade { get; set; }

    public virtual ICollection<ErpEntradaGemItemLote> ErpEntradaGemItemLotes { get; set; } = new List<ErpEntradaGemItemLote>();

    public virtual ICollection<ErpProdutoLoteMovimento> ErpProdutoLoteMovimentos { get; set; } = new List<ErpProdutoLoteMovimento>();
}
