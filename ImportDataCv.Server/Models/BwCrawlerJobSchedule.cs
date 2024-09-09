using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class BwCrawlerJobSchedule
{
    public int Id { get; set; }

    public string? JobScCode { get; set; }

    public string? JobScTitle { get; set; }

    public string? JobScType { get; set; }

    public string? JobScRunTime { get; set; }

    public string? JobScDesc { get; set; }

    public string? Status { get; set; }

    public string? BotCode { get; set; }
}
