using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class VAmchartLearnSubject
{
    public Guid? Id { get; set; }

    public int? MonthData { get; set; }

    public string? CreatedBy { get; set; }

    public int? UserCount { get; set; }

    public int? LstMonth { get; set; }
}
