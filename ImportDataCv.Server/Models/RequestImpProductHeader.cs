using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class RequestImpProductHeader
{
    public int Id { get; set; }

    public string? ReqCode { get; set; }

    public string? Title { get; set; }

    public string? PoCode { get; set; }

    public string? Status { get; set; }

    public DateTime? TimeTicketCreate { get; set; }

    public string? UserRequest { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? ApprovedBy { get; set; }

    public DateTime? ApprovedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }

    public string? CusCode { get; set; }

    public string? ProjectCode { get; set; }

    public string? WorkflowCat { get; set; }

    public string? JsonData { get; set; }

    public string? StatusObject { get; set; }

    public string? StatusObjectLog { get; set; }

    public string? LogData { get; set; }

    public string? LogProductDetail { get; set; }
}
