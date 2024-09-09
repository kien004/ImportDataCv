using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class CrawlerJobSchedule
{
    public int Id { get; set; }

    public string? JobScCode { get; set; }

    public string? JobScTitle { get; set; }

    public string? JobScType { get; set; }

    public string? JobScRunTime { get; set; }

    public string? JobScDesc { get; set; }

    public string? Status { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdateTime { get; set; }

    public bool? IsDeleted { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public string? BotCode { get; set; }
}
