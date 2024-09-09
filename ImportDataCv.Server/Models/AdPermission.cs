using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class AdPermission
{
    public string? ApplicationCode { get; set; }

    public string? FunctionCode { get; set; }

    public string? ResourceCode { get; set; }

    public string? GroupUserCode { get; set; }

    public string? UserId { get; set; }

    public string? RoleId { get; set; }

    public DateTime? ExpiredDate { get; set; }

    public int PermissionId { get; set; }
}
