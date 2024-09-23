using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpUsuario1
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdUsuario { get; set; }

    public string NmUsuario { get; set; } = null!;

    public string NmCompleto { get; set; } = null!;

    public string SenhaUsuarioMd5 { get; set; } = null!;

    public string? DsEmail { get; set; }

    public string DmStatus { get; set; } = null!;

    public string? NmLogin { get; set; }

    public string? HashAtivacao { get; set; }

    public string? DmFiscal { get; set; }

    public string? DmCaixa { get; set; }

    public string? DsSenhaFiscal { get; set; }

    public string? SenhaFiscal { get; set; }

    public string? DmTipoUsuario { get; set; }
}
