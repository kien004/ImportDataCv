using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class OrderRequestRaw275
{
    public int Id { get; set; }

    public string ReqCode { get; set; } = null!;

    public string? Title { get; set; }

    public string? Content { get; set; }

    public string? Ip { get; set; }

    public string? Device { get; set; }

    public int? Priority { get; set; }

    public string? RequestType { get; set; }

    public DateTime? RequestTime { get; set; }

    public string? Status { get; set; }

    public string? Keyword { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }
}
