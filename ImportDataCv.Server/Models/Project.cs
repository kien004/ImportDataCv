using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class Project
{
    public int Id { get; set; }

    public string? ProjectCode { get; set; }

    public string? ProjectTitle { get; set; }

    public double? Budget { get; set; }

    public string? Currency { get; set; }

    public string? PrjSkillKeyword { get; set; }

    public string? PrjStatus { get; set; }

    public double? SetPriority { get; set; }

    public string? PrjMode { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime EndTime { get; set; }

    public int? Version { get; set; }

    public string? Language { get; set; }

    public string? PrjType { get; set; }

    public string? CaseWorker { get; set; }

    public decimal? Completed { get; set; }

    public string? GoogleMap { get; set; }

    /// <summary>
    /// Address
    /// </summary>
    public string? Address { get; set; }

    public string? CustomerCode { get; set; }

    public string? SupplierCode { get; set; }

    public string? Status { get; set; }

    public string? ListUserView { get; set; }

    public string? WorkflowCat { get; set; }

    public string? StatusObject { get; set; }

    public string? StatusObjectLog { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public bool FlagDeleted { get; set; }

    public string? JsonStatus { get; set; }
}
