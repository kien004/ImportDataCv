using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class AssetReqMaintainceReparrDetail
{
    public int? CostValue { get; set; }

    public int? Quantity { get; set; }

    public string? TicketCode { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateTime { get; set; }

    public string? DeleteBy { get; set; }

    public DateTime? DeleteTime { get; set; }

    public int Id { get; set; }

    public bool? IsDeleted { get; set; }

    public string? Note { get; set; }

    public string? AssetCode { get; set; }

    public string? StatusAsset { get; set; }

    public string? TicketType { get; set; }

    public string? AssetType { get; set; }

    public string? Property { get; set; }

    public string? AssetName { get; set; }
}
