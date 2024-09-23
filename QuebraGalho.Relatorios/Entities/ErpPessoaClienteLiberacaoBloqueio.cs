using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpPessoaClienteLiberacaoBloqueio
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdPessoa { get; set; }

    public DateTime DthrEvento { get; set; }

    public string DmBloqueioLibera { get; set; } = null!;

    public string? DsObservacao { get; set; }

    public decimal IdUsuario { get; set; }

    public virtual ErpPessoaCliente ErpPessoaCliente { get; set; } = null!;
}
