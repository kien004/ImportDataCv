using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class WorkflowInstanceRunning
{
    public int Id { get; set; }

    public string? WorkflowCode { get; set; }

    public string? ActivityInitial { get; set; }

    public string? TransitionCode { get; set; }

    public string? ActivityDestination { get; set; }

    public string? Command { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }

    public string? WfInstCode { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? EndTime { get; set; }
}
