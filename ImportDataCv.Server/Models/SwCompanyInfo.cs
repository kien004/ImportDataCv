using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class SwCompanyInfo
{
    public int Id { get; set; }

    public string? ReqCode { get; set; }

    public string? CompanyName { get; set; }

    public string? Logo { get; set; }

    public string? Background { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }
}
