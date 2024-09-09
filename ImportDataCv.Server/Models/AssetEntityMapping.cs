using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class AssetEntityMapping
{
    public int Id { get; set; }

    public string? WhsCode { get; set; }

    public string? FloorCode { get; set; }

    public string? LineCode { get; set; }

    public string? RackCode { get; set; }

    public string? RackPosition { get; set; }

    public string? Ordering { get; set; }

    public string? ProductQrCode { get; set; }

    public bool IsDeleted { get; set; }

    public decimal? Quantity { get; set; }

    public string? Unit { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? AssetCode { get; set; }
}
