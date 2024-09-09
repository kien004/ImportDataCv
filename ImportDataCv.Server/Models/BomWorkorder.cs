using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class BomWorkorder
{
    public int Id { get; set; }

    public string? WorkorderCode { get; set; }

    public string? WorkorderTitle { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public string? Status { get; set; }

    public string? Node { get; set; }

    public string? Creator { get; set; }

    public string? OperatingCode { get; set; }

    public decimal? Progress { get; set; }

    public string? WfInstCode { get; set; }

    public string? LotCode { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }
}
