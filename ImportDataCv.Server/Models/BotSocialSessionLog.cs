using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class BotSocialSessionLog
{
    public int Id { get; set; }

    public string? BotSession { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public string? Statvs { get; set; }

    public string? BotSocialCode { get; set; }

    public string? FileResults { get; set; }

    public string? RuningType { get; set; }

    public string? BotSessionResult { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public bool? IsDeleted { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }
}
