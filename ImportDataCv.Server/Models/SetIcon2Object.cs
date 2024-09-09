using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class SetIcon2Object
{
    public int Id { get; set; }

    public string? IconCode { get; set; }

    public string? IconTitle { get; set; }

    public string? IconPath { get; set; }

    public string? ObjectCode { get; set; }

    public string? ExpFilterSql { get; set; }
}
