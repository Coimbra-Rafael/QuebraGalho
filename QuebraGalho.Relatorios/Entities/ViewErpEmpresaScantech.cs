using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ViewErpEmpresaScantech
{
    public string NrLicenca { get; set; } = null!;

    public string NmFantasia { get; set; } = null!;

    public string? NrCnpj { get; set; }

    public string NrEmpresaScantech { get; set; } = null!;
}
