using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class BomItemConsumption
{
    public int Id { get; set; }

    public string? BomRtId { get; set; }

    public string? ItemCode { get; set; }

    public decimal? Qty { get; set; }

    public string? Unit { get; set; }

    public string? Specification { get; set; }

    public string? ActivityCode { get; set; }

    public string? SessionNum { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }
}
