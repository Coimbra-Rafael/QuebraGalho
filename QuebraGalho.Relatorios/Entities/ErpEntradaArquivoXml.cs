using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpEntradaArquivoXml
{
    public string NrLicenca { get; set; } = null!;

    public string IdArquivo { get; set; } = null!;

    public decimal? IdSinc { get; set; }

    public string NrChaveAcesso { get; set; } = null!;

    public string NrCnpjEmitente { get; set; } = null!;

    public string NrDocumento { get; set; } = null!;

    public DateOnly DtEmissaoDocumento { get; set; }

    public string NmPessoaEmitente { get; set; } = null!;

    public string DmProcessado { get; set; } = null!;

    public decimal? VlNotaFiscal { get; set; }
}
