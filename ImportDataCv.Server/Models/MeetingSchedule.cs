using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class MeetingSchedule
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? Comment { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public string? Status { get; set; }

    public string? JsonData { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public bool? IsDeleted { get; set; }

    public string? AccountZoom { get; set; }

    public string? ListUserApproved { get; set; }

    public string? JsonStatus { get; set; }

    public string? BackgroundColor { get; set; }

    public string? BackgroundImage { get; set; }

    public string? JsonRef { get; set; }

    public int? MeetingId { get; set; }

    public string? JsonCanvas { get; set; }
}
