using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpPessoa
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdPessoa { get; set; }

    public string NrCnpjCpf { get; set; } = null!;

    public string NrInscricaoRg { get; set; } = null!;

    public string NmRazaoSocial { get; set; } = null!;

    public string NmFantasia { get; set; } = null!;

    public string DsEndereco { get; set; } = null!;

    public string NrEndereco { get; set; } = null!;

    public string? DsComplemento { get; set; }

    public string? DsBairro { get; set; }

    public decimal IdMunicipio { get; set; }

    public string NrCep { get; set; } = null!;

    public string? DsEmail { get; set; }

    public string? NrSuframa { get; set; }

    public string? NrDdd { get; set; }

    public string? NrTelefone { get; set; }

    public string? NrDocumentoEx { get; set; }

    public string? CdPessoa { get; set; }

    public string? DmTipoInscricao { get; set; }

    public DateTime? DthrInclusao { get; set; }

    public DateTime? DthrAtualizacao { get; set; }

    public decimal? IdPessoaTipo { get; set; }

    public string DmSituacao { get; set; } = null!;

    public virtual ICollection<ErpEntradaGem> ErpEntradaGems { get; set; } = new List<ErpEntradaGem>();

    public virtual ICollection<ErpMovimento> ErpMovimentoErpPessoa1s { get; set; } = new List<ErpMovimento>();

    public virtual ICollection<ErpMovimento> ErpMovimentoErpPessoaNavigations { get; set; } = new List<ErpMovimento>();

    public virtual ICollection<ErpMovimento> ErpMovimentoErpPessoas { get; set; } = new List<ErpMovimento>();

    public virtual ICollection<ErpPedidoVendum> ErpPedidoVendumErpPessoaNavigations { get; set; } = new List<ErpPedidoVendum>();

    public virtual ICollection<ErpPedidoVendum> ErpPedidoVendumErpPessoas { get; set; } = new List<ErpPedidoVendum>();

    public virtual ErpPessoaCliente? ErpPessoaCliente { get; set; }

    public virtual ErpPessoaTipo? ErpPessoaTipo { get; set; }

    public virtual ErpPessoaVendedor? ErpPessoaVendedor { get; set; }

    public virtual ICollection<ErpProdutoServicoFornecedoresCotacao> ErpProdutoServicoFornecedoresCotacaos { get; set; } = new List<ErpProdutoServicoFornecedoresCotacao>();

    public virtual ICollection<ErpTituloPagar> ErpTituloPagars { get; set; } = new List<ErpTituloPagar>();

    public virtual ICollection<ErpTituloReceber> ErpTituloRecebers { get; set; } = new List<ErpTituloReceber>();

    public virtual ErpLicenca NrLicencaNavigation { get; set; } = null!;
}
