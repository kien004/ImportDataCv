using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class ProjectService
{
    public int Id { get; set; }

    public string? ServiceCode { get; set; }

    public decimal? Quantity { get; set; }

    public string? Unit { get; set; }

    public string? Level { get; set; }

    public string? DurationTime { get; set; }

    public string? Status { get; set; }

    public string? Note { get; set; }

    public string? ProjectCode { get; set; }
}
