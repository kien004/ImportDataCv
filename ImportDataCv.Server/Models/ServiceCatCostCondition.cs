using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class ServiceCatCostCondition
{
    public int Id { get; set; }

    public string? HeaderCode { get; set; }

    public string? ServiceCatCode { get; set; }

    public string? ObjectCode { get; set; }

    public string? ObjFromValue { get; set; }

    public string? ObjToValue { get; set; }

    public string? Unit { get; set; }

    public decimal? Price { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public bool? IsDeleted { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public decimal? Rate { get; set; }

    public string? Currency { get; set; }

    public string? ServiceUnit { get; set; }
}
