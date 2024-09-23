using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpArquivoBalanca
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdEmpresa { get; set; }

    public string IdArquivo { get; set; } = null!;

    public DateTime? DthrGeracao { get; set; }

    public string DmSinc { get; set; } = null!;

    public byte[] ConteudoArquivo { get; set; } = null!;
}
