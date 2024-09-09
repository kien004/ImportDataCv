using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class DecisionMovementHeader
{
    public int Id { get; set; }

    public string? DecisionNum { get; set; }

    public string? Title { get; set; }

    public string? WorkflowCat { get; set; }

    public string? Status { get; set; }

    public string? Noted { get; set; }

    public string? JsonData { get; set; }

    public string? StatusLog { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool IsDeleted { get; set; }
}
