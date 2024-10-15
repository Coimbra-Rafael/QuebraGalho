using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpPromocaoProdutosCodigo
{
    public string NrLicenca { get; set; } = null!;

    public string Identificador { get; set; } = null!;

    public decimal IdPromocao { get; set; }

    public decimal IdEmpresa { get; set; }

    public string IdProdutosCodigos { get; set; } = null!;

    public decimal QtdeInicial { get; set; }

    public decimal QtdeFinal { get; set; }

    public decimal Valor { get; set; }

    public string DmValor { get; set; } = null!;

    public decimal? IdRecebimento { get; set; }

    public virtual ErpProdutoServicoCodigo ErpProdutoServicoCodigo { get; set; } = null!;

    public virtual ErpPromocao ErpPromocao { get; set; } = null!;

    public virtual PdvTipoRecebimento? PdvTipoRecebimento { get; set; }
}
