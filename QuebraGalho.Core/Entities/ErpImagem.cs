using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpImagem
{
    public string IdImagem { get; set; } = null!;

    public byte[] Imagem { get; set; } = null!;

    public virtual ICollection<ErpProdutoServicoCorImagem> ErpProdutoServicoCorImagems { get; set; } = new List<ErpProdutoServicoCorImagem>();
}
