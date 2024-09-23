using System;
using System.Collections.Generic;

namespace QuebraGalho.Relatorios.Entities;

public partial class ErpBancoContum
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdBancoConta { get; set; }

    public string CodigoBanco { get; set; } = null!;

    public string NrAgencia { get; set; } = null!;

    public string NrConta { get; set; } = null!;

    public string DsBancoConta { get; set; } = null!;

    public virtual ErpBancoFebraban CodigoBancoNavigation { get; set; } = null!;

    public virtual ICollection<ErpBancoCarteira> ErpBancoCarteiras { get; set; } = new List<ErpBancoCarteira>();

    public virtual ICollection<ErpBancoContaSaldo> ErpBancoContaSaldos { get; set; } = new List<ErpBancoContaSaldo>();

    public virtual ICollection<ErpTituloPagarBaixa> ErpTituloPagarBaixas { get; set; } = new List<ErpTituloPagarBaixa>();
}
