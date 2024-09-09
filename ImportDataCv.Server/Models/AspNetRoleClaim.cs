using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class AspNetRoleClaim
{
    public decimal Id { get; set; }

    public string? ClaimType { get; set; }

    public string? ClaimValue { get; set; }

    public string RoleId { get; set; } = null!;
}
