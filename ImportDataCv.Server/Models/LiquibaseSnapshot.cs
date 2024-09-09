using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class LiquibaseSnapshot
{
    public string? CurrentSnapshot { get; set; }

    public string? PreviousSnapshot { get; set; }

    public string? Type { get; set; }
}
