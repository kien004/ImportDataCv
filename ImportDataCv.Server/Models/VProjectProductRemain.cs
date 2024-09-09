using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class VProjectProductRemain
{
    public Guid? Id { get; set; }

    public string? ProductCode { get; set; }

    public string? ProductName { get; set; }

    public string? Unit { get; set; }

    public string? UnitName { get; set; }

    public string? ProjectCode { get; set; }

    public string? ProjectTitle { get; set; }

    public decimal? TotalRemain { get; set; }
}
