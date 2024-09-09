using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class WorkItemAssignStaff
{
    public int Id { get; set; }

    public string? UserId { get; set; }

    public string? ObjectGD { get; set; }

    public string? ObjectType { get; set; }

    public string? CardCode { get; set; }

    public string? CheckItem { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }

    public string? CheckListCode { get; set; }

    public string? EstimateTime { get; set; }

    public string? Unit { get; set; }
}
