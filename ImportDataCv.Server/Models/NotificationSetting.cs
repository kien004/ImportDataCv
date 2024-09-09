using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class NotificationSetting
{
    public int Id { get; set; }

    public string? NotifyCode { get; set; }

    public string? Title { get; set; }

    public string? Body { get; set; }

    public bool? Active { get; set; }

    public int? Interval { get; set; }

    public string? Unit { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateTime { get; set; }

    public string? DeleteBy { get; set; }

    public DateTime? DeleteTime { get; set; }

    public bool? IsDelete { get; set; }
}
