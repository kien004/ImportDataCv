using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class AspNetUserClaim
{
    public decimal Id { get; set; }

    public string? ClaimType { get; set; }

    public string? ClaimValue { get; set; }

    public string UserId { get; set; } = null!;
}
