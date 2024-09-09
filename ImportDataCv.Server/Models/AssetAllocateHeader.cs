using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class AssetAllocateHeader
{
    public int Id { get; set; }

    public string? TicketCode { get; set; }

    public string? Title { get; set; }

    public string? DepartmentSend { get; set; }

    public string? UserAllocate { get; set; }

    public string? LocationSend { get; set; }

    public DateTime? AllocateTime { get; set; }

    public string? UserReceiver { get; set; }

    public string? DepartmentReceive { get; set; }

    public string? Note { get; set; }

    public string? Status { get; set; }

    public string? LogStatus { get; set; }

    public bool? IsDeleted { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public string? ObjActCode { get; set; }

    public string? WorkflowCat { get; set; }

    public string? QrCode { get; set; }
}
