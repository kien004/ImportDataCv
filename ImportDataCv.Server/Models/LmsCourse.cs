using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class LmsCourse
{
    public int Id { get; set; }

    public string? CourseCode { get; set; }

    public string? CourseName { get; set; }

    public string? CourseNote { get; set; }

    public string? ImgCover { get; set; }

    public int? Duration { get; set; }

    public string? Unit { get; set; }

    public string? Status { get; set; }

    public int? Flag { get; set; }

    public string? VideoPresent { get; set; }

    public string? FileBase { get; set; }

    public int? Rating { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public bool? IsDeleted { get; set; }

    public string? DeletedBy { get; set; }

    public string? ListSubject { get; set; }

    public bool? TopSearch { get; set; }

    public decimal? Price { get; set; }

    public string? ListVideo { get; set; }

    public string? Tags { get; set; }
}
