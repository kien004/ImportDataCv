using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class LmsExamDetail
{
    public int Id { get; set; }

    public string? QuestCode { get; set; }

    public int? Mark { get; set; }

    public int? Order { get; set; }

    public int? Duration { get; set; }

    public string? Unit { get; set; }

    public string? ExamCode { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }
}
