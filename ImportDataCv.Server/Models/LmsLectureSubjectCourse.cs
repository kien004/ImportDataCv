using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class LmsLectureSubjectCourse
{
    public int Id { get; set; }

    public string? LectureCode { get; set; }

    public string? SubjectCode { get; set; }

    public string? CourseCode { get; set; }
}
