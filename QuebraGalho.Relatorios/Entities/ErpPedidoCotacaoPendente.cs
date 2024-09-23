using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpPedidoCotacaoPendente
{
    public string NrLicenca { get; set; } = null!;

    public string Identificador { get; set; } = null!;

    public DateTime DthrCotacao { get; set; }

    public DateTime DthrRetorno { get; set; }

    public decimal IdUsuario { get; set; }

    public virtual ICollection<ErpPedidoCotacaoPendenteItem> ErpPedidoCotacaoPendenteItems { get; set; } = new List<ErpPedidoCotacaoPendenteItem>();
}
