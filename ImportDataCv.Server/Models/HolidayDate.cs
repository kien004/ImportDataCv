using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class HolidayDate
{
    public int Id { get; set; }

    public DateTime CalendarDay { get; set; }

    public DateTime LunarDay { get; set; }

    public int DayOfWeek { get; set; }

    public string? Note { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public bool IsDeleted { get; set; }
}
