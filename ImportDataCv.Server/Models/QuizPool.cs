using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class QuizPool
{
    /// <summary>
    /// Customer Id
    /// </summary>
    public int Id { get; set; }

    public string? Code { get; set; }

    public string? Title { get; set; }

    public string? Content { get; set; }

    public int? Category { get; set; }

    public string? JsonData { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? DeletedTime { get; set; }

    public string? DeletedBy { get; set; }

    public string? LectureRelative { get; set; }

    public string? Level { get; set; }

    public string? LectureCode { get; set; }

    public int? Duration { get; set; }

    public string? Unit { get; set; }

    public string? SubjectCode { get; set; }

    public string? Type { get; set; }

    public string? JsonRef { get; set; }

    public string? QuestionMedia { get; set; }

    public string? Status { get; set; }

    public string? Share { get; set; }

    public string? Solve { get; set; }

    public string? RatingLog { get; set; }

    public decimal? Price { get; set; }

    public bool? IsTutor888 { get; set; }

    public string? LatexInQuiz { get; set; }

    public decimal? Rating { get; set; }
}
