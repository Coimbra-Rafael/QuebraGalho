using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpPerfilTributarioIcmsSimple
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdPerfilTributario { get; set; }

    public decimal IdNaturezaOperacao { get; set; }

    public string UfOrigem { get; set; } = null!;

    public string UfDestino { get; set; } = null!;

    public decimal AliqIcms { get; set; }

    public decimal AliqIcmsSt { get; set; }

    public decimal AliqIcmsCred { get; set; }

    public string CdClassificacao { get; set; } = null!;

    public string? DmDetBaseCalcIcms { get; set; }

    public string? DmDetBaseCalcIcmsSt { get; set; }

    public string? Csosn { get; set; }

    public decimal? PercRedBcIcms { get; set; }

    public decimal? PercRedBcIcmsSt { get; set; }

    public decimal? PercMva { get; set; }

    public decimal? PercFcp { get; set; }

    public decimal? PercDescSuframa { get; set; }

    public virtual ErpNaturezaOperacao ErpNaturezaOperacao { get; set; } = null!;

    public virtual ErpPerfilTributario ErpPerfilTributario { get; set; } = null!;

    public virtual ErpUf UfDestinoNavigation { get; set; } = null!;

    public virtual ErpUf UfOrigemNavigation { get; set; } = null!;
}
