using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class IotSetUpAlert
{
    public int Id { get; set; }

    public DateTime? FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    public string? Device { get; set; }

    public string? Unit { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }
}
