using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpBancoFebraban
{
    public string CodigoBanco { get; set; } = null!;

    public string NomeBanco { get; set; } = null!;

    public virtual ICollection<ErpBancoContum> ErpBancoConta { get; set; } = new List<ErpBancoContum>();

    public virtual ICollection<ErpPessoaVendedor> ErpPessoaVendedors { get; set; } = new List<ErpPessoaVendedor>();
}
