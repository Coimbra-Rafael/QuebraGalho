using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpClassificacaoFiscal
{
    public string CdClassificacao { get; set; } = null!;

    public string DsClassificacao { get; set; } = null!;

    public virtual ICollection<ErpPerfilTributarioIcm> ErpPerfilTributarioIcms { get; set; } = new List<ErpPerfilTributarioIcm>();
}
