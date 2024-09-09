using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class AspNetRoleDeploy
{
    public string Id { get; set; } = null!;

    public string ReqCode { get; set; } = null!;

    public string? ConcurrencyStamp { get; set; }

    public string? Name { get; set; }

    public string? NormalizedName { get; set; }

    public string? Code { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public int? Ord { get; set; }

    public bool Status { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? Priority { get; set; }

    public string? Color { get; set; }

    public string? Type { get; set; }

    public string? TypeRole { get; set; }
}
