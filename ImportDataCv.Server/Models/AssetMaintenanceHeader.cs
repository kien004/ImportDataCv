using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class AssetMaintenanceHeader
{
    public int TicketId { get; set; }

    public string? TicketCode { get; set; }

    public string? Title { get; set; }

    public string? Branch { get; set; }

    public string? DepartTransfer { get; set; }

    public string? UserTransfer { get; set; }

    public DateTime? StartTime { get; set; }

    public string? LocationTransfer { get; set; }

    public string? UnitMaintenance { get; set; }

    public DateTime? ReceivedTime { get; set; }

    public string? LocationReceived { get; set; }

    public string? Status { get; set; }

    public string? Qrcode { get; set; }

    public string? LogStatus { get; set; }

    public string? Note { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }

    public string? ObjActCode { get; set; }

    public int? TotalMoney { get; set; }

    public string? Currency { get; set; }

    public string? WorkflowCat { get; set; }

    public string? JsonData { get; set; }
}
