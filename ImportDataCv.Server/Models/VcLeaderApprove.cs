using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class VcLeaderApprove
{
    public int Id { get; set; }

    public string WpCode { get; set; } = null!;

    public string? Status { get; set; }

    public string? Note { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime CreatedTime { get; set; }
}
