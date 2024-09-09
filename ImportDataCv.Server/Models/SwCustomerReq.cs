using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class SwCustomerReq
{
    public int Id { get; set; }

    public string? ReqCode { get; set; }

    public string? PartnerKey { get; set; }

    public string? CompanyName { get; set; }

    public string? Tel { get; set; }

    public string? Email { get; set; }

    public string? Logo { get; set; }

    public string? Slogan { get; set; }

    public string? Noted { get; set; }

    public string? MonthTried { get; set; }

    public string? PurchaseOption { get; set; }

    public string? Background { get; set; }

    public string? RequestTitle { get; set; }

    public string? HostingServer { get; set; }

    public string? DatabaseServer { get; set; }

    public string? Domain { get; set; }

    public string? FileUrl { get; set; }

    public string? Status { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }
}
