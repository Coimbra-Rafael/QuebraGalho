using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpPessoaMigracao
{
    public string NrLicenca { get; set; } = null!;

    public string Identificador { get; set; } = null!;

    public decimal IdPessoa { get; set; }

    public string NrCnpjCpf { get; set; } = null!;

    public string NrInscricaoRg { get; set; } = null!;

    public string NmRazaoSocial { get; set; } = null!;

    public string NmFantasia { get; set; } = null!;

    public string DsEndereco { get; set; } = null!;

    public string NrEndereco { get; set; } = null!;

    public string DsComplemento { get; set; } = null!;

    public string DsBairro { get; set; } = null!;

    public decimal? IdMunicipio { get; set; }

    public string? DsMunicipio { get; set; }

    public string NrCep { get; set; } = null!;

    public string? DsEmail { get; set; }

    public string? NrDdd { get; set; }

    public string? NrTelefone { get; set; }

    public string DmProcessado { get; set; } = null!;
}
