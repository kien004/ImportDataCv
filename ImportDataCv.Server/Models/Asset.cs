using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class Asset
{
    public int AssetId { get; set; }

    public string? AssetCode { get; set; }

    public string? AssetName { get; set; }

    public string? AssetType { get; set; }

    public string? AssetGroup { get; set; }

    public string? Description { get; set; }

    public string? PathImg { get; set; }

    public string? Status { get; set; }

    public DateTime? BuyedTime { get; set; }

    public DateTime? ExpiredDate { get; set; }

    public string? Cost { get; set; }

    public string? Currency { get; set; }

    public string? SupplierCode { get; set; }

    public string? LocationText { get; set; }

    public string? LocationGps { get; set; }

    public DateTime? ExpireDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool IsDeleted { get; set; }
}
