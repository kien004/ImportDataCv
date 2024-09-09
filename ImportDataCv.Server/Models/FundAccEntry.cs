using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class FundAccEntry
{
    public int Id { get; set; }

    public string AetCode { get; set; } = null!;

    public string? Title { get; set; }

    public string? AetType { get; set; }

    public string? AetDescription { get; set; }

    public bool? IsPlan { get; set; }

    public string? CatCode { get; set; }

    public DateTime? DeadLine { get; set; }

    public string? AetRelative { get; set; }

    public string? AetRelativeType { get; set; }

    public string? Payer { get; set; }

    public string? Receiptter { get; set; }

    public decimal? Total { get; set; }

    public string? Currency { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool IsDeleted { get; set; }

    public string? GoogleMap { get; set; }

    public string? Address { get; set; }

    /// <summary>
    /// CREATED,CANCEL,PENDING,REFUSE,ACCEPT
    /// </summary>
    public string? Status { get; set; }

    public string? LogData { get; set; }

    public bool? IsCompleted { get; set; }

    public string? ObjCode { get; set; }

    public string? ObjType { get; set; }

    public string? WorkflowCat { get; set; }

    public string? StatusObject { get; set; }

    public string? StatusObjectLog { get; set; }

    public string? JsonStatus { get; set; }
}
