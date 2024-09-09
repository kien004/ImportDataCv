using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class AssetCancelDetail
{
    public int AssetId { get; set; }

    public string? TicketCode { get; set; }

    public string? AssetName { get; set; }

    public string? AssetUnit { get; set; }

    public string? StatusAsset { get; set; }

    public string? Title { get; set; }

    public int? QuantityAsset { get; set; }

    public decimal? Cost { get; set; }

    public string? ListImage { get; set; }

    public string? Note { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }

    public string? Adress { get; set; }

    public DateTime? CancelTime { get; set; }

    public string? DeletedBy { get; set; }
}
