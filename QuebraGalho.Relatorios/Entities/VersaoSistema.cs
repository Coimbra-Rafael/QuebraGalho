using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class VersaoSistema
{
    public string IdVersao { get; set; } = null!;

    public string DsVersao { get; set; } = null!;

    public DateOnly? DthrLiberacaoVersao { get; set; }

    public string ObservacaoVersao { get; set; } = null!;

    public decimal NrVersao { get; set; }

    public string? NmTipoSistema { get; set; }

    public virtual ICollection<VersaoListaArquivo> VersaoListaArquivos { get; set; } = new List<VersaoListaArquivo>();
}
