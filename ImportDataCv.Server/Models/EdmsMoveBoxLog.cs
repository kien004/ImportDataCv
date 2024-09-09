using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class EdmsMoveBoxLog
{
    public int Id { get; set; }

    public string? BoxCode { get; set; }

    public string? RackCodeOld { get; set; }

    public string? RackCodeNew { get; set; }

    public string? RackPosition { get; set; }

    public string? Ordering { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime CreatedTime { get; set; }

    public string? Note { get; set; }
}
