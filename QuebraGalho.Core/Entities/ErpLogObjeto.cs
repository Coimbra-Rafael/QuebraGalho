﻿using System;
using System.Collections.Generic;

namespace QuebraGalho.Core.Entities;

public partial class ErpLogObjeto
{
    public decimal IdLog { get; set; }

    public byte[] XmlObjeto { get; set; } = null!;
}
