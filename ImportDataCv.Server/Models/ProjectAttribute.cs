using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class ProjectAttribute
{
    public int Id { get; set; }

    public string? ProjectCode { get; set; }

    public string AttrCode { get; set; } = null!;

    public string? AttrValue { get; set; }

    public string? AttrGroup { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }
}
