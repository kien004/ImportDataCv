using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class CrawlerSessionContentResult
{
    public int Id { get; set; }

    public string? BotCode { get; set; }

    public string? SessionCode { get; set; }

    public string? LinkPost { get; set; }

    public string? TextContent { get; set; }

    public string MediaCrawl { get; set; } = null!;

    public string? KeyWord { get; set; }

    public string? KeyWordJson { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public string? IsDeleted { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }
}
