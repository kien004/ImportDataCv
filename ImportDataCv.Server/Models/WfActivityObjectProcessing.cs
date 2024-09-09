using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class WfActivityObjectProcessing
{
    public int Id { get; set; }

    public string? ActInstCode { get; set; }

    public string? ObjectType { get; set; }

    public string? ObjectInst { get; set; }

    public bool? Beshare { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }

    public bool? ObjEntry { get; set; }

    public string? WfInstCode { get; set; }

    public bool? IsLeader { get; set; }
}
