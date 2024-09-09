using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class VAssetStatus
{
    public string Type { get; set; } = null!;

    public int? Quantity { get; set; }

    public int? Year { get; set; }
}
