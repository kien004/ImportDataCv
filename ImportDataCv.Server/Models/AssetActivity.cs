using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class AssetActivity
{
    public string? ActCode { get; set; }

    public string? ActTitle { get; set; }

    public string? ActType { get; set; }

    public string? ActNote { get; set; }

    public string? ActMember { get; set; }

    public int? ParentCode { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool IsDeleted { get; set; }

    public int ActivityId { get; set; }

    public string? AssetCode { get; set; }
}
