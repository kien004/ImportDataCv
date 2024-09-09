using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class AssetLiquidationHeader
{
    public int Id { get; set; }

    public string? TicketCode { get; set; }

    public string? Title { get; set; }

    public string? BranchLiquidation { get; set; }

    public DateTime? LiquidationTime { get; set; }

    public string? UserLiquidation { get; set; }

    public string? LocationLiquidation { get; set; }

    public string? Status { get; set; }

    public string? LogStatus { get; set; }

    public string? Description { get; set; }

    public string? UserBuy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public string? DeletedBy { get; set; }

    public bool? IsDeleted { get; set; }

    public string? ObjActCode { get; set; }

    public string? WorkflowCat { get; set; }
}
