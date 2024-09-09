using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class AssetRptBrokenHeader
{
    public int AssetId { get; set; }

    public string? Ticket { get; set; }

    public string? TicketCode { get; set; }

    public string? Branch { get; set; }

    public DateTime? StartTime { get; set; }

    public string? Person { get; set; }

    public string? Note { get; set; }

    public string? AssetStatus { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public bool? IsDeleted { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public string? LogStatus { get; set; }

    public string? ObjActCode { get; set; }

    public string? WorkflowCat { get; set; }
}
