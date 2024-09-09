using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class OperationOnlineSupportTracking
{
    public int Id { get; set; }

    public string? SvrSession { get; set; }

    public string? Caller { get; set; }

    public string? Receiver { get; set; }

    public DateTime? StartedTime { get; set; }

    public DateTime? EndedTime { get; set; }

    public string? SvrLocation { get; set; }
}
