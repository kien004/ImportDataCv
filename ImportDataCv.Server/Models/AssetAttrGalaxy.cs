using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class AssetAttrGalaxy
{
    public int Id { get; set; }

    public string? AssetCode { get; set; }

    public string? AttrCode { get; set; }

    public string? AttrValue { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime? DeletedTime { get; set; }

    public string? DeletedBy { get; set; }
}
