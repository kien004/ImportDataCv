using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class WorkflowActivity
{
    public int Id { get; set; }

    public string? WorkFlowCode { get; set; }

    public string? ActCode { get; set; }

    public string? Priority { get; set; }

    public string? Note { get; set; }

    public string? UnitTime { get; set; }

    public string? LimitTime { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }

    public string? Branch { get; set; }

    public string? Department { get; set; }
}
