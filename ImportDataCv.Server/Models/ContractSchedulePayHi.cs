using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class ContractSchedulePayHi
{
    /// <summary>
    /// Customer Id
    /// </summary>
    public int Id { get; set; }

    public string? ContractCode { get; set; }

    public int? PayTimes { get; set; }

    public int? Percentage { get; set; }

    public double? Money { get; set; }

    public DateTime? EstimateTime { get; set; }

    public string? Note { get; set; }

    public string? Condition { get; set; }

    public double? Quantity { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool IsDeleted { get; set; }

    public int? ContractVersion { get; set; }
}
