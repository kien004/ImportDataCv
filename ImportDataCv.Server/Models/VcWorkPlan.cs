using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class VcWorkPlan
{
    public int Id { get; set; }

    public string WpCode { get; set; } = null!;

    public string UserName { get; set; } = null!;

    public DateTime FromDate { get; set; }

    public DateTime ToDate { get; set; }

    public int? WeekNo { get; set; }

    public string? Description { get; set; }

    public string? CurrentStatus { get; set; }

    public string? LeaderIdea { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool IsDeleted { get; set; }

    public string? ApprovedBy { get; set; }

    public DateTime? ApprovedTime { get; set; }
}
