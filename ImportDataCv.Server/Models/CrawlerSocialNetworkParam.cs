using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class CrawlerSocialNetworkParam
{
    public int Id { get; set; }

    public int? AccSettingId { get; set; }

    public string? ParamJsonContent { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public bool? IsDeleted { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }
}
