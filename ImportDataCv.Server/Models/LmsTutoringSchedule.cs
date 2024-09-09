using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class LmsTutoringSchedule
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public string? Description { get; set; }

    public string? JsonStatus { get; set; }

    public string? ListUserApproved { get; set; }

    public string? BackgroundColor { get; set; }

    public string? BackgroundImage { get; set; }

    public string? Teacher { get; set; }

    public string? SubjectCode { get; set; }

    public string? CourseCode { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? DeletedTime { get; set; }

    public string? DeletedBy { get; set; }

    public string? AccountZoom { get; set; }

    public string? LessonDoc { get; set; }

    public bool? IsPopupAllowed { get; set; }

    public int? MeetingId { get; set; }

    public decimal? Price { get; set; }

    public string? PathNotepad { get; set; }

    public string? ClassCode { get; set; }
}
