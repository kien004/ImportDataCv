using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class PayDecisionDetail
{
    public int Id { get; set; }

    public string? DecisionNum { get; set; }

    public string? EmployeeCode { get; set; }

    public string? LabourContract { get; set; }

    public string? PayScale { get; set; }

    public decimal? Salary { get; set; }

    public bool IsDeleted { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public string? CareerCode { get; set; }

    public string? CareerTitle { get; set; }

    public string? PayRange { get; set; }
}
