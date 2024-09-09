using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class WorkOsCard
{
    public int CardId { get; set; }

    public string CardCode { get; set; } = null!;

    public string? CardName { get; set; }

    public string? ListCode { get; set; }

    public string? Labels { get; set; }

    public string? Member { get; set; }

    public string? CheckList { get; set; }

    public string? AttachmentList { get; set; }

    public string? CommentList { get; set; }

    public string? Description { get; set; }

    public string? WorkType { get; set; }

    public string? Status { get; set; }

    public string? CardLevel { get; set; }

    public decimal Completed { get; set; }

    public DateTime? CompletedTime { get; set; }

    public decimal Cost { get; set; }

    public string? Currency { get; set; }

    public DateTime Deadline { get; set; }

    public string? Device { get; set; }

    public DateTime BeginTime { get; set; }

    public decimal WeightNum { get; set; }

    public decimal Progress { get; set; }

    public DateTime? EndTime { get; set; }

    public decimal? Quantitative { get; set; }

    public string? Unit { get; set; }

    public string? LstUser { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public bool? IsDeleted { get; set; }

    public string? Inherit { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? ListUserView { get; set; }

    public string? WorkflowCode { get; set; }

    public string? JsonAssign { get; set; }

    public string? JsonStatusLog { get; set; }

    public bool? IsLock { get; set; }

    public string? LockShare { get; set; }

    public bool? IsRecurrent { get; set; }

    public string? Cycle { get; set; }
}
