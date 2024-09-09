using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class ItemPlanJobcard
{
    public int Id { get; set; }

    public string? ItemCode { get; set; }

    public string? JobcardCode { get; set; }

    public decimal? Weight { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }
}
