using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class WorkItemSession
{
    public int Id { get; set; }

    public string? WorkSession { get; set; }

    public string? ItemWorkList { get; set; }

    public string? Note { get; set; }

    public string? Status { get; set; }

    public decimal? Progress { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool IsDeleted { get; set; }

    public string? CardCode { get; set; }

    public string? ShiftCode { get; set; }
}
