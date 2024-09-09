using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class WorkOsListTrackingProgress
{
    public int Id { get; set; }

    public string? ListCode { get; set; }

    public int Completed { get; set; }

    public DateTime? CompletedTime { get; set; }
}
