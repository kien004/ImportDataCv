using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class WorkFlow
{
    public int Id { get; set; }

    public string? WfCode { get; set; }

    public string? WfName { get; set; }

    public string? WfNote { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }

    public string? WfGroup { get; set; }

    public string? WfType { get; set; }

    public bool? IsPublic { get; set; }

    public string? PublicBy { get; set; }

    public DateTime? PublicTime { get; set; }

    public string? ObjectType { get; set; }

    public string? UserList { get; set; }

    public string? ObjectCategory { get; set; }

    public string? ShapeJson { get; set; }
}
