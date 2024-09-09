using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class EdmsBoxTracking
{
    public int Id { get; set; }

    public string? BoxCode { get; set; }

    public string? Action { get; set; }

    public string? Note { get; set; }

    public DateTime? ActionTime { get; set; }

    public string? PositionBox { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public DateTime? UpdatedTime { get; set; }
}
