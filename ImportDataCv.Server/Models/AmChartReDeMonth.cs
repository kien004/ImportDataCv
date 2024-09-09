using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class AmChartReDeMonth
{
    public string Id { get; set; } = null!;

    public int Month { get; set; }

    public int Revenue { get; set; }

    public int Depts { get; set; }
}
