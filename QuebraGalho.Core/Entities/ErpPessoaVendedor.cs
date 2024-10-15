using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpPessoaVendedor
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdPessoa { get; set; }

    public decimal PercComissao { get; set; }

    public string CodigoBanco { get; set; } = null!;

    public string? NrAgencia { get; set; }

    public string? NrConta { get; set; }

    public string? DmTipoConta { get; set; }

    public decimal IdSetor { get; set; }

    public string? DsObservacao { get; set; }

    public virtual ErpBancoFebraban CodigoBancoNavigation { get; set; } = null!;

    public virtual ErpPessoa ErpPessoa { get; set; } = null!;

    public virtual ErpSetor ErpSetor { get; set; } = null!;
}
