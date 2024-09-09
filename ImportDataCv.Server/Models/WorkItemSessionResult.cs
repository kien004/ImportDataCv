using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class WorkItemSessionResult
{
    public int Id { get; set; }

    public string? WorkSession { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public decimal? ProgressFromStaff { get; set; }

    public decimal? ProgressFromLeader { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }

    public string? ChkListCode { get; set; }

    public string? NoteFromLeader { get; set; }

    public string? ShiftCode { get; set; }

    public string? UserAssessor { get; set; }

    public DateTime? ApproveTime { get; set; }
}
