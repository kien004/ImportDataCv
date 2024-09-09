using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class ZoomReportError
{
    public int Id { get; set; }

    public string? ErrorContent { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }
}
