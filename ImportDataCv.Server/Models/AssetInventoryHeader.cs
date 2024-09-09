using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class AssetInventoryHeader
{
    public int AssetId { get; set; }

    public string? TicketCode { get; set; }

    public string? Title { get; set; }

    public string? Branch { get; set; }

    public string? Person { get; set; }

    public string? Note { get; set; }

    public string? Status { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? InventoryTime { get; set; }

    public string? Adress { get; set; }

    public string? LogStatus { get; set; }

    public string? ObjActCode { get; set; }

    public string? WorkflowCat { get; set; }
}
