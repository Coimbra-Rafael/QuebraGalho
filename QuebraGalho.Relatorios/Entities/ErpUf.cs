using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpUf
{
    public string IdUf { get; set; } = null!;

    public string DsUf { get; set; } = null!;

    public virtual ICollection<ErpMunicipio> ErpMunicipios { get; set; } = new List<ErpMunicipio>();

    public virtual ICollection<ErpPerfilTributarioIcm> ErpPerfilTributarioIcmUfDestinoNavigations { get; set; } = new List<ErpPerfilTributarioIcm>();

    public virtual ICollection<ErpPerfilTributarioIcm> ErpPerfilTributarioIcmUfOrigemNavigations { get; set; } = new List<ErpPerfilTributarioIcm>();

    public virtual ICollection<ErpPerfilTributarioIcmsSimple> ErpPerfilTributarioIcmsSimpleUfDestinoNavigations { get; set; } = new List<ErpPerfilTributarioIcmsSimple>();

    public virtual ICollection<ErpPerfilTributarioIcmsSimple> ErpPerfilTributarioIcmsSimpleUfOrigemNavigations { get; set; } = new List<ErpPerfilTributarioIcmsSimple>();
}
