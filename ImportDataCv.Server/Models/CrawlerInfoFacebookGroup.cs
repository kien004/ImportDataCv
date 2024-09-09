﻿using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class CrawlerInfoFacebookGroup
{
    public int Id { get; set; }

    public string? GroupId { get; set; }

    public string? GroupName { get; set; }

    public int? MemberCount { get; set; }

    public int? FrequencyPost { get; set; }

    public string? FrequencyType { get; set; }

    public string? TypeGroup { get; set; }

    public string? Summary { get; set; }

    public int? MutualFriend { get; set; }

    public bool? IsPermission { get; set; }

    public bool? IsJoin { get; set; }

    public DateTime? CreatedTime { get; set; }

    public bool IsDeleted { get; set; }

    public string? OwnedBot { get; set; }
}
