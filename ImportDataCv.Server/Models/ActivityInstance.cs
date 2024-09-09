using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class ActivityInstance
{
    public int Id { get; set; }

    public string? ActivityCode { get; set; }

    public string? Title { get; set; }

    public decimal? Duration { get; set; }

    public string? Unit { get; set; }

    public string? Located { get; set; }

    public string? Status { get; set; }

    public string? Desc { get; set; }

    public string? ShapeJson { get; set; }

    public string? Group { get; set; }

    public string? Type { get; set; }

    public string? WorkflowCode { get; set; }

    public string? ActivityInstCode { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public string? LogCountDown { get; set; }

    public string? LockShare { get; set; }

    public string? WfInstRelative { get; set; }

    public string? JsonStatusLog { get; set; }

    public string? BomStatus { get; set; }

    public string? BomStatusJson { get; set; }

    public string? Image { get; set; }

    public decimal? BomIn { get; set; }

    public decimal? BomOut { get; set; }

    public string? ObjectType { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }
}
