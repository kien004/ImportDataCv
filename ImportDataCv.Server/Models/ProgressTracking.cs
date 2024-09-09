using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class ProgressTracking
{
    public int Id { get; set; }

    public string? CardCode { get; set; }

    public decimal? Progress { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }
}
