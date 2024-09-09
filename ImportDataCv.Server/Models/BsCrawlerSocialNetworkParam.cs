using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class BsCrawlerSocialNetworkParam
{
    public int Id { get; set; }

    public int? UserName { get; set; }

    public string? Password { get; set; }

    public string? Tocken { get; set; }

    public string? AccSetting { get; set; }

    public string? ListKeyWord { get; set; }

    public string? DataStoragePath { get; set; }

    public string? DeepScan { get; set; }

    public string? ConfigSelectorJson { get; set; }
}
