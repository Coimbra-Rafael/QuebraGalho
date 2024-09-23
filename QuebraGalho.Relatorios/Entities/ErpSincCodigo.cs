using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpSincCodigo
{
    public string GuidIdentificador { get; set; } = null!;

    public string NrLicenca { get; set; } = null!;

    public string IdComputador { get; set; } = null!;

    public string IdProdutosCodigos { get; set; } = null!;

    public DateTime DthrGeracao { get; set; }

    public string DmSituacao { get; set; } = null!;

    public virtual ErpComputador ErpComputador { get; set; } = null!;

    public virtual ErpProdutoServicoCodigo ErpProdutoServicoCodigo { get; set; } = null!;
}
