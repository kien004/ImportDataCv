using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class PlanExcuteRecruitmentHeader
{
    public int Id { get; set; }

    public string? RecruitmentCode { get; set; }

    public string? Title { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public string? SubjectCode { get; set; }

    public string? PlanNumber { get; set; }

    public string? Status { get; set; }

    public string? StatusLog { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool IsDeleted { get; set; }
}
