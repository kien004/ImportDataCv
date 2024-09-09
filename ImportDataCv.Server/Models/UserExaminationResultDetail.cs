using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class UserExaminationResultDetail
{
    public int Id { get; set; }

    public string? SessionCode { get; set; }

    public string? QuestionCode { get; set; }

    public string? Answer { get; set; }

    public string? Guide { get; set; }

    public bool? IsPass { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? DeletedTime { get; set; }

    public string? DeletedBy { get; set; }
}
