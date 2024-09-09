using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class LmsTaskUserItemProgress
{
    public int Id { get; set; }

    public string? ItemCode { get; set; }

    public string? TrainingType { get; set; }

    public string? ItemTitle { get; set; }

    public string? LmsTaskCode { get; set; }

    public string? User { get; set; }

    public decimal? ProgressAuto { get; set; }

    public decimal? TeacherApproved { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public bool? IsDeleted { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }
}
