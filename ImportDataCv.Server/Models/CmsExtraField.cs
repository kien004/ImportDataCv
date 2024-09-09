using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class CmsExtraField
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Value { get; set; }

    public string? Type { get; set; }

    public int? Group { get; set; }

    public bool? Published { get; set; }

    public int? Ordering { get; set; }
}
