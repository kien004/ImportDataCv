using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class AdAccessLog
{
    public decimal AccessLogId { get; set; }

    public string? AccessLogCode { get; set; }

    public string? Action { get; set; }

    public string? Description { get; set; }

    public string? UserId { get; set; }

    public string? AccessLogApplication { get; set; }

    public DateTime? AccessDate { get; set; }

    public string? IpAddress { get; set; }
}
