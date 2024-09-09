using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class ReminderAttr
{
    public int Id { get; set; }

    public string? ReminderCode { get; set; }

    public string? ReminderTitle { get; set; }

    public string? Note { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }
}
