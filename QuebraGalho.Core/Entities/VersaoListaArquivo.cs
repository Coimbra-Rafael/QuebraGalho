using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class VersaoListaArquivo
{
    public string IdVersao { get; set; } = null!;

    public decimal NrItem { get; set; }

    public string DmTipoArquivo { get; set; } = null!;

    public string NmArquivo { get; set; } = null!;

    public string IdArquivo { get; set; } = null!;

    public virtual VersaoArquivo IdArquivoNavigation { get; set; } = null!;

    public virtual VersaoSistema IdVersaoNavigation { get; set; } = null!;
}
