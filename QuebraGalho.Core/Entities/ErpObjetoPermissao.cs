﻿using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpObjetoPermissao
{
    public string NmObjeto { get; set; } = null!;

    public string DsObjeto { get; set; } = null!;

    public string? Url { get; set; }
}
