using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class CrawlerDomainConfigurationParam
{
    public int Id { get; set; }

    public string? Url { get; set; }

    public bool? DownloadFile { get; set; }

    public string? KeyWord { get; set; }

    public string? DataStorage { get; set; }

    public int? DomainId { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public bool? IsDeleted { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }
}
