using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class ObjectiverPackCover
{
    public int Id { get; set; }

    public string? ObjPackCode { get; set; }

    public string? Name { get; set; }

    public string? SpecSize { get; set; }

    public string? Weight { get; set; }

    public string? Unit { get; set; }

    public string? Located { get; set; }

    public string? ParentCode { get; set; }

    public string? Description { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool IsDeleted { get; set; }

    public string? ShapeData { get; set; }
}
