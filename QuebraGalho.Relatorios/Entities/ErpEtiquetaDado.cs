using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpEtiquetaDado
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdEtiqueta { get; set; }

    public decimal NrItem { get; set; }

    public string Titulo { get; set; } = null!;

    public string Origem { get; set; } = null!;

    public string Tipcb { get; set; } = null!;

    public string Lbarlar { get; set; } = null!;

    public string Lbarf { get; set; } = null!;

    public string Altcbar { get; set; } = null!;

    public string Eixoy { get; set; } = null!;

    public string Eixox { get; set; } = null!;

    public virtual ErpEtiquetum ErpEtiquetum { get; set; } = null!;
}
