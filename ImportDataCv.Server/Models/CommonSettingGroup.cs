using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class CommonSettingGroup
{
    public int Id { get; set; }

    public string? GroupCode { get; set; }

    public string? GroupName { get; set; }
}
