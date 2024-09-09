using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class VAmchartBuy
{
    public Guid? Id { get; set; }

    public string? Status { get; set; }

    public int? StatusCount { get; set; }

    public int? LstMonth { get; set; }
}
