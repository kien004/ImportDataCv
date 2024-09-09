using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class AssetBuyHeader
{
    public int Id { get; set; }

    public string? TicketCode { get; set; }

    public string? Title { get; set; }

    public string? Note { get; set; }

    public string? Status { get; set; }

    public string? Branch { get; set; }

    public string? Buyer { get; set; }

    public string? Location { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public bool? IsDeleted { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public string? ObjActCode { get; set; }

    public DateTime? BuyTime { get; set; }

    public int? TotalMoney { get; set; }

    public string? Depart { get; set; }

    public string? Currency { get; set; }

    public string? WorkflowCat { get; set; }

    public string? JsonData { get; set; }
}
