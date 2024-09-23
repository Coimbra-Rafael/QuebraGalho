using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpMensagemSistema
{
    public string NrLicenca { get; set; } = null!;

    public string IdMensagem { get; set; } = null!;

    public DateTime DthrMensagem { get; set; }

    public decimal? IdUsuario { get; set; }

    public byte[]? DsMensagem { get; set; }

    public string DmStatus { get; set; } = null!;
}
