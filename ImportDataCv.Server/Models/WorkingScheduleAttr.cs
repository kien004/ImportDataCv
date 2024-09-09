using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class WorkingScheduleAttr
{
    public int Id { get; set; }

    public int? WorkingScheduleId { get; set; }

    public string? AttrCode { get; set; }

    public string? AttrGroup { get; set; }

    public string? SessionCode { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }

    public string? Unit { get; set; }

    public string? Type { get; set; }

    public string? Value { get; set; }

    public virtual WorkingSchedule? WorkingSchedule { get; set; }
}
