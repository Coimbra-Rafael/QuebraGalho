using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpPessoaTipo
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdPessoaTipo { get; set; }

    public string DsPessoaTipo { get; set; } = null!;

    public virtual ICollection<ErpPessoa> ErpPessoas { get; set; } = new List<ErpPessoa>();
}
