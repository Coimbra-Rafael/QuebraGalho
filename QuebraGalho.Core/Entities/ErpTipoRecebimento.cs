using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpTipoRecebimento
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdTipoRecebimento { get; set; }

    public string DsTipoRecebimento { get; set; } = null!;

    public decimal? IdTipoMovimento { get; set; }

    public virtual ICollection<ErpTituloReceberBaixa> ErpTituloReceberBaixas { get; set; } = new List<ErpTituloReceberBaixa>();
}
