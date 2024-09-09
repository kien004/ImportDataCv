using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class VcWorkPlanLog
{
    public int Id { get; set; }

    public string Wpcode { get; set; } = null!;

    public DateTime? Currenttime { get; set; }

    public string? Currentstatus { get; set; }

    public float? Percent { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool IsDeleted { get; set; }
}
