using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class PdvGrupoTipoRecebimento
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdGrupo { get; set; }

    public string DsGrupo { get; set; } = null!;
}
