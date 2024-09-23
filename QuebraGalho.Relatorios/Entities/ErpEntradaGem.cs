using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpEntradaGem
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdGem { get; set; }

    public decimal IdEmpresa { get; set; }

    public DateTime DtRecebimento { get; set; }

    public DateTime DtDocumento { get; set; }

    public string NrDocumento { get; set; } = null!;

    public string NrSerie { get; set; } = null!;

    public decimal IdPessoa { get; set; }

    public decimal IdNaturezaOperacao { get; set; }

    public string CdModeloDocumento { get; set; } = null!;

    public decimal? VlNotaFiscal { get; set; }

    public decimal? VlDescontoFinanceiro { get; set; }

    public decimal? IdAlmoxarifado { get; set; }

    public string DmStatus { get; set; } = null!;

    public decimal? VlAcrescimoFinanceiro { get; set; }

    public string? NrChaveAcesso { get; set; }

    public string? DmImportadoXml { get; set; }

    public string? NrDocumentoExterno { get; set; }

    public DateTime? DtAtualizacao { get; set; }

    public virtual ICollection<ErpEntradaGemFinanceiro> ErpEntradaGemFinanceiros { get; set; } = new List<ErpEntradaGemFinanceiro>();

    public virtual ICollection<ErpEntradaGemItem> ErpEntradaGemItems { get; set; } = new List<ErpEntradaGemItem>();

    public virtual ICollection<ErpEntradaGemRateio> ErpEntradaGemRateios { get; set; } = new List<ErpEntradaGemRateio>();

    public virtual ErpNaturezaOperacao ErpNaturezaOperacao { get; set; } = null!;

    public virtual ErpPessoa ErpPessoa { get; set; } = null!;

    public virtual ICollection<ErpTituloPagar> ErpTituloPagars { get; set; } = new List<ErpTituloPagar>();

    public virtual ErpLicenca NrLicencaNavigation { get; set; } = null!;
}
