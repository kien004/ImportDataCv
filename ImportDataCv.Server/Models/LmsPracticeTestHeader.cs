using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class LmsPracticeTestHeader
{
    public int Id { get; set; }

    public string? PracticeTestCode { get; set; }

    public string? PracticeTestTitle { get; set; }

    public string? Description { get; set; }

    public int? Duration { get; set; }

    public string? Unit { get; set; }

    public string? Level { get; set; }

    public int? MarkPass { get; set; }

    public int? MarkTotal { get; set; }

    public int? NumQuiz { get; set; }

    public string? Status { get; set; }

    public bool? ViewResult { get; set; }

    public bool? Rework { get; set; }

    public bool? WorkSequence { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }

    public string? SubjectCode { get; set; }

    public bool? IsPublished { get; set; }

    public string? Share { get; set; }

    public string? RatingLog { get; set; }

    public decimal? Rating { get; set; }

    public string? FilePath { get; set; }

    public decimal? Price { get; set; }
}
