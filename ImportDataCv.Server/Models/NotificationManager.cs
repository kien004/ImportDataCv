using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class NotificationManager
{
    public int Id { get; set; }

    public string? NotifyCode { get; set; }

    public string? Title { get; set; }

    public string? ObjType { get; set; }

    public string? ObjCode { get; set; }

    public string? JsonData { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool IsDeleted { get; set; }
}
