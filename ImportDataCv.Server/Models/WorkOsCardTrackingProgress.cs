using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class WorkOsCardTrackingProgress
{
    public int Id { get; set; }

    public string? CardCode { get; set; }

    public int Completed { get; set; }

    public DateTime? CompletedTime { get; set; }
}
