using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class BwCrawlerDomainParam
{
    public int Id { get; set; }

    public string? DomainIp { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public string? Tocken { get; set; }

    public string? ListKeyword { get; set; }

    public string? DataStorageParam { get; set; }

    public int? DeepScan { get; set; }

    public string? ConfigSelectorJson { get; set; }
}
