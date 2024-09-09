using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class BwBotInstantDatamining
{
    public int Id { get; set; }

    public string? MachineId { get; set; }

    public string? ChannelId { get; set; }

    public string? ChannelTitle { get; set; }

    public string? Ip { get; set; }

    public DateTime? LastSeen { get; set; }

    public bool? Status { get; set; }

    public bool? Flag { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public string? DeletedBy { get; set; }
}
