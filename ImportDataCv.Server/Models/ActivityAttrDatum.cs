using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class ActivityAttrDatum
{
    public int Id { get; set; }

    public string? AttrCode { get; set; }

    public string? Value { get; set; }

    public string? ActCode { get; set; }

    public string? Description { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }

    public string? Note { get; set; }

    public string? WorkFlowCode { get; set; }

    public string? ObjCode { get; set; }

    public string? SessionId { get; set; }

    public string? FilePath { get; set; }
}
