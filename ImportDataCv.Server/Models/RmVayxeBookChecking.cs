using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class RmVayxeBookChecking
{
    public int Id { get; set; }

    public int? NumChk { get; set; }

    public string? TitleChk { get; set; }

    public string? Note { get; set; }

    public DateTime? NextChkTime { get; set; }

    public int? Status { get; set; }

    public DateTime? CreatedTime { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public int? ClientId { get; set; }

    public string? LicensePlate { get; set; }

    public int? ApproverId { get; set; }

    public string? BookChkCode { get; set; }

    public int? BlockId { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public bool? IsDeleted { get; set; }

    public string? VendorCode { get; set; }
}
