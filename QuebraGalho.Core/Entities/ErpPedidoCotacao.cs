using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpPedidoCotacao
{
    public string NrLicenca { get; set; } = null!;

    public decimal NrCotacao { get; set; }

    public decimal IdPessoa { get; set; }

    public DateTime DthrCotacao { get; set; }

    public DateTime DthrRetorno { get; set; }

    public string DmSituacao { get; set; } = null!;

    public string DsEmail { get; set; } = null!;

    public string Identificador { get; set; } = null!;

    public decimal IdUsuario { get; set; }

    public virtual ICollection<ErpPedidoCotacaoItem> ErpPedidoCotacaoItems { get; set; } = new List<ErpPedidoCotacaoItem>();
}
