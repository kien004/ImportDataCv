using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class EdmsEntityMappingAsset
{
    public int Id { get; set; }

    public string? WhsCode { get; set; }

    public string? FloorCode { get; set; }

    public string? LineCode { get; set; }

    public string? RackCode { get; set; }

    public string? RackPosition { get; set; }

    public string? Ordering { get; set; }

    public string? BoxCode { get; set; }
}
