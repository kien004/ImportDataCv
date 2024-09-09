using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class DecisionMovementDetail
{
    public int Id { get; set; }

    public string? EmployeesCode { get; set; }

    public string? DecisionNum { get; set; }

    public string? NewDepartCode { get; set; }

    public string? NewRole { get; set; }

    public string? PayScaleCode { get; set; }

    public string? PayRanges { get; set; }

    public decimal? Salary { get; set; }

    public string? ReasonMovement { get; set; }

    public string? FilePath { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime? FromTime { get; set; }

    public DateTime? ToTime { get; set; }
}
