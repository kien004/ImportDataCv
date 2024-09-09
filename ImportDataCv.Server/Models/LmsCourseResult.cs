using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class LmsCourseResult
{
    public int Id { get; set; }

    public string? CourseCode { get; set; }

    public int? TotalLecture { get; set; }

    public int? TotalQuiz { get; set; }

    public int? CountViewLecture { get; set; }

    public int? CountQuiz { get; set; }

    public int? CorrectQuiz { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? DeletedTime { get; set; }

    public string? DeletedBy { get; set; }
}
