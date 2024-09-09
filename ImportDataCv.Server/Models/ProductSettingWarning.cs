using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class ProductSettingWarning
{
    public int Id { get; set; }

    public string? ProductCode { get; set; }

    public decimal? MinValue { get; set; }

    public decimal? MaxValue { get; set; }

    public DateTime? MinTime { get; set; }

    public DateTime? MaxTime { get; set; }

    public decimal? CurrentQuantity { get; set; }

    public bool? Flag { get; set; }

    public string? WarningType { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public string? DeletedBy { get; set; }

    public bool? IsDeleted { get; set; }
}
