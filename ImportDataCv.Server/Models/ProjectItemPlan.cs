using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class ProjectItemPlan
{
    public int Id { get; set; }

    public string ItemCode { get; set; } = null!;

    public string? ItemName { get; set; }

    public string? ItemLevel { get; set; }

    public decimal? ItemWeight { get; set; }

    public decimal? Completed { get; set; }

    public string? ItemParent { get; set; }

    public string? DurationTime { get; set; }

    public string? DurationUnit { get; set; }

    public string? Cost { get; set; }

    public string? CostUnit { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }

    public string? ProjectCode { get; set; }

    public string? Note { get; set; }
}
