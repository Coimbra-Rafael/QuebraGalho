using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpPessoaCliente
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdPessoa { get; set; }

    public decimal IdCarteira { get; set; }

    public decimal? VlLimiteCredito { get; set; }

    public decimal IdAtividade { get; set; }

    public decimal IdGrupo { get; set; }

    public string? DmConsumidorFinal { get; set; }

    public decimal? IdPessoaVendedor { get; set; }

    public decimal? IdTabelaPreco { get; set; }

    public string? DmBloquearLimiteAtingido { get; set; }

    public virtual ErpAtividadePessoa ErpAtividadePessoa { get; set; } = null!;

    public virtual ErpBancoCarteira ErpBancoCarteira { get; set; } = null!;

    public virtual ErpGrupoPessoa ErpGrupoPessoa { get; set; } = null!;

    public virtual ErpPessoa ErpPessoa { get; set; } = null!;

    public virtual ICollection<ErpPessoaClienteLiberacaoBloqueio> ErpPessoaClienteLiberacaoBloqueios { get; set; } = new List<ErpPessoaClienteLiberacaoBloqueio>();

    public virtual ErpTabelaPreco? ErpTabelaPreco { get; set; }
}
