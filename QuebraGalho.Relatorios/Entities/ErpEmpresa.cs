using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpEmpresa
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdEmpresa { get; set; }

    public decimal CdEmpresa { get; set; }

    public decimal CdUnidade { get; set; }

    public string NmFantasia { get; set; } = null!;

    public string NmRazaoSocial { get; set; } = null!;

    public string? NrCnpj { get; set; }

    public string? NrInscricaoEstadual { get; set; }

    public decimal IdMunicipio { get; set; }

    public string DsEndereco { get; set; } = null!;

    public byte[] NrEndereco { get; set; } = null!;

    public string? DsEnderecoCompl { get; set; }

    public string DsBairro { get; set; } = null!;

    public string NrCep { get; set; } = null!;

    public string? NrDdd { get; set; }

    public string? NrTelefone { get; set; }

    public decimal IdPais { get; set; }

    public string? Crt { get; set; }

    public string? DsEmail { get; set; }

    public virtual ICollection<ErpBoleto> ErpBoletos { get; set; } = new List<ErpBoleto>();

    public virtual ICollection<ErpCmd> ErpCmds { get; set; } = new List<ErpCmd>();

    public virtual ErpConfigEmpresa? ErpConfigEmpresa { get; set; }

    public virtual ICollection<ErpConfigEmpresaMail> ErpConfigEmpresaMails { get; set; } = new List<ErpConfigEmpresaMail>();

    public virtual ErpConfigEmpresaModulo? ErpConfigEmpresaModulo { get; set; }

    public virtual ErpConfigEmpresaScantech? ErpConfigEmpresaScantech { get; set; }

    public virtual ErpConfigEmpresaYandeh? ErpConfigEmpresaYandeh { get; set; }

    public virtual ErpEmpresaLogotipo? ErpEmpresaLogotipo { get; set; }

    public virtual ICollection<ErpFechamentoDiarioScantech> ErpFechamentoDiarioScanteches { get; set; } = new List<ErpFechamentoDiarioScantech>();

    public virtual ICollection<ErpInventario> ErpInventarios { get; set; } = new List<ErpInventario>();

    public virtual ICollection<ErpKardex> ErpKardices { get; set; } = new List<ErpKardex>();

    public virtual ICollection<ErpMovimentoEstoque> ErpMovimentoEstoques { get; set; } = new List<ErpMovimentoEstoque>();

    public virtual ICollection<ErpPermissao> ErpPermissaos { get; set; } = new List<ErpPermissao>();

    public virtual ICollection<ErpProdutoSaldo> ErpProdutoSaldos { get; set; } = new List<ErpProdutoSaldo>();

    public virtual ICollection<ErpProdutoValorMedio> ErpProdutoValorMedios { get; set; } = new List<ErpProdutoValorMedio>();

    public virtual ICollection<ErpPromocao> ErpPromocaos { get; set; } = new List<ErpPromocao>();

    public virtual ICollection<ErpSinc> ErpSincs { get; set; } = new List<ErpSinc>();

    public virtual ErpMunicipio IdMunicipioNavigation { get; set; } = null!;

    public virtual ErpPai IdPaisNavigation { get; set; } = null!;

    public virtual ErpLicenca NrLicencaNavigation { get; set; } = null!;
}
