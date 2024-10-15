using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpPermissao
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdEmpresa { get; set; }

    public decimal IdUsuario { get; set; }

    public string NmObjeto { get; set; } = null!;

    public string DmTipoPermissao { get; set; } = null!;

    public virtual ErpEmpresa ErpEmpresa { get; set; } = null!;
}
