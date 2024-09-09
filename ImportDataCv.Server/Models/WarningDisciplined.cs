using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class WarningDisciplined
{
    public int Id { get; set; }

    public string? MonthYear { get; set; }

    public string? Reason { get; set; }

    /// <summary>
    /// Cấp quyết định
    /// </summary>
    public string? GrantOfDecision { get; set; }

    public string? ProfileCode { get; set; }

    public bool? IsDeleted { get; set; }
}
