using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpComputador
{
    public string NrLicenca { get; set; } = null!;

    public string IdComputador { get; set; } = null!;

    public string NmComputador { get; set; } = null!;

    public decimal NrPdv { get; set; }

    public string DmAtivo { get; set; } = null!;

    public string? MacAddress { get; set; }

    public string? DmCaixaPrincipal { get; set; }

    public decimal? NrDocumentoNfce { get; set; }

    public decimal? NrSerieNfce { get; set; }

    public string? DadosVersao { get; set; }

    public DateTime? DthrUltimoSinc { get; set; }

    public decimal? IdEmpresa { get; set; }

    public string? DmTipoComputador { get; set; }

    public virtual ICollection<ErpMovimento> ErpMovimentos { get; set; } = new List<ErpMovimento>();

    public virtual ICollection<ErpParametrosComputador> ErpParametrosComputadors { get; set; } = new List<ErpParametrosComputador>();

    public virtual ICollection<ErpSincCodigo> ErpSincCodigos { get; set; } = new List<ErpSincCodigo>();

    public virtual ICollection<PdvTipoRecebimentoComputador> PdvTipoRecebimentoComputadors { get; set; } = new List<PdvTipoRecebimentoComputador>();
}
