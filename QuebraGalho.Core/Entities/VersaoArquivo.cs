using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class VersaoArquivo
{
    public string IdArquivo { get; set; } = null!;

    public byte[] ConteudoArquivo { get; set; } = null!;

    public virtual ICollection<VersaoListaArquivo> VersaoListaArquivos { get; set; } = new List<VersaoListaArquivo>();
}
