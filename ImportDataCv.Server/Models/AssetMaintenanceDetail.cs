using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class AssetMaintenanceDetail
{
    public int AssetId { get; set; }

    public string? AssetCode { get; set; }

    public long? TotalMoney { get; set; }

    public string? ListImage { get; set; }

    public string? StatusAsset { get; set; }

    public string? Note { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }

    public string? TicketCode { get; set; }

    public string? UserAsset { get; set; }

    public int? AssetQuantity { get; set; }
}
