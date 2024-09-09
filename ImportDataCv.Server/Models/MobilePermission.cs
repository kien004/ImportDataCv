using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class MobilePermission
{
    public string? ApplicationCode { get; set; }

    public string? FunctionCode { get; set; }

    public string? ResourceCode { get; set; }

    public string? GroupUserCode { get; set; }

    public string? UserId { get; set; }

    public string? RoleId { get; set; }

    public DateTime? ExpiredDate { get; set; }

    public int PermissionId { get; set; }

    public string? Json { get; set; }

    public virtual MobileFunction? FunctionCodeNavigation { get; set; }

    public virtual AdGroupUser? GroupUserCodeNavigation { get; set; }

    public virtual MobileResource? ResourceCodeNavigation { get; set; }

    public virtual AspNetRole? Role { get; set; }
}
