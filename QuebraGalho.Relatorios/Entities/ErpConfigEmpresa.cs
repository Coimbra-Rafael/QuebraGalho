using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpConfigEmpresa
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdEmpresa { get; set; }

    public string? DsCaminhoRsc { get; set; }

    public string? DsArquivoLogo { get; set; }

    public string NrVersaoAplicativo { get; set; } = null!;

    public string? DsCaminhoTmp { get; set; }

    public string? DsCaminhoLog { get; set; }

    public string? DsUrlNfe { get; set; }

    public string? DsCaminhoJasper { get; set; }

    public string? DsUrlTributacao { get; set; }

    public string? DmTributacaoAutomatica { get; set; }

    public string? DsUrlCotacao { get; set; }

    public virtual ErpEmpresa ErpEmpresa { get; set; } = null!;
}
