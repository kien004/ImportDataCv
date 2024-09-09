using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class LmsExamHeader
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? ExamCode { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? ListUserJoined { get; set; }

    public string? Status { get; set; }

    public string? PracticeTestCode { get; set; }

    public string? BackgroundColor { get; set; }

    public string? BackgroundImage { get; set; }

    public string? Description { get; set; }

    public string? SubjectCode { get; set; }

    public string? Level { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? DeletedTime { get; set; }

    public string? DeletedBy { get; set; }

    public decimal? Price { get; set; }
}
