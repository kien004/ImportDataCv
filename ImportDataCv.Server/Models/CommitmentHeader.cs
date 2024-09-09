using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class CommitmentHeader
{
    public int Id { get; set; }

    public string? CommitmentCode { get; set; }

    public string? Title { get; set; }

    public string? UserId { get; set; }

    public string? Surrogate { get; set; }

    public string? Status { get; set; }

    public string? Noted { get; set; }

    public DateOnly? StartTime { get; set; }

    public DateOnly? EndTime { get; set; }

    public string? Signature { get; set; }

    public string? FileReference { get; set; }

    public DateOnly? CreateTime { get; set; }

    public string? CreateBy { get; set; }

    public DateOnly? UpdateTime { get; set; }

    public string? UpdateBy { get; set; }

    public string? UserSign { get; set; }

    public string? ListRule { get; set; }

    public bool? Flag { get; set; }
}
