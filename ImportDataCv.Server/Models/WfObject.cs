using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class WfObject
{
    public int Id { get; set; }

    public string? WfObjCode { get; set; }

    public string? WfObjName { get; set; }

    public string? WfObjType { get; set; }

    public string? WfObjNoted { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }
}
