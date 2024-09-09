using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class LmsLectureManagement
{
    public int Id { get; set; }

    public string? LectCode { get; set; }

    public string? LectName { get; set; }

    public string? LectDescription { get; set; }

    public int? Duration { get; set; }

    public string? Unit { get; set; }

    public string? SubjectCode { get; set; }

    public string? Status { get; set; }

    public string? VideoPresent { get; set; }

    public string? VideosDuration { get; set; }

    public string? Share { get; set; }

    public string? Level { get; set; }

    public string? Rating { get; set; }

    public bool? IsInteractive { get; set; }

    public string? InteractiveFilePath { get; set; }

    public decimal? Price { get; set; }

    public string? JsonTutor888 { get; set; }

    public bool? IsTutor888 { get; set; }

    public string? AnswerTutor888 { get; set; }
}
