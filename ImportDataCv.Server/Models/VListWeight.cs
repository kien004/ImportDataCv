using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class VListWeight
{
    public string? CardCode { get; set; }

    public decimal WeightNum { get; set; }

    public int? Month { get; set; }

    public decimal? Progress { get; set; }
}
