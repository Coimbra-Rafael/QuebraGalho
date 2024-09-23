using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpEtiquetum
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdEtiqueta { get; set; }

    public string NmEtiqueta { get; set; } = null!;

    public decimal Resolucao { get; set; }

    public decimal Colunas { get; set; }

    public string Distancia { get; set; } = null!;

    public decimal Velocidade { get; set; }

    public decimal QtdeCaracterLinha2 { get; set; }

    public decimal QtdeCaracterLinha6 { get; set; }

    public decimal IdEmpresa { get; set; }

    public virtual ICollection<ErpEtiquetaDado> ErpEtiquetaDados { get; set; } = new List<ErpEtiquetaDado>();
}
