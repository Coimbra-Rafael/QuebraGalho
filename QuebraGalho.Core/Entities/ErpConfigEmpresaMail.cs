using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpConfigEmpresaMail
{
    public decimal IdEmpresa { get; set; }

    public string NrLicenca { get; set; } = null!;

    public string? PopEmail { get; set; }

    public string? PopPorta { get; set; }

    public string? PopUsuario { get; set; }

    public string? PopSenha { get; set; }

    public string? DmPopSsl { get; set; }

    public string? SmtpEmail { get; set; }

    public string? SmtpRemetente { get; set; }

    public string? SmtpUsuario { get; set; }

    public string? SmtpPorta { get; set; }

    public string? DmSmtpSsl { get; set; }

    public string? SmtpSenha { get; set; }

    public string? SmtpRemetenteFinanceiro { get; set; }

    public virtual ErpEmpresa ErpEmpresa { get; set; } = null!;
}
