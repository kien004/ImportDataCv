using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class LmsMsgNotification
{
    public int Id { get; set; }

    public string? MsgContent { get; set; }

    public string? MsgType { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public bool? IsEnabled { get; set; }

    public bool? IsDeleted { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }
}
