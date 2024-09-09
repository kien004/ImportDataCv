using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class WorkingSchedule
{
    public int Id { get; set; }

    public string? Content { get; set; }

    public string? WorkContent { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? Location { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }

    public string? ListUserApproved { get; set; }

    public string? JsonStatus { get; set; }

    public string? BackgroundColor { get; set; }

    public string? BackgroundImage { get; set; }

    public string? JsonRef { get; set; }

    public string? Type { get; set; }

    public string? Status { get; set; }

    public virtual ICollection<WorkingScheduleAttr> WorkingScheduleAttrs { get; set; } = new List<WorkingScheduleAttr>();
}
