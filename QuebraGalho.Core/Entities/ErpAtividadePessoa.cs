using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpAtividadePessoa
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdAtividade { get; set; }

    public string DsAtividade { get; set; } = null!;

    public virtual ICollection<ErpPessoaCliente> ErpPessoaClientes { get; set; } = new List<ErpPessoaCliente>();
}
