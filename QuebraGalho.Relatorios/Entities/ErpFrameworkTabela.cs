using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpFrameworkTabela
{
    public string NmClasse { get; set; } = null!;

    public string? NmEntidade { get; set; }

    public string? DsTitulo { get; set; }

    public string? NmPersistence { get; set; }

    public string? NmPersistenceObject { get; set; }

    public string? ComandoSql { get; set; }

    public string? NmAutofocoInsert { get; set; }

    public string? NmAutofocoUpdate { get; set; }

    public string? NmClasseFilha { get; set; }

    public string? DmMestreDetalhe { get; set; }

    public virtual ICollection<ErpFrameworkCampo> ErpFrameworkCampos { get; set; } = new List<ErpFrameworkCampo>();
}
