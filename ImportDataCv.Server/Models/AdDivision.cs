﻿using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class AdDivision
{
    public string Division { get; set; } = null!;

    public string? DivisionDesc { get; set; }

    public string? UpdateTime { get; set; }
}
