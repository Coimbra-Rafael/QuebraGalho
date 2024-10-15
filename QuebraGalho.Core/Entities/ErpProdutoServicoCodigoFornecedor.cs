using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpProdutoServicoCodigoFornecedor
{
    public string NrLicenca { get; set; } = null!;

    public string NrCnpjEmitente { get; set; } = null!;

    public string CdProdutoEmitente { get; set; } = null!;

    public string IdProdutosCodigos { get; set; } = null!;
}
