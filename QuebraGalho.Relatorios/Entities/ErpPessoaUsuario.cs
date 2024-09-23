using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpPessoaUsuario
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdPessoa { get; set; }

    public decimal IdUsuario { get; set; }
}
