using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpSetor
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdSetor { get; set; }

    public string DsSetor { get; set; } = null!;

    public decimal IdPolo { get; set; }

    public virtual ICollection<ErpPessoaVendedor> ErpPessoaVendedors { get; set; } = new List<ErpPessoaVendedor>();

    public virtual ErpPolo ErpPolo { get; set; } = null!;
}
