using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class LmsQuizLectureSubjectCourse
{
    public int Id { get; set; }

    public string? QuizCode { get; set; }

    public string? LectureCode { get; set; }

    public string? SubjectCode { get; set; }

    public string? CourseCode { get; set; }
}
