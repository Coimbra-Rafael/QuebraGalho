﻿using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ViewErpProdutoServicoPesquisa
{
    public string NrLicenca { get; set; } = null!;

    public decimal IdProdutoServico { get; set; }

    public string DsProdutoServicoCodigo { get; set; } = null!;
}
