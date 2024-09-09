using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class HistorySpecialist
{
    public int Id { get; set; }

    public string? MonthYear { get; set; }

    public string? Content { get; set; }

    public string? ProfileCode { get; set; }

    public bool? IsDeleted { get; set; }
}
