using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class AssetReqMaintainceReparrHeader
{
    public int Id { get; set; }

    public string? TicketCode { get; set; }

    public string? Title { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? Status { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateTime { get; set; }

    public bool? IsDeleted { get; set; }

    public string? Note { get; set; }

    public string? Reason { get; set; }

    public string? DeleteBy { get; set; }

    public DateTime? DeleteTime { get; set; }

    public string? LogStatus { get; set; }

    public DateTime? ReqTime { get; set; }

    public string? Discription { get; set; }

    public string? UserReq { get; set; }

    public string? Branch { get; set; }

    public string? TicketType { get; set; }

    public string? LocationRepair { get; set; }

    public string? CreateDepart { get; set; }

    public string? ObjActCode { get; set; }

    public string? WorkflowCat { get; set; }
}
