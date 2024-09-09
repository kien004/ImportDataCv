using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class BwWebrtcChannelControl
{
    public int Id { get; set; }

    public string? ChannelId { get; set; }

    public bool? Status { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? UpdatedBy { get; set; }
}
