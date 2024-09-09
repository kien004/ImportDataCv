using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class WorkFlowRule
{
    public int Id { get; set; }

    public string? ActCode { get; set; }

    public string? Rule { get; set; }

    public string? StepBack { get; set; }

    public string? StepForward { get; set; }

    public int? Priority { get; set; }

    public DateTime? FromTime { get; set; }

    public DateTime? ToTime { get; set; }

    public string? Noted { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }
}
