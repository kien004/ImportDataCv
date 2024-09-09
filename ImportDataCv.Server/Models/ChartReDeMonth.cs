using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class ChartReDeMonth
{
    public int Id { get; set; }

    public int Month { get; set; }

    public int Revenue { get; set; }

    public int Debts { get; set; }
}
