using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class EdmsRequestTracking
{
    public int Id { get; set; }

    public string? Reason { get; set; }

    public string? BrCode { get; set; }

    public int? RqId { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool IsDeleted { get; set; }

    public string? RqStatus { get; set; }
}
