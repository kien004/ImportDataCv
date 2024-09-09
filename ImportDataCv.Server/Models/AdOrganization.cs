using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class AdOrganization
{
    public int OrgId { get; set; }

    public string OrgAddonCode { get; set; } = null!;

    public int? OrgGroup { get; set; }

    public string? OrgCode { get; set; }

    public string? OrgName { get; set; }

    public decimal? OrgOrd { get; set; }

    public string? OrgParentCode { get; set; }

    public string? OrgUpdateTime { get; set; }

    public string? Company { get; set; }

    public string? Country { get; set; }

    public string? State { get; set; }

    public string? HierarchyCode { get; set; }

    public string? Division { get; set; }

    public bool IsEnabled { get; set; }

    public string? DepartmentCode { get; set; }
}
