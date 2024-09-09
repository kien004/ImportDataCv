using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class AssetRecalledHeader
{
    public int Id { get; set; }

    public string? TicketCode { get; set; }

    public string? Title { get; set; }

    public string? Status { get; set; }

    public string? BranchRecalled { get; set; }

    public string? UserRecalled { get; set; }

    public DateTime? RecalledTime { get; set; }

    public string? LocationRecalled { get; set; }

    public string? Description { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public string? UserConfirm { get; set; }

    public bool? IsDeleted { get; set; }

    public string? LogStatus { get; set; }

    public string? ObjActCode { get; set; }

    public string? WorkflowCat { get; set; }
}
