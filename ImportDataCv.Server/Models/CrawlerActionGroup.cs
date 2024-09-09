using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class CrawlerActionGroup
{
    public int Id { get; set; }

    public string? GroupId { get; set; }

    public string? PostId { get; set; }

    public bool? IsOwned { get; set; }

    public DateTime? CreatedTime { get; set; }
}
