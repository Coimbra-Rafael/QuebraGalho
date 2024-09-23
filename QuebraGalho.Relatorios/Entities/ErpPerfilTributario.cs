using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpPerfilTributario
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdPerfilTributario { get; set; }

    public string DsPerfilTributario { get; set; } = null!;

    public virtual ICollection<ErpPerfilTributarioCofin> ErpPerfilTributarioCofins { get; set; } = new List<ErpPerfilTributarioCofin>();

    public virtual ICollection<ErpPerfilTributarioIcm> ErpPerfilTributarioIcms { get; set; } = new List<ErpPerfilTributarioIcm>();

    public virtual ICollection<ErpPerfilTributarioIcmsSimple> ErpPerfilTributarioIcmsSimples { get; set; } = new List<ErpPerfilTributarioIcmsSimple>();

    public virtual ICollection<ErpPerfilTributarioIpi> ErpPerfilTributarioIpis { get; set; } = new List<ErpPerfilTributarioIpi>();

    public virtual ICollection<ErpPerfilTributarioPi> ErpPerfilTributarioPis { get; set; } = new List<ErpPerfilTributarioPi>();

    public virtual ICollection<ErpProdutoServicoOutro> ErpProdutoServicoOutros { get; set; } = new List<ErpProdutoServicoOutro>();
}
