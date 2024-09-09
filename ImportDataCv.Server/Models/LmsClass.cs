using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class LmsClass
{
    public int Id { get; set; }

    public string? ClassCode { get; set; }

    public string? ClassName { get; set; }

    public string? LmsTaskCode { get; set; }

    public string? Status { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public string? Noted { get; set; }

    public string? ManagerTeacher { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? DeletedTime { get; set; }

    public string? DeletedBy { get; set; }
}
