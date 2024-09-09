using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class WeekWorkingScheduler
{
    public int Id { get; set; }

    public string? Content { get; set; }

    public string? Composition { get; set; }

    public string? Chair { get; set; }

    public string? Room { get; set; }

    public DateTime CreatedTime { get; set; }

    public string? TimeStart { get; set; }

    public string? TimeEnd { get; set; }

    public string? CreatedBy { get; set; }
}
