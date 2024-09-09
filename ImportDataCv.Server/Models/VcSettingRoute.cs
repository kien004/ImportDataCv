using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class VcSettingRoute
{
    public int Id { get; set; }

    public string RouteCode { get; set; } = null!;

    public string WpCode { get; set; } = null!;

    public string Node { get; set; } = null!;

    public DateTime? TimeWork { get; set; }

    public string? Note { get; set; }

    public int? Order { get; set; }

    public DateTime? TimePlan { get; set; }

    public string? CurrentStatus { get; set; }

    public decimal? Proportion { get; set; }

    public decimal? TotalCanImp { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool IsDeleted { get; set; }
}
