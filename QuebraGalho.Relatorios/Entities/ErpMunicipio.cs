using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpMunicipio
{
    public decimal IdMunicipio { get; set; }

    public string DsMunicipio { get; set; } = null!;

    public string IdUf { get; set; } = null!;

    public virtual ICollection<ErpEmpresa> ErpEmpresas { get; set; } = new List<ErpEmpresa>();

    public virtual ErpUf IdUfNavigation { get; set; } = null!;
}
