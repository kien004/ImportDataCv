using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class CompanyScheduleWork
{
    public int Id { get; set; }

    public string? UserName { get; set; }

    public TimeOnly? FromMorning { get; set; }

    public TimeOnly? ToMorning { get; set; }

    public TimeOnly? FromAfternoon { get; set; }

    public TimeOnly? ToAfternoon { get; set; }

    public TimeOnly? FromEvening { get; set; }

    public TimeOnly? ToEvening { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool IsDeleted { get; set; }
}
