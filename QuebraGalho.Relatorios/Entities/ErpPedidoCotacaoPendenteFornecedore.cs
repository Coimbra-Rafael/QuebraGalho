using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpPedidoCotacaoPendenteFornecedore
{
    public string NrLicenca { get; set; } = null!;

    public string Identificador { get; set; } = null!;

    public decimal IdPessoa { get; set; }

    public string DsEmail { get; set; } = null!;
}
