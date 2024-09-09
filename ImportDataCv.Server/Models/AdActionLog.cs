using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class AdActionLog
{
    public int ActionLogId { get; set; }

    public string? LogLevel { get; set; }

    public string? ActionLogApplication { get; set; }

    public string? ActionLogHost { get; set; }

    public string? ActionLogPath { get; set; }

    public string? ResourceName { get; set; }

    public string? Message { get; set; }

    public string? Browser { get; set; }

    public string? IpAddress { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? TableModified { get; set; }

    public string? DataNew { get; set; }

    public string? DataOld { get; set; }

    public string? AffectedTo { get; set; }
}
