using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class NotificationObject
{
    public int Id { get; set; }

    public string? ObjType { get; set; }

    public string? ObjCode { get; set; }

    public bool? IsViewed { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public bool? IsDeleted { get; set; }

    public string? ListUser { get; set; }
}
