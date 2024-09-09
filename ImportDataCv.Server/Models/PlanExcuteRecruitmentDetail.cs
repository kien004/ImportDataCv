using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class PlanExcuteRecruitmentDetail
{
    public int Id { get; set; }

    public string? RecruitmentCode { get; set; }

    public string? CandidateCode { get; set; }

    public string? Status { get; set; }

    public string? Result { get; set; }

    public string? Note { get; set; }

    public string? ListFileResult { get; set; }

    public bool IsDeleted { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public string? Code { get; set; }
}
