using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class RmCommonSetting
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Value { get; set; }

    public string? Group { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }
}
