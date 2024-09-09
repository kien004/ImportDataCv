using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class MrpPumpItemDt
{
    public int Id { get; set; }

    public string? SessionCode { get; set; }

    public string? Item { get; set; }

    public decimal? Quantity { get; set; }

    public string? Unit { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }
}
