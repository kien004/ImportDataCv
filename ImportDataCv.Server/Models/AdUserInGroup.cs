using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class AdUserInGroup
{
    public int UserInGroupId { get; set; }

    public string? GroupUserCode { get; set; }

    public string? UserId { get; set; }

    public string? RoleId { get; set; }

    public bool? GrantAll { get; set; }

    public bool? IsMain { get; set; }

    public string? BranchReference { get; set; }

    public string? ApplicationCode { get; set; }

    public bool? IsDeleted { get; set; }

    public string? Branch { get; set; }
}
