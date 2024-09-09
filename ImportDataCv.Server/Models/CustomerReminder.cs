using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class CustomerReminder
{
    public int Id { get; set; }

    public int? CustomerId { get; set; }

    public string? ReminderCode { get; set; }

    public DateTime? ReminderTime { get; set; }

    public string? Note { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }
}
