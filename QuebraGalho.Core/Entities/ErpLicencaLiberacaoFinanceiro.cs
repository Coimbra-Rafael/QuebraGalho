using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpLicencaLiberacaoFinanceiro
{
    public string NrLicenca { get; set; } = null!;

    public DateOnly DtValidade { get; set; }

    public DateTime DthrLiberacao { get; set; }
}
