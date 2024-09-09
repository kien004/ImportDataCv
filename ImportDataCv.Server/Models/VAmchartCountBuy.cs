using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class VAmchartCountBuy
{
    public Guid? Id { get; set; }

    public int? Month { get; set; }

    public int? Income { get; set; }

    public decimal? Total { get; set; }
}
