using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpFrameworkPesq
{
    public string IdPesquisa { get; set; } = null!;

    public string? DsTitulo { get; set; }

    public string? DsCampoPesq01 { get; set; }

    public string? DsCampoPesq02 { get; set; }

    public string? DsCampoPesq03 { get; set; }

    public string? ComandoSql { get; set; }

    public string? DmLike { get; set; }

    public virtual ICollection<ErpFrameworkPesqCampo> ErpFrameworkPesqCampos { get; set; } = new List<ErpFrameworkPesqCampo>();
}
