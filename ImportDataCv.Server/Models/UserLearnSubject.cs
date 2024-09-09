using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class UserLearnSubject
{
    public int Id { get; set; }

    public string? SubjectCode { get; set; }

    public string? LectureCode { get; set; }

    public string? SessionCode { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? StopTime { get; set; }
}
