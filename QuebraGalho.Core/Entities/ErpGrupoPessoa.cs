using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpGrupoPessoa
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdGrupo { get; set; }

    public string? DsGrupo { get; set; }

    public virtual ICollection<ErpPessoaCliente> ErpPessoaClientes { get; set; } = new List<ErpPessoaCliente>();
}
