using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class AssetTransferHeader
{
    public int AssetId { get; set; }

    public string? Ticketcode { get; set; }

    public string? Ticket { get; set; }

    public string? DepartTransf { get; set; }

    public string? UserTransf { get; set; }

    public string? LocationTransf { get; set; }

    public DateTime? StartTime { get; set; }

    public string? DepartReceived { get; set; }

    public string? UserReceived { get; set; }

    public DateTime? ReceivedTime { get; set; }

    public string? ReceivedLocation { get; set; }

    public string? Status { get; set; }

    public string? Note { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public bool? IsDeleted { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public string? LogStatus { get; set; }

    public string? ObjActCode { get; set; }

    public string? Qrcode { get; set; }

    public string? WorkflowCat { get; set; }
}
