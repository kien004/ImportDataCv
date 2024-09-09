using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class VAmchartCrawlingLog
{
    public Guid? Id { get; set; }

    public int? SumPasscap { get; set; }

    public int? SumTimeScan { get; set; }

    public int? SumUrl { get; set; }

    public int? SumFile { get; set; }

    public int? LstDay { get; set; }
}
