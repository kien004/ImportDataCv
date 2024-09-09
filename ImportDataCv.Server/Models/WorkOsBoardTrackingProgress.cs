using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class WorkOsBoardTrackingProgress
{
    public int Id { get; set; }

    public string? BoardCode { get; set; }

    public int Completed { get; set; }

    public DateTime? CompletedTime { get; set; }
}
