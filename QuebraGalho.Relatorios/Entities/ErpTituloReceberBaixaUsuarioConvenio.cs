using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpTituloReceberBaixaUsuarioConvenio
{
    public string NrLicenca { get; set; } = null!;

    public string IdBaixaReceber { get; set; } = null!;

    public decimal IdUsuario { get; set; }

    public string IdComputador { get; set; } = null!;
}
